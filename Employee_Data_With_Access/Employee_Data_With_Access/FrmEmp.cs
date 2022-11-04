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
using Microsoft.Reporting.WinForms;
using Employee_Data_With_Access.Employee_DataDataSetTableAdapters;

namespace Employee_Data_With_Access
{
    public partial class FrmEmp : Form
    {
        public FrmEmp()
        {
            InitializeComponent();
        }
        InfoCommands Info = new InfoCommands();
        OleDbConnection conn = new InfoCommands().conn;
        DataTable tblemp = new DataTable();

        private bool CheckTextNotNull()
        {
            bool OK = true;
            if (txtNumber.Text.Trim() == "")
            {
                MessageBox.Show("ادخل رقم الموظف");
                return OK;
            }
            else if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("ادخل اسم الموظف");
                return OK;
            }
            else if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("ادخل عنوان الموظف");
                return OK;
            }
            else if (txtSalary.Text.Trim() == "")
            {
                MessageBox.Show("ادخل مرتب الموظف");
                return OK;
            }
            return false;
        }

        private async void LoadingTable()
        {
            conn.Open();
            InfoCommands.select("emp");
            tblemp.Load(await InfoCommands.cmd.ExecuteReaderAsync());
            tblemp.Constraints.Add("empn_Pk", tblemp.Columns[0], true);
            conn.Close();
            dgvSearch.Invoke((MethodInvoker)delegate { dgvSearch.DataSource = tblemp; });
            Clear_inputs(tblemp);
        }
        private void Clear_inputs(DataTable tbl)
        {
            Tools.ClearData(pnlNewEmp);
            string strAuto = "";
            if (tbl.Rows.Count < 1)
            {
                strAuto = "1";
            }
            else
            {
                int AutoNum = Convert.ToInt32(tbl.Compute("max(empno)", "")) + 1;
                strAuto = AutoNum.ToString();
            }
            txtNumber.Invoke((MethodInvoker)delegate { txtNumber.Text = strAuto;
                txtName.Focus();
                txtName.Select();

                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            });
        }
        private void FrmEmp_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);

            bgwork.RunWorkerAsync();
            //Clear_inputs(tblemp);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear_inputs(tblemp);

            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckTextNotNull())
            {
                return;
            }
            DataTable tbl = new DataTable();

            int Intnum = Convert.ToInt32(txtNumber.Text);
            string strname = txtName.Text;
            string straddress = txtAddress.Text;
            double dblsalary = Convert.ToDouble(txtSalary.Text);

            conn.Open();
            InfoCommands.Insert_Values("emp", Intnum, strname, straddress, dblsalary);
            InfoCommands.select("emp");
            tbl.Load(InfoCommands.cmd.ExecuteReader());
            conn.Close();

            dgvSearch.DataSource = tbl;

            Clear_inputs(tbl);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string str = Tools.InputBox("ادخل رقم الوظف", "ادخل رقم الموظف :");
            int NumberOnly = Tools.GetNumberOnly(str);

            DataRow row = tblemp.Rows.Find(NumberOnly);
            if (row != null)
            {
                txtNumber.Text = row[0].ToString();
                txtName.Text = row[1].ToString();
                txtAddress.Text = row[2].ToString();
                txtSalary.Text = row[3].ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
            else { Tools.MsgBox("موظف غير موجود!"); }
        }

        private void AcceptNumsOnly(TextBox txt,KeyPressEventArgs e )
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))) e.Handled = true;

            if (e.KeyChar == '.')
            {
                e.Handled = false;
                if (txt.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptNumsOnly((TextBox)sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckTextNotNull())
            { return; }

            DataTable tbl = new DataTable();

            int num = Convert.ToInt32(txtNumber.Text);
            string name = txtName.Text;
            string address = txtAddress.Text;
            int salary = Convert.ToInt32(txtSalary.Text);

            conn.Open();
            InfoCommands.Update_Values("emp", num, name, address, salary);
            InfoCommands.select("emp");
            tbl.Load(InfoCommands.cmd.ExecuteReader());
            conn.Close();

            dgvSearch.DataSource = tbl;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();

            if (txtNumber.Text.Trim() != "")
            {
                DialogResult dr = MessageBox.Show("هل تريد حذف الموظف؟", "حذف موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                    InfoCommands.Delete_Record("emp", int.Parse(txtNumber.Text));
                    InfoCommands.select("emp");
                    tbl.Load(InfoCommands.cmd.ExecuteReader());
                    conn.Close();
                    dgvSearch.DataSource = tbl;
                    Clear_inputs(tbl);
                }
                else
                {
                    //Do Nothing
                }
            }
        }

        private void bgwork_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadingTable();           
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            dgvSearch.CurrentRow.Selected = false;
            if (dgvSearch.CurrentRow != null)
            {
                txtNumber.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                txtSalary.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();

                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable tblFiltered = new DataTable();
            foreach(DataColumn c in tblemp.Columns)
            {
                tblFiltered.Columns.Add(c.ColumnName, c.DataType);
            }

            string strText = txtSearch.Text;
            DataRow[] rows=null;
            if (strText.Trim() == "")
            {
               rows=tblemp.Select();
            }
            if(rdoName.Checked)
            {
                rows = tblemp.Select("empnam like'*"+strText+"*'");
            }
            else if(rdoNumber.Checked)
            {
                rows = tblemp.Select("empno = " + strText);
            }
            else if(rdoAddress.Checked)
            {
                rows = tblemp.Select("address like'*" + strText + "*'");
            }
            else if(rdoSalary.Checked)
            {
                rows = tblemp.Select("salary = " + strText);
            }
            foreach(DataRow row in rows)
            {
                tblFiltered.ImportRow(row);
            }
            dgvSearch.DataSource = tblFiltered;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rdoSalary.Checked || rdoNumber.Checked)
            {
                txtSalary_KeyPress(sender, e);
            }
        }

        private void rdoNumber_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void dgvSearch_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblResult.Text = "نتيجه البحث : "+dgvSearch.Rows.Count + " صف";
        }

        private void dgvSearch_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblResult.Text = "نتيجه البحث : " + dgvSearch.Rows.Count + " صف";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form1 frmReport = new Form1();
            frmReport.ShowDialog();
        }
    }
}

