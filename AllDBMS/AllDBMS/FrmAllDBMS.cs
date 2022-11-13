using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess;
using Npgsql;
using System.Data.SQLite;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Reporting.WinForms;

namespace AllDBMS
{
    public partial class FrmAllDBMS : Form
    {
        public FrmAllDBMS()
        {
            InitializeComponent();
        }

        private void FrmAllDBMS_Load(object sender, EventArgs e)
        {
            cbxDBMS.SelectedIndex = 0;           
        }

        static OleDbConnection connAccess = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=alldbms.accdb;Persist Security Info=True");
        static SqlConnection connSQLServer = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=alldbms;Integrated Security=True");
        static MySqlConnection connMySql = new MySqlConnection("Server=localhost;database=alldbms;UID=root;Password=;SslMode=none");
        static OracleConnection connOracle = new OracleConnection("Data Source=localhost;User Id=alldbms;Password=alldbms123;");
        static NpgsqlConnection connPostgre = new NpgsqlConnection("Server=localhost;port=5432;User Id='postgres';Password='123456';Database='alldbms'");
        static SQLiteConnection connSqlite = new SQLiteConnection("Data Source=alldbms");

        OleDbCommand cmdAccess = new OleDbCommand("", connAccess);
        SqlCommand cmdSqlServer = new SqlCommand("", connSQLServer);
        MySqlCommand cmdMySql = new MySqlCommand("", connMySql);
        OracleCommand cmdOracle = new OracleCommand("", connOracle);
        NpgsqlCommand cmdPostgre = new NpgsqlCommand("", connPostgre);
        SQLiteCommand cmdSqlite = new SQLiteCommand("", connSqlite);

        OleDbDataAdapter adapterAccess = new OleDbDataAdapter("select * from employee", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=alldbms.accdb;Persist Security Info=True");
        SqlDataAdapter adapterSQLServer = new SqlDataAdapter("select * from employee", "Data Source=.\\SQLEXPRESS;Initial Catalog=alldbms;Integrated Security=True");
        MySqlDataAdapter adapterMySql = new MySqlDataAdapter("select * from employee", "Server=localhost;database=alldbms;UID=root;Password=;SslMode=none");
        OracleDataAdapter adapterOracle = new OracleDataAdapter("select * from employee", "Data Source=localhost;User Id=alldbms;Password=alldbms123;");
        NpgsqlDataAdapter adapterPostgre = new NpgsqlDataAdapter("select * from employee", "Server=localhost;port=5432;User Id='postgres';Password='123456';Database='alldbms'");
        SQLiteDataAdapter adapterSqlite = new SQLiteDataAdapter("select * from employee", "Data Source=alldbms");

        DataSet ds = new DataSet();

        private void SetAdapter()
        {
            OleDbCommandBuilder builderAccess;
            SqlCommandBuilder builderSQLServer;
            MySqlCommandBuilder builderMySql;
            OracleCommandBuilder builderOracle;
            NpgsqlCommandBuilder builderPostgre;
            SQLiteCommandBuilder builderSqlite;

            if (cbxDBMS.SelectedIndex == 1)
            {
                builderAccess = new OleDbCommandBuilder(adapterAccess);
                adapterAccess.Update(ds);
            }
            else if (cbxDBMS.SelectedIndex == 2)
            {
                builderSQLServer = new SqlCommandBuilder(adapterSQLServer);
                adapterSQLServer.Update(ds);
            }
            else if (cbxDBMS.SelectedIndex == 3)
            {
                builderMySql = new MySqlCommandBuilder(adapterMySql);
                adapterMySql.Update(ds);
            }
            else if (cbxDBMS.SelectedIndex == 4)
            {
                builderOracle = new OracleCommandBuilder(adapterOracle);
                adapterOracle.Update(ds);
            }
            else if (cbxDBMS.SelectedIndex == 5)
            {
                builderPostgre = new NpgsqlCommandBuilder(adapterPostgre);
                adapterPostgre.Update(ds);
            }
            else
            {
                builderSqlite = new SQLiteCommandBuilder(adapterSqlite);
                adapterSqlite.Update(ds);
            }
        }
        private void cbxDBMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDBMS.Text = "All DBMS - "+( (cbxDBMS.SelectedIndex == 0) ? "Not Connected" : "Connected on "+cbxDBMS.Text);
            btnCreateTable.Enabled = ((cbxDBMS.SelectedIndex == 0) ? false : true);
            pnlAll.Enabled = false;
            ShowData();

            ClearData();
            if (cbxDBMS.SelectedIndex == 0)
            {
                ds.Clear();
            }

            pnlAll.Enabled = ((cbxDBMS.SelectedIndex == 0) ? false : true);
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxDBMS.SelectedIndex == 1)
                {
                    cmdAccess.CommandText = "create table employee (empno int primary key,empname text,city text ,salary int)";
                    connAccess.Open();
                    cmdAccess.ExecuteNonQuery();                    
                }
               else if (cbxDBMS.SelectedIndex == 2)
                {
                    cmdSqlServer.CommandText = "create table employee (empno int primary key,empname nvarchar(255),city nvarchar(255) ,salary int)";
                    connSQLServer.Open();
                    cmdSqlServer.ExecuteNonQuery();                    
                }
                else if (cbxDBMS.SelectedIndex == 3)
                {
                    cmdMySql.CommandText = "create table employee (empno int primary key,empname varchar(255),city varchar(255) ,salary int)";
                    connMySql.Open();
                    cmdMySql.ExecuteNonQuery();                    
                }
                else if (cbxDBMS.SelectedIndex == 4)
                {
                    cmdOracle.CommandText = "create table employee (empno number primary key,empname varchar2(255),city varchar2(255) ,salary number)";
                    connOracle.Open();
                    cmdOracle.ExecuteNonQuery();                    
                }
                else if (cbxDBMS.SelectedIndex == 5)
                {
                    cmdPostgre.CommandText = "create table employee (empno numeric primary key,empname text,city text ,salary numeric)";
                    connPostgre.Open();
                    cmdPostgre.ExecuteNonQuery();                    
                }
                else
                {
                    cmdSqlite.CommandText = "create table employee (empno int primary key,empname text,city text ,salary int)";
                    connSqlite.Open();
                    cmdSqlite.ExecuteNonQuery();                    
                }
                MessageBox.Show("Table Created...");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connAccess.Close();
                connSQLServer.Close();
                connMySql.Close();
                connOracle.Close();
                connPostgre.Close();
                connSqlite.Close();
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&(!char.IsControl(e.KeyChar)&& e.KeyChar!='.'))
            {
                e.Handled = true;
            }
            if(txtSalary.Text.Contains("."))
            {
                if(e.KeyChar=='.')
                e.Handled = true;
            }
        }
        private void ShowData()
        {
            try
            {
                ds.Clear();
                if (cbxDBMS.SelectedIndex == 1)
                {
                    adapterAccess.Fill(ds);
                }
                else if (cbxDBMS.SelectedIndex == 2)
                {
                    adapterSQLServer.Fill(ds);
                }
                else if (cbxDBMS.SelectedIndex == 3)
                {
                    adapterMySql.Fill(ds);
                }
                else if (cbxDBMS.SelectedIndex == 4)
                {
                    adapterOracle.Fill(ds);
                }
                else if (cbxDBMS.SelectedIndex == 5)
                {
                    adapterPostgre.Fill(ds);
                }
                else
                {
                    adapterSqlite.Fill(ds);
                }
                dgvData.DataSource = ds.Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                cbxDBMS.SelectedIndex = 0;
            }
        }
        private void ClearData()
        {
            if(ds.Tables.Count>0)
            {
                Tools.ClearData(pnlAll);
                string strAutoNum = "1";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int iAutoNum = Convert.ToInt32(ds.Tables[0].Compute("max(empno)", "")) + 1;
                    strAutoNum = iAutoNum.ToString();
                }
                txtNumber.Text = strAutoNum;

                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                txtName.Select();
                txtName.Focus();
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rdoNumber.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
            else if(rdoSalary.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if (txtSearch.Text.Contains("."))
                {
                    if (e.KeyChar == '.')
                        e.Handled = true;
                }
            }
        }

        private void rdoNumber_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "1";
        }

        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "1500";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(ds.Tables.Count>0)
                {
                    ds.Tables[0].Rows.Add(txtNumber.Text, txtName.Text, txtCity.Text, txtSalary.Text);
                    SetAdapter();
                    ShowData();
                    ClearData();
                }
            }catch(Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            dgvData.CurrentRow.Selected = false;
            if (dgvData.CurrentRow!=null)
            {
                txtNumber.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                txtCity.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                txtSalary.Text = dgvData.CurrentRow.Cells[3].Value.ToString();                

                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvData.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            if (dgvData.CurrentRow != null)
            {
                dgvData.CurrentRow.DefaultCellStyle.BackColor = Color.Red;

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (dgvData.CurrentRow != row)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private DataRow FindRow(string EmpNO)
        {
            if (ds.Tables[0].PrimaryKey.Count() == 0)
                ds.Tables[0].Constraints.Add("empno_PK", ds.Tables[0].Columns[0], true);
            return ds.Tables[0].Rows.Find(EmpNO);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(ds.Tables.Count > 0)
                {
                    DataRow row = FindRow(txtNumber.Text);
                    row[1] = txtName.Text;
                    row[2] = txtCity.Text;
                    row[3] = txtSalary.Text;
                    SetAdapter();
                    ShowData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(ds.Tables.Count > 0)
                {
                    DataRow row = FindRow(txtNumber.Text);
                    row.Delete();

                    SetAdapter();
                    ShowData();
                    ClearData();
                     
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string strempno = Tools.InputBox("Enter Name", "Enter Name: ");
            if (strempno.Trim() == "") return;
            int Iempno = Tools.GetNumberOnly(strempno);
            if (Iempno == 0) return;
            DataRow row = FindRow(Iempno.ToString());
            if (row != null)
            {
                txtNumber.Text = row[0].ToString();
                txtName.Text = row[1].ToString();
                txtCity.Text = row[2].ToString();
                txtSalary.Text = row[3].ToString();

                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            { MessageBox.Show("This Number Not Found!"); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strPatt = "";
            if(rdoNumber.Checked)
            {
                if (txtSearch.Text.Trim() == "") return;
                strPatt = "empno=" + txtSearch.Text;
            }
            else if(rdoName.Checked)
            {
                strPatt = "empname like'%" + txtSearch.Text + "%'";
            }
            else if(rdoCity.Checked)
            {
                strPatt = "city like'%" + txtSearch.Text + "%'";
            }
            else
            {
                if (txtSearch.Text.Trim() == "") return;
                strPatt = "salary=" + txtSearch.Text;
            }
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = strPatt;
            dgvData.DataSource = dv;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();

            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rds);
            frm.reportViewer1.LocalReport.Refresh();

            frm.ShowDialog();

        }
    }
}
