using System;
using Microsoft.Data.Sqlite;

public class ManageDB
{
    string _connectionString = @"Data Source=Journals.db";
    public void CreateConnection()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                @"CREATE TABLE IF NOT EXISTS journals (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    date TEXT,
                    prompt TEXT,
                    entry TEXT
                    )";
        
            tableCmd.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void CreateTempConnection()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                @"CREATE TEMPORARY TABLE IF NOT EXISTS journals_temp (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    date TEXT,
                    prompt TEXT,
                    entry TEXT
                    )";
        
            tableCmd.ExecuteNonQuery();
        }
    }
    public void Write(List<string> valuesList)
    {   
        string date = valuesList[0];
        string prompt = valuesList[1];
        string content = valuesList[2];
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                $"INSERT INTO journals_temp (date, prompt, entry) VALUES('{date}', '{prompt}', '{content}')";
        
            tableCmd.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void GetRecords()
    {   
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                $"SELECT * FROM journals_temp";
            List<DBType> tableData = new();
            SqliteDataReader reader = tableCmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tableData.Add(
                    new DBType
                    {
                        id = reader.GetInt32(0),
                        date = reader.GetString(1),
                        prompt = reader.GetString(2),
                        entry = reader.GetString(3)
                    });
                }
            }
            else
            {
                Console.WriteLine("No data found");
            } 
            Console.WriteLine("----------------------------------------\n");
            foreach(var row in tableData)
            {
                Console.WriteLine($"Entry #{row.id} - Date: {row.date} - Prompt: {row.prompt}\n{row.entry}");
            }
            Console.WriteLine("----------------------------------------\n");
            
        }
    }

    public void GetAllRecords()
    {   
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                $"SELECT * FROM journals";
            List<DBType> tableData = new();
            SqliteDataReader reader = tableCmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tableData.Add(
                    new DBType
                    {
                        id = reader.GetInt32(0),
                        date = reader.GetString(1),
                        prompt = reader.GetString(2),
                        entry = reader.GetString(3)
                    });
                }
            }
            else
            {
                Console.WriteLine("No data found");
            } 
            connection.Close();
            Console.WriteLine("----------------------------------------\n");
            foreach(var row in tableData)
            {
                Console.WriteLine($"Entry #{row.id} - Date: {row.date} - Prompt: {row.prompt}\n{row.entry}");
            }
            Console.WriteLine("----------------------------------------\n");
        }
    }

    public void SaveEntries(){
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                $"INSERT INTO journals (date, prompt, entry) SELECT date, prompt, entry FROM journals_temp";
            tableCmd.ExecuteNonQuery();
            var tableCmd2 = connection.CreateCommand();
            tableCmd2.CommandText = 
                $"DELETE FROM journals_temp";
            tableCmd2.ExecuteNonQuery();
            
            connection.Close();
        }
    }

    public void DiscardEntries()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                $"DELETE FROM journals_temp";
            tableCmd.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void DeleteEspEntry(int target)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                $"DELETE FROM journals WHERE id = {target}";
            tableCmd.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void DeleteAllEntries()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = 
                $"DELETE FROM journals";
            tableCmd.ExecuteNonQuery();
            var tableCmd2 = connection.CreateCommand();
            tableCmd2.CommandText = 
                $"DELETE FROM journals_temp";
            tableCmd2.ExecuteNonQuery();
            connection.Close();
        }
    }
}

public class DBType
{
    public int id { get; set; }
    public string date { get; set; }
    public string prompt { get; set; }
    public string entry { get; set;}
}
