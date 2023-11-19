using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DatabaseAccess
    {
        public static SqlConnection conn;
        public static string str = "Data Source=THIENVUVAN\\SQLEXPRESS;Initial Catalog=QuanLyGiaiBong;Integrated Security=True";
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            return conn;
        }

        public static DataTable ReadTable(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(tb);
            conn.Close();
            conn.Dispose();
            return tb;
        }

        public static void Excute(string sql)
        {
            SqlCommand cm = new SqlCommand();
            SqlConnection conn = Connect();
            conn.Open();
            cm.CommandText = sql;
            cm.Connection = conn;
            cm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public static object ExecuteScalar(string sql)
        {
            object result = null;
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            result = cmd.ExecuteScalar();
            conn.Close();
            conn.Dispose();
            return result;
        }


    }

}