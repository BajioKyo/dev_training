using System;
using System.Data;
using Microsoft.Data.Sqlite;

class Program
{
    static string connectionString = "Data Source=myvehicledb.db"; // Update with your database file path.

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display overview");
            Console.WriteLine("2. Execute a query");
            Console.WriteLine("3. Empty a table");
            Console.WriteLine("4. Delete a table");
            Console.WriteLine("Enter your choice (1/2/3/4 or 'goback' to return to the menu):");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayOverview();
                    break;
                case "2":
                    ExecuteQuery();
                    break;
                case "3":
                    EmptyTable();
                    break;
                case "4":
                    DeleteTable();
                    break;
                case "goback":
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayOverview()
    {
        string connectionString = "Data Source=myvehicledb.db"; // Update with your database file path.

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Query the SQLite master table to retrieve table names.
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT name FROM sqlite_master WHERE type='table'";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tableName = reader.GetString(0);
                        Console.WriteLine($"Table: {tableName}");

                        // Retrieve the columns in the table.
                        var columnsCommand = connection.CreateCommand();
                        columnsCommand.CommandText = $"PRAGMA table_info({tableName})";

                        using (var columnsReader = columnsCommand.ExecuteReader())
                        {
                            while (columnsReader.Read())
                            {
                                string columnName = columnsReader.GetString(1);
                                string dataType = columnsReader.GetString(2);
                                Console.WriteLine($"  Field: {columnName} ({dataType})");
                            }
                        }

                        // Retrieve the number of records in the table.
                        var countCommand = connection.CreateCommand();
                        countCommand.CommandText = $"SELECT COUNT(*) FROM {tableName}";

                        long recordCount = (long)(countCommand.ExecuteScalar() ?? 0);
                        Console.WriteLine($"  Number of Records: {recordCount}");

                        // Retrieve the first three records in the table.
                        var recordsCommand = connection.CreateCommand();
                        recordsCommand.CommandText = $"SELECT * FROM {tableName} LIMIT 3";

                        using (var recordsReader = recordsCommand.ExecuteReader())
                        {
                            Console.WriteLine("  First Three Records:");
                            while (recordsReader.Read())
                            {
                                for (int i = 0; i < recordsReader.FieldCount; i++)
                                {
                                    string fieldName = recordsReader.GetName(i);
                                    string? fieldValue = recordsReader[i].ToString();
                                    Console.WriteLine($"    {fieldName}: {fieldValue}");
                                }
                            }
                        }

                        Console.WriteLine();
                    }
                }
            }

            connection.Close();
        }
    }

    static void ExecuteQuery()
    {
        Console.WriteLine("Enter SQL query:");
        string? query = Console.ReadLine();

        try
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    using (var reader = command.ExecuteReader())
                    {
                        DataTable resultTable = new DataTable();
                        resultTable.Load(reader);

                        Console.WriteLine("Query Result:");
                        foreach (DataColumn column in resultTable.Columns)
                        {
                            Console.Write($"{column.ColumnName}\t");
                        }
                        Console.WriteLine();

                        foreach (DataRow row in resultTable.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                Console.Write($"{item}\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error executing query: {ex.Message}");
        }
    }

    static void EmptyTable()
    {
        Console.WriteLine("Enter the name of the table to empty:");
        string? tableName = Console.ReadLine();

        try
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"DELETE FROM {tableName}";
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} rows deleted from {tableName}.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error emptying table: {ex.Message}");
        }
    }

    static void DeleteTable()
    {
        Console.WriteLine("Enter the name of the table to delete:");
        string? tableName = Console.ReadLine();

        try
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"DROP TABLE IF EXISTS {tableName}";
                    command.ExecuteNonQuery();
                    Console.WriteLine($"Table {tableName} deleted.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting table: {ex.Message}");
        }
    }
}
