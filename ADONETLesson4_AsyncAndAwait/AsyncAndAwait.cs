using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADONETLesson4_AsyncAndAwait;


public partial class AsyncAndAwait : Form
{
    IConfigurationRoot? configurationRoot = null;
    string conStr = string.Empty;


    public AsyncAndAwait()
    {
        InitializeComponent();
        Configure();
    }


    private void Configure()
    {
        string projectPath = Directory.GetCurrentDirectory().Split(@"bin\")[0];

        configurationRoot = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json").Build();



        conStr = configurationRoot.GetConnectionString("ConStr");
    }









    private string SlowMethod(string file)
    {
        Thread.Sleep(3000);
        // reading file
        return $"File {file} is read";
    }


    private Task<string> SlowMethodAsync(string file)
    {
        return Task.Run(() =>
        {
            return SlowMethod(file);
        });
    }


    private async void Btn_Test1_Click(object sender, EventArgs e)
    {
        string result = await SlowMethodAsync("BigFile.txt");


        // result = await SlowMethodAsync("BigFile.txt");
        // string result1 = await SlowMethodAsync("BigFile1.txt");
        // string result2 = await SlowMethodAsync("BigFile2.txt");


        MessageBox.Show(result);
    }









    // CancellationToken
    private string SlowMethod1(string file, CancellationToken token)
    {
        Thread.Sleep(3000);
        //reading file
        token.ThrowIfCancellationRequested();
        return $"File {file} is read";
    }


    private Task<string> SlowMethodAsync1(string file, CancellationToken token)
    {
        return Task.Run(() =>
        {
            return SlowMethod1(file, token);
        });
    }





    CancellationTokenSource cts = new();

    private async void Btn_Test2_Click(object sender, EventArgs e)
    {
        try
        {
            cts.CancelAfter(TimeSpan.FromSeconds(2));

            Task<string> t1 = SlowMethodAsync1("BigFile.txt", cts.Token);
            string result = await t1;

            MessageBox.Show(result);
        }
        catch (OperationCanceledException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


    private void Btn_Cancel_Click(object sender, EventArgs e)
    {
        cts.Cancel();
    }









    private async void Btn_Async_Click(object sender, EventArgs e)
    {
        using var connection = new SqlConnection(conStr);

        await connection.OpenAsync();

        SqlCommand command = connection.CreateCommand();
        command.CommandText = "WAITFOR DELAY '00:00:05';";
        command.CommandText += txt_Request.Text.ToString();


        DataTable dataTable = new DataTable();

        using SqlDataReader reader = await command.ExecuteReaderAsync();
        int line = 0;

        do
        {
            while (await reader.ReadAsync())
            {
                if (line == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataTable.Columns.Add(reader.GetName(i));
                    }
                    line++;
                }

                DataRow row = dataTable.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                    row[i] = await reader.GetFieldValueAsync<object>(i);


                dataTable.Rows.Add(row);
            }
        } while (reader.NextResult());




        dataGridView.DataSource = null;
        dataGridView.DataSource = dataTable;



        await connection.CloseAsync();
        await reader.CloseAsync();
    }
}