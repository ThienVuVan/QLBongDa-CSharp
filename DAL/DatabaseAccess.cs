using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{

    public class SqlConnectionData
    {
        public static SqlConnection conn;
        public static string str = "Data Source=THIENVUVAN\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }
    }

    public class DatabaseAccess
    {
        public DatabaseAccess() { }

        public static string CheckLogin(User user)
        {
            string name = null;
            // connect to database
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = ("select * from dbo.users u where u.username = '" + user.username + "' and u.password = '" + user.password + "' ");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    name = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
                return name;
            }
            else
            {
                return "Tai khoan khong dung";
            }
        }
    }
}
