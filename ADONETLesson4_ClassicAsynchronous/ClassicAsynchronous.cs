using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ADONETLesson4_ClassicAsynchronous;


public partial class ClassicAsynchronous : Form
{
    string conStr = string.Empty;


    SqlConnection? connection = null;
    SqlDataAdapter? dataAdapter = null;
    DataSet? dataSet = null;
    DataTable? dataTable = null;


    public ClassicAsynchronous()
    {
        InitializeComponent();
        Configure();
    }


    private void Configure()
    {
        string projectPath = Directory.GetCurrentDirectory().Split(@"bin\")[0];

        IConfigurationRoot? configurationRoot = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json").Build();



        conStr = configurationRoot.GetConnectionString("ConStr");
    }










    private void Btn_Fill_Click(object sender, EventArgs e)
    {
        try
        {
            // var commandText = txt_Request.Text;
            var commandText = "SELECT * FROM Books";

            connection = new SqlConnection(conStr);
            dataAdapter = new SqlDataAdapter(commandText, connection);
            dataSet = new DataSet();


            var sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);


            dataAdapter.Fill(dataSet);




            //// Filter DataSet
            // using var dvm = new DataViewManager(dataSet);
            // 
            // dvm.DataViewSettings[dataSet.Tables[0]].RowFilter = "Id > 5";
            // // dvm.DataViewSettings[0].Sort = "Pages ASC";
            // 
            // DataView dataView = dvm.CreateDataView(dataSet.Tables[0]);



            // Filter DataTable
            var dataView = dataSet.Tables[0].DefaultView;
            dataView.RowFilter = "Id > 5";


            dataGridView.DataSource = null;
            dataGridView.DataSource = dataView;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void Btn_Update_Click(object sender, EventArgs e)
    {
        if (dataSet is not null)
            dataAdapter?.Update(dataSet);
    }












    private void Btn_Transaction_Click(object sender, EventArgs e)
    {
        // Explicit transaction vs Implicit transaction


        connection = new SqlConnection(conStr);
        SqlTransaction? transaction = null;


        try
        {
            connection.Open();

            transaction = connection.BeginTransaction();

            using SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;

            command.CommandText = @"CREATE TABLE TestTransaction(Id int NOT NULL IDENTITY(1,1) PRIMARY KEY, Name nvarchar(20), Age int)";
            command.ExecuteNonQuery();

            command.CommandText = @"INSERT INTO TestTransaction VALUES('Emin', 14)";
            command.ExecuteNonQuery();


            // Bilərəkdən sehv edək ki, Transaction rollback olsun.
            command.CommandText = @"INSERT INTO TestTransactionWRONG VALUES('Kənan', 19)";
            command.ExecuteNonQuery();

            transaction.Commit();
            MessageBox.Show("Commit");

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Rollback {ex.Message}");
            transaction?.Rollback();
        }
        finally
        {
            connection?.Close();
        }
    }












    private void Btn_Async1_Click(object sender, EventArgs e)
    {
        //const string AsyncEnabled = "Asynchronous Processing=true";

        //if (!conStr.Contains(AsyncEnabled))
        //    conStr = $"{conStr} {AsyncEnabled}";



        connection = new SqlConnection(conStr);
        using SqlCommand command = connection.CreateCommand();


        var commandText = "WAITFOR DELAY '00:00:04'; SELECT * FROM Books;";
        command.CommandText = commandText;
        command.CommandType = CommandType.Text;

        // Default 30-dur, əgər bizə vaxt çox lazım olsa bunu dəyişməliyik.
        command.CommandTimeout = 30;


        try
        {
            connection.Open();
            AsyncCallback callback = new AsyncCallback(GetDataCallBack);

            // Əlavə thread işi bu metodu çağırarkən başlayır:
            command.BeginExecuteReader(callback, command);

            MessageBox.Show("Added thread is working...");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }



    // Delegate-dan dolayı Prototip belə olmalıdır. 
    private void GetDataCallBack(IAsyncResult result)
    {
        SqlDataReader? dataReader = null;

        try
        {
            using SqlCommand? command = result.AsyncState as SqlCommand;
            dataReader = command?.EndExecuteReader(result);

            dataTable = new DataTable();


            int line = 0;
            do
            {
                while (dataReader?.Read() ?? false)
                {
                    if (line == 0)
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            dataTable.Columns.Add(dataReader.GetName(i));
                        }
                        line++;
                    }

                    DataRow row = dataTable.NewRow();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        row[i] = dataReader[i];
                    }
                    dataTable.Rows.Add(row);
                }

            } while (dataReader?.NextResult() ?? false);


            dataGridView.Invoke(() => dataGridView.DataSource = dataTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            if (dataReader is not null && !dataReader.IsClosed)
                dataReader.Close();
        }
    }












    private void Btn_Async2_Click(object sender, EventArgs e)
    {
        connection = new SqlConnection(conStr);

        SqlCommand comm = connection.CreateCommand();
        comm.CommandText = "WAITFOR DELAY '00:00:05'; SELECT * FROM Books;";


        try
        {
            connection.Open();

            IAsyncResult iar = comm.BeginExecuteReader();
            WaitHandle handle = iar.AsyncWaitHandle;



            // Əlavə thread-də hər hansı bir xəta baş verərsə, tətbiqin dondurulmaması üçün
            // vaxtı WaitOne() metodunda müəyyən edilmişdir.


            // Siz başa düşürsünüz ki, WaitOne() zəngi bloklanır və tətbiqimiz əsas mövzunun tamamlanmasını gözləyir.
            // Görünür ki, bu, çatışmazlıqdır. Ancaq bəzi hallarda əlavə mövzu tamamlanana qədər tətbiqin heç bir əlaqəsi yoxdur.



            // while (!iar.IsCompleted) { }



            if (handle.WaitOne(10000))
            {
                GetData(comm, iar);
            }
            else
            {
                MessageBox.Show("TimeOut exceeded");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }



    private void GetData(SqlCommand command, IAsyncResult ia)
    {
        SqlDataReader? dataReader = null;

        try
        {
            dataReader = command.EndExecuteReader(ia);
            dataTable = new DataTable();

            int line = 0;

            do
            {
                while (dataReader.Read())
                {
                    if (line == 0)
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            dataTable.Columns.Add(dataReader.GetName(i));
                        }
                        line++;
                    }

                    DataRow row = dataTable.NewRow();

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        row[i] = dataReader[i];
                    }

                    dataTable.Rows.Add(row);
                }
            } while (dataReader.NextResult());


            dataGridView.DataSource = dataTable;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            if (dataReader is not null && !dataReader.IsClosed)
                dataReader.Close();
        }
    }
}