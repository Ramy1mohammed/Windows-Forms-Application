using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gym
{
    internal class DB
    {
        public static string strDatabaseName = "Gym";
        public static SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog="+strDatabaseName+";Integrated Security=True");
        public static void Open()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public static void Close()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        public static SqlCommand cmd = new SqlCommand("", conn);

        public static void GetData(string strCmd, DataTable tbl)
        {
            using (cmd)
            {
                cmd.CommandText = strCmd;
                tbl.Load(cmd.ExecuteReader());
            }
        }

        public static void Run(string strCmd)
        {
            using (cmd)
            {
                cmd.CommandText = strCmd;
                cmd.ExecuteNonQuery();
            }
        }
       
    }
}
