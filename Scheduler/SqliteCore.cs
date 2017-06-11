using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

class SqliteCore
{
    SQLiteConnection dbcon;
    
    public SqliteCore(string fileName, string password)
    {
        String dbConnection = String.Format("Data Source={0};password={1}", fileName, password);
        dbcon = new SQLiteConnection(dbConnection);
    }
    public void query(string query)
    {
        SQLiteCommand cmd = new SQLiteCommand();
        dbcon.Open();
        cmd.Connection = dbcon;//SQLite connection
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
        dbcon.Close();
        cmd.Dispose();
    }
    public DataTable readTable(string query)
    {
        DataTable dt = new DataTable();
        SQLiteDataAdapter sqliteAdapter = new SQLiteDataAdapter(query, dbcon);
        sqliteAdapter.Fill(dt);
        sqliteAdapter.Dispose();
        return dt;
    }
}
