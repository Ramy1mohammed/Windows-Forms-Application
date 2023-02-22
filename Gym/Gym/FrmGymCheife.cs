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
    public partial class FrmGymCheife : Form
    {
        public FrmGymCheife()
        {
            InitializeComponent();
        }

        DataTable tblGetCheifeData = new DataTable();
        DataTable tblGetCheifePhones = new DataTable();
        DataTable tblGetAllData = new DataTable();
        private void GetCheifeData()
        {
            tblGetCheifeData.Rows.Clear();
            tblGetCheifePhones.Rows.Clear();
            tblGetAllData.Rows.Clear();

            DB.GetData("select * from GymCheife",tblGetCheifeData);
            DB.GetData("select * from CheifePhones", tblGetCheifePhones);
            if(tblGetCheifeData.Rows.Count>0)
            {
                if (tblGetAllData.Columns.Count<1)
                {
                    tblGetAllData.Columns.Add("cheifecode", typeof(int));
                    tblGetAllData.Columns.Add("cheifename");
                    tblGetAllData.Columns.Add("cheifessn");
                    tblGetAllData.Columns.Add("cheifeaddress");
                    tblGetAllData.Columns.Add("cheifebirth", typeof(DateTime));
                    tblGetAllData.Columns.Add("cheiefmail");
                }
                for(int x=0;x<tblGetCheifeData.Rows.Count;x++)
                {
                    DataRow row = tblGetAllData.NewRow();
                    row[0] = tblGetCheifeData.Rows[x][0];
                    row[1] = tblGetCheifeData.Rows[x][1];
                    row[2] = tblGetCheifeData.Rows[x][2];
                    row[3] = tblGetCheifeData.Rows[x][3];
                    row[4] = tblGetCheifeData.Rows[x][4];
                    row[5] = tblGetCheifeData.Rows[x][5];

                    DataRow[] rowPhones = tblGetCheifePhones.Select("Cheifeno=" + tblGetCheifeData.Rows[x][0]);

                    lbxCheifePhones.Items.Clear();

                    foreach (DataRow i in rowPhones)
                    {
                        lbxCheifePhones.Items.Add(i[1].ToString());
                    }
                    tblGetAllData.Rows.Add(row);
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = tblGetAllData;
                foreach (Control c in pnlGymCheife.Controls)
                {
                    if(c is TextBox || c is DateTimePicker)
                    {
                        c.DataBindings.Clear();
                    }
                }
                txtCheifeName.DataBindings.Add("Text", bs, "cheifename");
                txtCheifeSSn.DataBindings.Add("Text", bs, "cheifessn");
                txtCheifeAddress.DataBindings.Add("Text", bs, "cheifeaddress");
                dtpCheifeBirth.DataBindings.Add("Value", bs, "cheifebirth");
                txtCheifeMail.DataBindings.Add("Text", bs, "cheiefmail");
            }

        }
        private bool Validate_Cheife()
        {
            bool Is_Valid = false;
            if(txtCheifeName.Text.Trim()=="")
            {
                epCheife.SetError(txtCheifeName, "برجاء ادخال اسم رئيس مجلس الاداره");
                Is_Valid = true;
            }
            else if(txtCheifeSSn.Text.Trim()=="")
            {
                epCheife.SetError(txtCheifeSSn, "برجاء ادخال بطاقه الرقم القومى ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if(txtCheifeAddress.Text.Trim()=="")
            {
                epCheife.SetError(txtCheifeAddress, "برجاء ادخال العنوان ولو بشكل افتراضى ");
                Is_Valid = true;
            }
            else if(txtCheifeMail.Text.Trim()=="")
            {
                epCheife.SetError(txtCheifeMail, "برجاء ادخال البريد الالكترونى لاغراض ارسال التقارير");
                Is_Valid = true;
            }
            else if(lbxCheifePhones.Items.Count<1)
            {
                epCheife.SetError(lbxCheifePhones, "برجاء ادخال أرقام هواتف رئيس مجلس الاداره");
                Is_Valid = true;
            }
            if (!Regex.IsMatch(txtCheifeMail.Text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"))
            {
                epCheife.SetError(txtCheifeMail, "البريد الالكترونى خاطىء برجاء ادخال بريد الكترونى صحيح");
                Is_Valid = true;
            }

            return Is_Valid;

        }
        private void FrmGymCheife_Load(object sender, EventArgs e)
        {
            DB.cmd.CommandType = CommandType.Text;
            this.Activated += delegate {
                DB.cmd.CommandType = CommandType.Text;
                GetCheifeData();
            };
            GetCheifeData();
        }

        private void btnAddCheifePhones_Click(object sender, EventArgs e)
        {
            if(txtCheifePhones.Text.Trim()!="")
            {
                string strMatching = txtCheifePhones.Text;
                for(int x=0;x<lbxCheifePhones.Items.Count;x++)
                {
                    if (Regex.IsMatch(lbxCheifePhones.Items[x].ToString().Trim(),strMatching))
                    {
                        txtCheifePhones.Clear();
                        txtCheifePhones.Focus();
                        return;
                    }
                }
                lbxCheifePhones.Items.Add(strMatching);
                txtCheifePhones.Clear();
                txtCheifePhones.Focus();
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            Tools.ClearData(pnlGymCheife);
            dtpCheifeBirth.Value = DateTime.Now;
            lbxCheifePhones.Items.Clear();
        }

        private void btnDelSelectedlbxPhoneItem_Click(object sender, EventArgs e)
        {
            while(lbxCheifePhones.SelectedItems.Count > 0)
            {
                lbxCheifePhones.Items.Remove(lbxCheifePhones.SelectedItem);
            }
        }

        private void btnEditCheifeData_Click(object sender, EventArgs e)
        {
            lblMsg.Text = " >> ";
            try
            {
                if (Validate_Cheife()) return;
                epCheife.Clear();
                DB.cmd.Parameters.Clear();
                DB.cmd.Parameters.AddWithValue("@cheifebirth", dtpCheifeBirth.Value);
                DB.Run("update GymCheife set cheifename='"+txtCheifeName.Text+ "',cheifessn='"+txtCheifeSSn.Text+ "',cheifeaddress='"+txtCheifeAddress.Text+ "',cheifebirth=@cheifebirth,cheiefmail='"+txtCheifeMail.Text+ "' where cheifecode=1");
                DB.Run("delete from CheifePhones where Cheifeno=1");
                for(int x=0;x<lbxCheifePhones.Items.Count;x++)
                {
                    DB.Run("insert into CheifePhones values(1,'" + lbxCheifePhones.Items[x].ToString() + "')");
                }
                GetCheifeData();
                lblMsg.Text += "تم تعديل بيانات رئيس مجلس الاداره "; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmGymCheife_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
        }

        private void btnDelLastlbxPhoneItem_Click(object sender, EventArgs e)
        {
            if(lbxCheifePhones.Items.Count > 0)
            {
                lbxCheifePhones.Items.RemoveAt(lbxCheifePhones.Items.Count - 1);
            }
        }

        private void btnDelAlllbxPhone_Click(object sender, EventArgs e)
        {
            lbxCheifePhones.Items.Clear();
        }

        private void txtCheifeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space) e.Handled = true;
        }

        private void txtCheifeSSn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtCheifeAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != '-' && e.KeyChar != '/') e.Handled = true;
        }

        private void txtCheifePhones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnAddCheifePhones.PerformClick();
        }
    }
}
