using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ADONETLesson3;

public partial class Form1 : Form
{
    DbProviderFactory providerFactory = null;
    DbConnection connection = null;
    IConfigurationRoot configuration = null;
    string providerName = string.Empty;


    public Form1()
    {
        InitializeComponent();
        Configure();
    }

    private void Configure()
    {
        DbProviderFactories.RegisterFactory("System.Data.SqlClient", typeof(SqlClientFactory));
        DbProviderFactories.RegisterFactory("System.Data.OleDb", typeof(OleDbFactory));

        configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
    }



    private void btnGetAllProviders_Click(object sender, EventArgs e)
    {
        var table = DbProviderFactories.GetFactoryClasses();
        // dataGridView1.DataSource = table;

        cmBoxProviders.Items.Clear();

       foreach (DataRow dr in table.Rows)
            cmBoxProviders.Items.Add(dr["InvariantName"]);

    }


    private void cmBoxProviders_SelectedIndexChanged(object sender, EventArgs e)
    {
        providerName = cmBoxProviders.SelectedItem.ToString();
        txtConStr.Text = configuration.GetConnectionString(providerName);

        CreateConnection();

    }

    private void CreateConnection()
    {
        providerFactory = DbProviderFactories.GetFactory(providerName);

        connection = providerFactory.CreateConnection();
        // SqlConnection
        // OleDbConnection

        connection.ConnectionString = txtConStr.Text;
    }


    private void btnExecute_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtRequest.Text) ||
            string.IsNullOrWhiteSpace(txtConStr.Text))
            return;


        using var command = connection.CreateCommand();
        command.CommandText = txtRequest.Text;


        using var dataAdapter = providerFactory.CreateDataAdapter();
        dataAdapter.SelectCommand = command;
        Mapping(dataAdapter);

        DataTable table = new();
        dataAdapter.Fill(table);

        dataGridView1.DataSource = table;
    }


    private void Mapping(DbDataAdapter dataAdapter)
    {
        DataTableMapping dataTableMapping1 = new DataTableMapping();
        dataTableMapping1.SourceTable = "table";
        dataTableMapping1.DataSetTable = "Books";


        DataTableMapping dataTableMapping2 = new DataTableMapping();
        dataTableMapping2.SourceTable = "table1";
        dataTableMapping2.DataSetTable = "Authors";


        DataColumnMapping dataColumnMapping = new DataColumnMapping();
        dataTableMapping1.ColumnMappings.Add(dataColumnMapping);


        dataAdapter.TableMappings.Add(dataTableMapping1);
        dataAdapter.TableMappings.Add(dataTableMapping2);

        // dataAdapter.TableMappings.Add("table1", "Authors"); 
        // dataAdapter.TableMappings.Add("table2", "T_Cards");
    }
}