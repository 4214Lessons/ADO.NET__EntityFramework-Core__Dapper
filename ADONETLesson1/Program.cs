using System.Data;
using System.Data.Common;
using System.Data.SqlClient;



namespace ADONETLesson1;


class DataAccess
{
    SqlConnection? conn = null;

    public DataAccess()
    {
        //// Way 1 
        // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        // 
        // builder.DataSource = "<your_server.database.windows.net>";
        // builder.UserID = "<your_username>";
        // builder.Password = "<your_password>";
        // builder.InitialCatalog = "<your_database>";
        // 
        // var connectionString = builder.ConnectionString;



        //// Way 2
        // var connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;




        //// Way 3
        string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Library;Integrated Security=True;";

        conn = new SqlConnection(connectionString);


    }


    // DDL, DML etc
    public void InsertQuery()
    {
        try
        {
            conn?.Open();

            string insertString = "INSERT INTO Authors(Id, FirstName, LastName) VALUES(18, 'Kenan', 'Muradov')";

            using SqlCommand cmd = new SqlCommand(insertString, conn);


            // 1) ExecuteReader() seçilmiş sorğuları emal etmək üçün nəzərdə tutulub və
            // bu sorğuların icra nəticələrini SqlDataReader obyektinə qaytarır.

            // 2) ExecuteNonQuery() sorğuları daxil etmək, yeniləmək və silmək üçün nəzərdə tutulub.

            // 3) ExecuteScalar() yalnız bir ümumi dəyəri qaytaran sorğuları yerinə yetirmək üçün nəzərdə tutulmuşdur.
            cmd.ExecuteNonQuery();

            Console.WriteLine("\nDone. Press enter.");
            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn?.Close();
        }
    }



    // Select 1
    public void SelectQuery()
    {
        SqlDataReader? reader = null;

        try
        {
            conn?.Open();

            using SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", conn);
            reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "  " + reader[1] + "  " + reader[2]);
                // Console.WriteLine(reader["Id"] + "  " + reader["FirstName"] + "  " + reader["LastName"]);
            }


            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }



    // Select 2
    public void ReadData()
    {
        SqlDataReader? reader = null;


        try
        {
            conn?.Open();

            using SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", conn);
            reader = cmd.ExecuteReader();

            int line = 0;

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i) + "  ");

                Console.WriteLine();


                while (reader.Read())
                {
                    line++;

                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.Write(reader[i] + "  ");

                    Console.WriteLine();
                }
            }



            Console.WriteLine("\nHandled records: " + line.ToString());
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }

    }



    // Select 3
    // Batch processing of queries
    public void MultiQueries()
    {
        SqlDataReader? reader = null;

        try
        {
            conn?.Open();

            using SqlCommand cmd = new SqlCommand("SELECT * FROM Authors; SELECT * FROM Books", conn);
            reader = cmd.ExecuteReader();


            int line = 0;

            do
            {
                while (reader.Read())
                {
                    if (line == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            Console.Write(reader.GetName(i) + "  ");
                        Console.WriteLine();
                    }

                    line++;


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "   ");
                    }
                    Console.WriteLine();


                }


                Console.WriteLine("\nHandled records: " + line.ToString());
                line = 0;
            } while (reader.NextResult());

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }


        Console.WriteLine("\nDone. Press enter.");
        Console.ReadLine();
    }




    // Parameterized queries in DbCommand
    public void ParameterizedQueries()
    {
        SqlDataReader? reader = null;

        try
        {
            conn?.Open();

            using SqlCommand cmd = new SqlCommand("SELECT * FROM Authors WHERE FirstName=@p1", conn);




            //// way 1
            // SqlParameter param1 = new SqlParameter();
            // param1.ParameterName = "@p1";
            // param1.SqlDbType = SqlDbType.NVarChar;
            // param1.Value = "Kenan";
            // cmd.Parameters.Add(param1);



            //// way 2
            // cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = "Kenan";



            //// way 3
            cmd.Parameters.AddWithValue("@p1", "Kenan");

            reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
            }

        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }




    // Stored procedures in DbCommand
    public void ExecStoredProcedure()
    {
        try
        {
            conn?.Open();

            using SqlCommand cmd = new SqlCommand("usp_getBooksNumber", conn);
            cmd.CommandType = CommandType.StoredProcedure;




            SqlParameter inputParam = new SqlParameter("@AuthorId", SqlDbType.Int);
            inputParam.Value = 5;
            cmd.Parameters.Add(inputParam);



            SqlParameter outputParam = new SqlParameter("@BookCount", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);


            cmd.ExecuteNonQuery();


            Console.WriteLine(cmd.Parameters["@BookCount"].Value);

        }
        finally
        {
            conn?.Close();
        }
    }




    public void Task1()
    {
        SqlDataReader? reader = null;

        try
        {
            conn?.Open();


            using SqlCommand cmd = new("SELECT SUM(Pages) AS TotalPages, SUM(Quantity) AS TotalQuantity FROM Books", conn);
            reader = cmd.ExecuteReader();



            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i) + "  ");

                Console.WriteLine();


                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader[i] + "  ");

                Console.WriteLine();
            }



            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }


    public void Task2()
    {
        try
        {
            conn?.Open();

            using SqlCommand cmd = new("SELECT SUM(Pages) AS TotalPages FROM Books", conn);

            Console.WriteLine(cmd.ExecuteScalar());
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn?.Close();
        }
    }
}



class Program
{
    static void Main()
    {
        DataAccess dataAccess = new();
        // dataAccess.InsertQuery();
        // dataAccess.SelectQuery();
        // dataAccess.ReadData();
        // dataAccess.MultiQueries();
        // dataAccess.ParameterizedQueries();
        // dataAccess.ExecStoredProcedure();
        dataAccess.Task1();
        dataAccess.Task2();
    }
}














////// Task

// Verilənlər bazamız üçün Kitablar cədvəlindəki bütün kitabların qiymətlərinin cəmini və bütün kitabların
// səhifələrinin cəmini hesablayan bir konsol tətbiqi yazmalısınız.


// HELP: (ExecuteNonQuery(), ExecuteScalar() və ya ExecuteReader())


//  SELECT SUM(Pages) AS TotalPages, SUM(Quantity) AS TotalQuantity FROM Books
//  SELECT SUM(Pages) AS TotalPages FROM Books






////// Yekun

// DbConnection – verilənlər bazası bağlantısı üçün;
// DbCommand – verilənlər bazası sorğularını və saxlanılan prosedurları yerinə yetirmək və verilənlər bazasından nəticələr əldə etmək üçün;
// DbDataReader – seçilmiş sorğuların icrasının nəticələrini çıxarmaq üçün;
// DbParameter – verilənlər bazasına parametrləşdirilmiş istinadların yaradılması üçün;