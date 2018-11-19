using Mono.Data.Sqlite;
using System.Collections.Generic;
using System.Data;

public static class DialogueDao
{
    public static string DatabasePath { get; set; }

    public static Dictionary<string, string> GetAll(string languageCode)
    {
        IDbConnection connection = new SqliteConnection(DatabasePath);
        connection.Open();
        IDbCommand command = connection.CreateCommand();
        command.CommandText = $"SELECT name, {languageCode} FROM dialogue";
        IDataReader reader = command.ExecuteReader();

        var dictionary = new Dictionary<string, string>();
        while (reader.Read())
        {
            dictionary.Add(reader.GetString(0), reader.GetString(1));
        }

        reader.Close();
        connection.Close();
        return dictionary;
    }
}
