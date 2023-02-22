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
using System.Xml.Schema;

namespace Gym
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }
        DataTable tbldept = new DataTable();
        DataTable tbldeptMgr = new DataTable();
        private void ShowData()
        {
            tbldept.Rows.Clear();
            tbldeptMgr.Rows.Clear();
            DB.cmd.CommandType = CommandType.Text;
            DB.GetData("select * from Department", tbldept);
            DB.GetData("select empno,empname from Gymemployee where jobtype ='مشرف قسم'", tbldeptMgr);
            cbxDeptMgr.DataSource = tbldeptMgr;
            cbxDeptMgr.DisplayMember = tbldeptMgr.Columns[1].ToString();
            cbxDeptMgr.ValueMember = tbldeptMgr.Columns[0].ToString();

            dgvShowDept.DataSource = tbldept;

        }
        private bool Validate_Dept()
        {
            bool Is_Valid = false;
            if(txtDeptCode.Text.Trim()=="")
            {
                epDept.SetError(txtDeptCode, " خطأ فى كود القسم اذا استمرت المشكله رجاء تواصل مع مصمم البرنامج");
                Is_Valid = true;
            }
            else if(txtDeptName.Text.Trim()=="")
            {
                epDept.SetError(txtDeptName, "يرجى ادخال اسم القسم");
                Is_Valid = true;
            }
             if(cbxDeptMgr.Items.Count < 1)
            {
                epDept.SetError(cbxDeptMgr, "رجاء توجه لقسم اداره الموظفين وقم باضافه موظف على الأقل بتخصص مشرف قسم");
                Is_Valid = true;
            }
           else if(cbxDeptMgr.Text.Trim()=="")
            {
                epDept.SetError(cbxDeptMgr," رجاء قم باختيار مدير القسم");
                Is_Valid = true;
            }
            return Is_Valid;
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                this.Activated += delegate
                {
                    ShowData();
                    AutoNum();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AutoNum()
        {
            Tools.ClearData(pnlDeptControls);
            //cbxDeptMgr.Text = "";
            if (cbxDeptMgr.Items.Count > 0)
                cbxDeptMgr.SelectedIndex = 0;
            else cbxDeptMgr.Text = "";
            epDept.Clear();

            string strAuto = "1";
            if (tbldept.Rows.Count > 0)
            {
                int IntAuto = Convert.ToInt32(tbldept.Compute("max(deptno)", "")) + 1;
                strAuto = IntAuto.ToString();
                txtDeptCode.Text = strAuto;
            }
            else
            { txtDeptCode.Text = strAuto; }
            txtDeptName.Focus();
            txtDeptName.Select();
            EnablingBtn(false);
        }
        private void btnNewDept_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (Validate_Dept()) return;
                epDept.Clear();
                DB.Run("insert into Department values(" + txtDeptCode.Text + ",'" + txtDeptName.Text + "','" + cbxDeptMgr.Text + "')");
                ShowData();
                dgvShowDept.CurrentCell = dgvShowDept.Rows[dgvShowDept.Rows.Count - 1].Cells[0];
                AutoNum();
                lblMsg.Text += "تم اضافه القسم ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditDept_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (Validate_Dept()) return;
                DB.Run("update Department set deptname='" + txtDeptName.Text + "', deptmanager='" + cbxDeptMgr.Text + "' where deptno=" + txtDeptCode.Text);
                ShowData();
                lblMsg.Text += " تم تعديل بيانات القسم";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShowDept_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShowDept.CurrentRow != null)
            {
                txtDeptCode.Text = dgvShowDept.CurrentRow.Cells[0].Value.ToString();
                txtDeptName.Text = dgvShowDept.CurrentRow.Cells[1].Value.ToString();
                cbxDeptMgr.Text = dgvShowDept.CurrentRow.Cells[2].Value.ToString();
                EnablingBtn();
            }
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">>";
            try
            {
                FrmConfirmDel f = new FrmConfirmDel();
                f.lblHeader.Text = "هل تريد حذف القسم ";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DB.Run("delete from Department where deptno=" + txtDeptCode.Text);
                    ShowData();
                    lblMsg.Text += "تم حذف القسم ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AutoNum();
        }

        private void cbxDeptMgr_Validating(object sender, CancelEventArgs e)
        {
            for (int x = 0; x < cbxDeptMgr.Items.Count; x++)
            {
                if (Regex.IsMatch(cbxDeptMgr.Items[x].ToString(), cbxDeptMgr.Text))
                {
                    return;
                }
            }
            cbxDeptMgr.Text = "";
            FrmConfirmDel frm = new FrmConfirmDel();
            frm.lblHeader.Text = "برجاء الاختيار من القائمه فقط";
            frm.btnYes.Text = "موافق";
            frm.btnYes.Left = (frm.Width - frm.btnYes.Width) / 2;
            frm.btnNo.Visible = false;
            frm.ShowDialog();

        }
        private void EnablingBtn(bool b = true)
        {
            btnAddDept.Enabled = !b;
            btnEditDept.Enabled = b;
            btnDeleteDept.Enabled = b;
            foreach (Control c in pnlDeptControls.Controls)
            {
                if (c is SansationRoundButton)
                {
                    if (c.Enabled)
                        c.BackColor = Color.Pink;
                    else
                        c.BackColor = Color.LightGray;
                }
            }
        }
        private void cbxDeptMgr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmDepartment_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
        }
    }
}
