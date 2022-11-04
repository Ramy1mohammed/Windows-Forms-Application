using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Employee_Data_With_Access
{
    class InfoCommands : ConnectionString
    {
        public InfoCommands()
        {
            cmd.Connection = _conn;
        }

        OleDbConnection _conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Employee_Data.accdb;Persist Security Info=True");
        public static OleDbCommand cmd = new OleDbCommand();
        public OleDbConnection conn
        {
            get { return _conn; }
        }
        public static void select(string tblName)
        {
            cmd.CommandText = "select * from " + tblName;
        }
        public static void Insert_Values(string tblName, int num, string name,string address,double salary)
        {
            cmd.CommandText = "insert into " + tblName + " values("+num+",'"+name+"','"+address+"',"+salary+")";
            cmd.ExecuteNonQuery();
        }
        public static void Update_Values(string tblName,int num,string name,string address,int salary)
        {
            cmd.CommandText = "update " + tblName + " set empnam='" + name + "',address='" + address + "',salary=" + salary + " where empno=" + num + "";
            cmd.ExecuteNonQuery();
        }
        public static void Delete_Record(string tblName,int num)
        {
            cmd.CommandText = "delete from " + tblName + " where empno=" + num + "";
            cmd.ExecuteNonQuery();
        }
    }
}
