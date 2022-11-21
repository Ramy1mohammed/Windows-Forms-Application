using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace MyFoods
{
    internal class DB
    {
        public static string DBFileName = "myfoods.accdb";
        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+DBFileName+"; Persist Security Info=True");
        public static OleDbCommand cmd = new OleDbCommand("", conn);

        public static void ChangeDBFileName(string NewDBFileName)
        {
            if(conn.State==ConnectionState.Closed)
            {
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+NewDBFileName+"; Persist Security Info=True";
            }
        }
        public static void Open()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public static void Close()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        public static DataTable GetData(string select)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = select;
            tbl.Load(cmd.ExecuteReader());
            return tbl;
        }
        public static void Run(string SQL)
        {
            cmd.CommandText = SQL;
            cmd.ExecuteNonQuery();
        }
    }
}
