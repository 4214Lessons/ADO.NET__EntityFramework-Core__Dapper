using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ADONETLesson2;



public partial class Form1 : Form
{
    SqlConnection? conn = null;
    SqlDataReader? reader = null;
    DataTable? table = null;

    SqlDataAdapter? dataAdapter = null;
    DataSet? dataSet = null;
    SqlCommandBuilder? cmdBuilder = null;



    public Form1()
    {
        InitializeComponent();
        conn = new("Data Source=(localdb)\\ProjectModels;Initial Catalog=Library;Integrated Security=True;");
    }



    private void WorkingWithDataTable()
    {
        DataTable table = new DataTable();


        // DataColumnCollection
        // DataRowCollection



        //DataColumn column = new DataColumn()
        //{
        //    AllowDBNull = false,
        //    DataType = typeof(int),
        //    DefaultValue = 0,
        //    ColumnName = "Id"
        //};



        table.Columns.Add("Id");
        table.Columns.Add("FirstName");
        table.Columns.Add("LastName");


        // DataRow row = table.NewRow();

        table.Rows.Add(1, "Isa", "Məmmədli");
        table.Rows.Add(2, "Ali", "Şamilzadə");



        dataGridView1.DataSource = table;
    }




    // DataTable with Connected Mode
    private void Btn_Exec_Click(object sender, EventArgs e)
    {
        // WorkingWithDataTable();


        try
        {
            using var command = new SqlCommand(txtCommand.Text, conn);

            conn?.Open();


            table = new DataTable();
            reader = command.ExecuteReader();


            bool isColumnName = true;

            do
            {
                while (reader.Read())
                {

                    if (isColumnName)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            table.Columns.Add(reader.GetName(i));

                        isColumnName = false;
                    }


                    DataRow row = table.NewRow();

                    for (int i = 0; i < reader.FieldCount; i++)
                        row[i] = reader[i];

                    table.Rows.Add(row);
                }
            } while (reader.NextResult());


            dataGridView1.DataSource = table;
        }

        catch
        {
            MessageBox.Show("Probably wrong request syntax");
        }
        finally
        {
            // Close the connection
            conn?.Close();
            reader?.Close();
        }
    }




    // Disconnected Mode
    // 1) DataSet
    // 2) DbDataAdapter
    private void Btn_Fill_Click(object sender, EventArgs e)
    {
        // DisconnectedMode();
        // ExampleSqlCommandBuilder();
        CustomUpdateCommand();
    }



    private void DisconnectedMode()
    {
        dataAdapter = new SqlDataAdapter("SELECT * FROM Books; SELECT * FROM Authors", conn);


        //// Open()
        //// SqlCommand
        //// SqlDataReader
        //// Close()


        // table = new DataTable();
        dataSet = new DataSet();


        //// SqlDataAdapter
        ////      Fill()
        ////      Update()

        dataAdapter.Fill(dataSet, "myTable");



        // dataGridView1.DataSource = dataSet.Tables[0];
        // dataGridView1.DataSource = dataSet.Tables[1];
        // dataGridView1.DataSource = dataSet.Tables["table"];
        //dataGridView1.DataSource = dataSet.Tables["table1"];
        dataGridView1.DataSource = dataSet.Tables["myTable1"];


        // MessageBox.Show(dataSet.Tables["Books1"]?.Rows[17][1].ToString());



        //// DataSet vs SqlDataReader
    }






    private void ExampleSqlCommandBuilder()
    {
        string selectSQL = "SELECT * FROM Authors;";

        dataAdapter = new SqlDataAdapter(selectSQL, conn);


        cmdBuilder = new SqlCommandBuilder(dataAdapter);
        //// cmdBuilder.RefreshSchema();

        dataSet = new DataSet();
        dataAdapter.Fill(dataSet, "myTable");
        // adapter.Fill(dataSet, 2, 10, "myTable");


        dataGridView1.DataSource = dataSet.Tables[0];


        Debug.WriteLine(cmdBuilder.GetInsertCommand().CommandText);
        Debug.WriteLine(cmdBuilder.GetUpdateCommand().CommandText);
        Debug.WriteLine(cmdBuilder.GetDeleteCommand().CommandText);
    }



    private void Btn_Update_Click(object sender, EventArgs e)
    {
        if (dataSet is not null)
            dataAdapter?.Update(dataSet, "myTable");
    }





    private void CustomUpdateCommand()
    {
        string selectSQL = "SELECT * FROM Books";
        dataAdapter = new SqlDataAdapter(selectSQL, conn);


        dataSet = new DataSet();
        dataAdapter.Fill(dataSet, "myTable");



        //// Way 1
        // SqlCommand updateCommand = new SqlCommand("UPDATE Books SET Pages=@pPages WHERE Id=@pId", conn);



        // Way 2
        SqlCommand updateCommand = new SqlCommand()
        {
            CommandText = "usp_UpdateBooks",
            Connection = conn,
            CommandType = CommandType.StoredProcedure,
        };




        updateCommand.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));
        updateCommand.Parameters["@pId"].SourceVersion = DataRowVersion.Original;
        updateCommand.Parameters["@pId"].SourceColumn = "Id";


        updateCommand.Parameters.Add(new SqlParameter("@pPages", SqlDbType.Int));
        updateCommand.Parameters["@pPages"].SourceVersion = DataRowVersion.Current;
        updateCommand.Parameters["@pPages"].SourceColumn = "Pages";


        dataAdapter.UpdateCommand = updateCommand;


        dataGridView1.DataSource = dataSet.Tables[0];

        MessageBox.Show(dataAdapter.UpdateCommand.CommandText);
    }
}