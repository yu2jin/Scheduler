using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Scheduler
{
    class Con_Database
    {
        //DB 접속 경로
        public static string strConn =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\yujl0\Desktop\Scheduler\Scheduler\Database_schedule.mdf;
            Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private string sConnString = "";

        //DB 접속
        public void ConnectDB()
        {
            try
            {
                sConnString = strConn;
            }
            catch
            {
            }
            if (conn.State.ToString().Equals("Closed"))
            {
                conn.ConnectionString = sConnString;
                //conn.Open();
            }
        }

        //DB 접속 종료
        public void CloseDB()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public DataTable GetDBTable(string selectCommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, strConn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(dt);

            return dt;
        }
    }
}
