using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfScheduler.Kostili
{
    internal class DataBase
        {
            public static bool LogEnabled = true;
            public List<string> tables;
            public string table;
            public List<string> columns;
            public List<List<string>> values;

            private readonly string connectionString =
                "Data Source = 46.39.232.190; Initial Catalog = Timur;User Id = WeedFieldsLord422; Password = vag!na21519687##;";


            public DataBase(string dataSource, string initialCatalog, string userId, string password)
            {
                connectionString =
                    $"Data Source = {dataSource}; Initial Catalog = {initialCatalog};User Id = {userId}; Password = {password};";
                tables = GetTables(initialCatalog);

            }

            public DataBase()
            {
                connectionString =
                    "Data Source = 46.39.232.190; Initial Catalog = Agronomic_App_TestUser;User Id=TestUser; Password=vag!nA228##; Encrypt=False;";
            tables = GetTables("Agronomic_App_TestUser");
            }

        public List<List<string>> Execute(string queryString, bool log = true)
            {
                List<List<string>> result = new List<List<string>>();
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        int index = 0;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                while (true)
                                {
                                    try
                                    {
                                        while (index >= result.Count)
                                            result.Add(new List<string>());
                                        result[index].Add(reader[index].ToString());
                                        index++;
                                    }
                                    catch (Exception)
                                    {
                                        break;
                                    }
                                }

                                index = 0;

                            }
                        }
                        return result;
                    }
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                return new List<List<string>>() { new List<string>() { e.Number.ToString() } };
                }

            }

            public string GetScalarValue(string command, string column)
            {
                string queryString = "";

                if (command == "Count")
                    queryString = $"SELECT {command.ToUpper()}(*) FROM dbo.{table}";
                if (command == "Min" | command == "Max" | command == "Sum")
                    queryString = $"SELECT {command.ToUpper()}({column}) FROM dbo.{table}";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        return new SqlCommand(@queryString, connection).ExecuteScalar().ToString();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

            public void ParameterInsert(params string[] values)
            {
                string queryString =
                    $"INSERT INTO dbo.{table} ({columns.Skip(1).Aggregate((x, y) => x + "," + y)}) VALUES ({values.Select(x => $"'{x}'").Aggregate((x, y) => x + "," + y)})";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        for (int i = 0; i < values.Length; i++)
                            command.Parameters.AddWithValue($"{columns[i]}", values[i]);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{queryString} \n\n {e.Message}");
                }
            }


            public void SwitchTable(string newTable)
            {
                table = newTable;
                Update();

            }

            public void Update()
            {
                columns = GetColumns();
                values = GetValues();
                List<List<string>> valuesCopy = new List<List<string>>(values);
                //valuesCopy[1] = valuesCopy[1].Select(x => x).ToList().OrderByDescending(x => x).Select(x => x.ToString()).ToList();

                //for (int i = 0; i < values.Count - 1; i++)
                //{
                //    if (i == 1)
                //        continue;
                //    values[i] = values[i].OrderByDescending(x => valuesCopy[1][valuesCopy.IndexOf(x)]).ToList();
                //}
            }

            private List<string> GetTables(string initialCatalog) => Execute(
                $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '{initialCatalog}'")
                [0];

            private List<string> GetColumns() =>
                Execute($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}'")[0];

            private List<List<string>> GetValues() => Execute($"SELECT * FROM [dbo].[{table}]");

            public void DeleteRow(string id) => Execute($"DELETE dbo.{table} WHERE {columns[0]}='{id}'");

            public void InsertRow(List<string> values) =>
                Execute(
                    $"INSERT INTO [dbo].[{table}] ({columns.Skip(1).Aggregate((x, y) => x + "," + y)}) VALUES ({values.Select(x => $"'{x}'").Aggregate((x, y) => x + "," + y)})");

            public void UpdateRow(string id, List<string> values) => Execute($"UPDATE dbo.{table} " +
                                                                             $"SET {columns.Skip(1).Select(x => $"{x}='{values.Skip(1).ToList()[GetColumns().Skip(1).ToList().IndexOf(x)]}'").Aggregate((i, j) => i + "," + j).Trim()} WHERE {GetColumns()[0]}='{id}'");
        }
    }
