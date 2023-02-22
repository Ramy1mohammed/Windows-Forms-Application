using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmEmoployeeBorrow : Form
    {
        public FrmEmoployeeBorrow()
        {
            InitializeComponent();
        }
        DataTable tblGetEmps = new DataTable();
        DataTable tblGetBorrowResponsible = new DataTable();

        DataTable tblGetborrowdata = new DataTable();
        DataTable tblGetAllData = new DataTable();
        private void GetEmployees()
        {
            tblGetEmps.Rows.Clear();
            DB.GetData("select empno,empname,salary from GymEmployee", tblGetEmps);
            cbxEmpnameBorrow.DataSource = tblGetEmps;
            cbxEmpnameBorrow.DisplayMember = tblGetEmps.Columns[1].ToString();
            cbxEmpnameBorrow.ValueMember = tblGetEmps.Columns[0].ToString();
        }
        private void GetResponsible()
        {
            tblGetBorrowResponsible.Rows.Clear();
            DB.GetData("select empno,empname from GymEmployee where jobtype='موظف شئون عاملين'", tblGetBorrowResponsible);
            cbxBorrowResponsible.DataSource = tblGetBorrowResponsible;
            cbxBorrowResponsible.DisplayMember = tblGetBorrowResponsible.Columns[1].ToString();
            cbxBorrowResponsible.ValueMember = tblGetBorrowResponsible.Columns[0].ToString();
        }

        private void GetAllData()
        {
            tblGetborrowdata.Rows.Clear();
            tblGetAllData.Rows.Clear();

            DB.GetData("select distinct getborrowdata.empno,getborrowdata.empname,getborrowdata.borrowvalue,getborrowdata.restofsalary,getborrowdata.dateofborrow,getborrowresponsible.empresponsible,getborrowresponsible.empname from getborrowdata,getborrowresponsible where getborrowdata.empresponsible=getborrowresponsible.empresponsible", tblGetborrowdata);

            if (tblGetborrowdata.Rows.Count > 0)
            {
                if (tblGetAllData.Columns.Count < 1)
                {
                    tblGetAllData.Columns.Add("empno", typeof(int));
                    tblGetAllData.Columns.Add("empname");
                    tblGetAllData.Columns.Add("borrowvalue", typeof(decimal));
                    tblGetAllData.Columns.Add("empsalary", typeof(decimal));
                    tblGetAllData.Columns.Add("restofsalary", typeof(decimal));
                    tblGetAllData.Columns.Add("dateofborrow", typeof(DateTime));
                    tblGetAllData.Columns.Add("empresponsibleno", typeof(int));
                    tblGetAllData.Columns.Add("empreponsiblename");
                }
                for (int x=0;x<tblGetborrowdata.Rows.Count;x++)
                {
                    DataRow row = tblGetAllData.NewRow();
                    row[0] = tblGetborrowdata.Rows[x][0];
                    row[1] = tblGetborrowdata.Rows[x][1];
                    row[2] = tblGetborrowdata.Rows[x][2];
                    DataRow[] rowSalary = tblGetEmps.Select("empno=" + tblGetborrowdata.Rows[x][0]);
                    string strSalary = "";
                    foreach (DataRow i in rowSalary)
                    {
                        strSalary += i[2].ToString() + Environment.NewLine;
                    }
                    row[3] = strSalary;
                    row[4] = tblGetborrowdata.Rows[x][3];
                    row[5] = tblGetborrowdata.Rows[x][4];
                    row[6] = tblGetborrowdata.Rows[x][5];
                    row[7] = tblGetborrowdata.Rows[x][6];

                    tblGetAllData.Rows.Add(row);
                }

                dgvShowBorrow.DataSource = tblGetAllData;
                dgvShowBorrow.Refresh();
            }

        }
        private void FrmEmoployeeBorrow_Load(object sender, EventArgs e)
        {
            DB.cmd.CommandType = CommandType.Text;

            if (cbxEmpnameBorrow.Items.Count > 0)
            {
                cbxEmpnameBorrow.SelectedIndex = 0;
                cbxEmpnameBorrow.SelectedItem = cbxEmpnameBorrow.Items[0];
            }
            txtBorrowValue.Focus();
            txtBorrowValue.SelectAll();

            this.Activated += delegate {
                DB.cmd.CommandType = CommandType.Text;
                GetEmployees();
                GetResponsible();
                GetAllData();
               
                if(cbxEmpnameBorrow.Items.Count > 0)
                {
                    cbxEmpnameBorrow.SelectedIndex = 0;
                    cbxEmpnameBorrow.SelectedItem = cbxEmpnameBorrow.Items[0];
                }
                txtBorrowValue.Focus();
                txtBorrowValue.SelectAll();
            };
            GetEmployees();
            GetResponsible();
            GetAllData();
           
        }

        private void btnNewBorrow_Click(object sender, EventArgs e)
        {
            
            if(cbxBorrowResponsible.Items.Count>0)
            {
                cbxBorrowResponsible.SelectedIndex = 0;
            }
            cbxBorrowResponsible.Focus();
            cbxBorrowResponsible.SelectAll();
            if(cbxEmpnameBorrow.Items.Count>0)
            {
                cbxEmpnameBorrow.SelectedIndex = 0;
            }
            txtBorrowValue.Clear();
            txtRestOfSalary.Clear();
            dtpBorrowDate.Value = DateTime.Now;
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                var r = from getEmpBorrow in tblGetAllData.AsEnumerable()
                        where getEmpBorrow[0].ToString() == cbxEmpnameBorrow.SelectedValue.ToString()
                        select getEmpBorrow[0];
                foreach (var i in r)
                {
                    if (i.ToString() == cbxEmpnameBorrow.SelectedValue.ToString())
                    {
                        FrmConfirmDel frm = new FrmConfirmDel();
                        frm.lblHeader.Text = "بيانات هذا المستلف موجود بالفعل يمكنك التعديل فقط";
                        frm.btnYes.Text = "موافق";
                        frm.btnYes.Left = (frm.Width - frm.btnYes.Width) / 2;
                        frm.btnNo.Visible = false;
                        frm.ShowDialog();
                        return;
                    }
                }



                DB.cmd.Parameters.Clear();
                DB.cmd.Parameters.AddWithValue("@dateofborrow", dtpBorrowDate.Value);

                DB.Run("insert into EmployeeBorrow values(" + cbxEmpnameBorrow.SelectedValue + ","+txtBorrowValue.Text+","+txtRestOfSalary.Text+ ",@dateofborrow,"+cbxBorrowResponsible.SelectedValue+")");
                GetAllData();
                lblMsg.Text += " تم اضافه بيانات المستلف";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditBorrow_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (dgvShowBorrow.CurrentRow != null)
                {
                    DB.cmd.Parameters.Clear();
                    DB.cmd.Parameters.AddWithValue("@dateofborrow", dtpBorrowDate.Value);
                    DB.Run("update EmployeeBorrow set borrowvalue=" + txtBorrowValue.Text + ",restofsalary=" + txtRestOfSalary.Text + ",dateofborrow=@dateofborrow,empresponsible=" + cbxBorrowResponsible.SelectedValue + " where empno=" + dgvShowBorrow.CurrentRow.Cells["colempnoborrow"].Value  );

                    GetAllData();
                    lblMsg.Text += "تم التعديل على بيانات المستلف ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShowBorrow_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvShowBorrow.CurrentRow!=null)
                {
                    cbxEmpnameBorrow.Text = dgvShowBorrow.CurrentRow.Cells["colEmpBorrowName"].Value.ToString();
                    txtBorrowValue.Text = dgvShowBorrow.CurrentRow.Cells["colRestOfBorrow"].Value.ToString();
                    txtRestOfSalary.Text = dgvShowBorrow.CurrentRow.Cells["colRestOfSalary"].Value.ToString();
                    dtpBorrowDate.Value = (DateTime)dgvShowBorrow.CurrentRow.Cells["colBorrowDate"].Value;
                    cbxBorrowResponsible.Text = dgvShowBorrow.CurrentRow.Cells["colBorrowResponsible"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteBorrow_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (dgvShowBorrow.CurrentRow != null)
                {
                    FrmConfirmDel frm = new FrmConfirmDel();
                    frm.lblHeader.Text = "هل تريد حذف بيانات هذا المستلف ";
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DB.Run("delete EmployeeBorrow where empno=" + dgvShowBorrow.CurrentRow.Cells["colempnoborrow"].Value);

                        GetAllData();
                        lblMsg.Text += "تم حذف بيانات المستلف ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(tblGetAllData);

                string strFiltered = "";
                if (rdoBorrowerName.Checked)
                {
                    strFiltered = "empname like'%" + txtSearch.Text + "%'";
                }
                else if (rdoBorrowerResponsible.Checked)
                {
                    strFiltered = "empreponsiblename like'%" + txtSearch.Text + "%'";
                }
                dv.RowFilter = strFiltered;
                dgvShowBorrow.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FrmEmoployeeBorrow_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
        }


        private void Calculate_Rest_Of_Salary()
        {
            double x = 0;
            var r = from GetRestOfSalary in tblGetEmps.AsEnumerable()
                    where GetRestOfSalary[0].ToString() == cbxEmpnameBorrow.SelectedValue.ToString()
                    select GetRestOfSalary[2];

            foreach (var i in r)
            {
                x = Convert.ToDouble(i.ToString());
            }
            if (txtBorrowValue.Text.Trim() != "")
            {
                double rest = x - Convert.ToDouble(txtBorrowValue.Text);
                txtRestOfSalary.Text = rest.ToString();
            }
        }
        private void txtBorrowValue_TextChanged(object sender, EventArgs e)
        {
            Calculate_Rest_Of_Salary();
        }

        private void cbxEmpnameBorrow_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate_Rest_Of_Salary();
        }

        private void txtBorrowValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)&&e.KeyChar!='.')
            {
                e.Handled = true;
            }
            if(txtBorrowValue.Text.Trim().Contains("."))
            {
                if (e.KeyChar == '.') e.Handled = true;
            }
        }

        private void rdoBorrowerName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Clear();
        }
        string str = "";
        private void cbxEmpnameBorrow_Validating(object sender, CancelEventArgs e)
        {
           
                str = ((ComboBox)sender).GetItemText(((ComboBox)sender).Items[0]);
            if (((ComboBox)sender).Items.Count > 0)
            {
                for (int x = 0; x < ((ComboBox)sender).Items.Count; x++)
                {
                    if (!Regex.IsMatch(((ComboBox)sender).Items[x].ToString().Trim(), ((ComboBox)sender).Text))
                    {
                        ((ComboBox)sender).Text = str;
                        break;
                    }
                }
            }
        }

        private void cbxEmpnameBorrow_Click(object sender, EventArgs e)
        {
            str = ((ComboBox)sender).Text;
        }

        private void cbxEmpnameBorrow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            str = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }

        private void cbxEmpnameBorrow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                str = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }
    }
}
