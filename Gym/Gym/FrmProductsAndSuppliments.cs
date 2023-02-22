using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmProductsAndSuppliments : Form
    {
        public FrmProductsAndSuppliments()
        {
            InitializeComponent();
        }

        DataTable tblGetSuppluyData = new DataTable();
        private void GetSupplyData()
        {
            tblGetSuppluyData.Rows.Clear();

            DB.GetData("select * from ProductsAndSuppliments", tblGetSuppluyData);
            dgvShowSupply.DataSource = tblGetSuppluyData;
            AutoNum();
        }
        private void AutoNum()
        {
            Tools.ClearData(pnlProductsAndSuupliments);
            dtpSupplyProductDate.Value = DateTime.Now;
            dtpSupplyExpireDate.Value = DateTime.Now;
            string strAuto = "1";
            if(tblGetSuppluyData.Rows.Count < 1)
            {
                txtSupplyno.Text = strAuto;
            }
            else
            {
                int IntAuto = Convert.ToInt32(tblGetSuppluyData.Compute("max(supplyno)", "")) + 1;
                strAuto = IntAuto.ToString();
                txtSupplyno.Text = strAuto;
            }
            Enabling_Disablingbtn(false);
        }
        private bool PreventRepeat()
        {
            var r = from tblsuppName in tblGetSuppluyData.AsEnumerable()
                    where tblsuppName[1].ToString() == txtSupplyName.Text
                    select tblsuppName[1];
            foreach (var i in r)
            {
                if(i.ToString()==txtSupplyName.Text)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void FrmProductsAndSuppliments_Load(object sender, EventArgs e)
        {
            this.Activated += delegate {
                GetSupplyData();
                AutoNum();
            };
            GetSupplyData();
            AutoNum();
        }

        private void btnNewSupply_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = ">> ";
                if (Validate_Supply()) return;
                epSupply.Clear();
                if (PreventRepeat())
                {
                    FrmConfirmDel f = new FrmConfirmDel();
                    f.lblHeader.Font = new Font(this.Font.FontFamily, 12);
                    f.lblHeader.Text = "هذا المكمل أو المنتج موجود بالفعل يمكنك التعديل عليه فقط ";
                    f.btnYes.Text = "موافق";
                    f.btnYes.Left = (f.Width - f.btnYes.Width) / 2;
                    f.btnNo.Visible = false;
                    f.ShowDialog();
                    return;
                }
                DB.cmd.Parameters.Clear();
                DB.cmd.Parameters.AddWithValue("@productdate", dtpSupplyProductDate.Value);
                DB.cmd.Parameters.AddWithValue("@expiredate", dtpSupplyExpireDate.Value);
                DB.cmd.Parameters.AddWithValue("@buydate", dtpBuyDate.Value);
                DB.Run("insert into ProductsAndSuppliments values(" + txtSupplyno.Text + ",'" + txtSupplyName.Text + "',@productdate,@expiredate," + txtSupplyPrice.Text + "," + txtSupplyQty.Text + ",@buydate)");
                GetSupplyData();
                lblMsg.Text += " تم اضافه المنتج ";
                dgvShowSupply.CurrentCell = dgvShowSupply.Rows[dgvShowSupply.Rows.Count - 1].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShowSupply_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowSupply.CurrentRow != null)
                {
                    txtSupplyno.Text = dgvShowSupply.CurrentRow.Cells["colsupplyno"].Value.ToString();
                    txtSupplyName.Text = dgvShowSupply.CurrentRow.Cells["colsupplyname"].Value.ToString();
                    dtpSupplyProductDate.Value = (DateTime)dgvShowSupply.CurrentRow.Cells["colsupplyproddate"].Value;

                    dtpSupplyExpireDate.Value = (DateTime)dgvShowSupply.CurrentRow.Cells["colsupplyexpiredate"].Value;
                    txtSupplyPrice.Text = dgvShowSupply.CurrentRow.Cells["colsupplyprice"].Value.ToString();
                    txtSupplyQty.Text = dgvShowSupply.CurrentRow.Cells["colsupplyqty"].Value.ToString();
                    dtpBuyDate.Value = Convert.ToDateTime(dgvShowSupply.CurrentRow.Cells["colBuyDate"].Value);
                    Enabling_Disablingbtn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Enabling_Disablingbtn(bool b=true)
        {
            btnAddSupply.Enabled = !b;
            btnEditSupply.Enabled = b;
            btnDeleteSupply.Enabled = b;
            foreach (Control c in pnlProductsAndSuupliments.Controls)
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

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = ">> ";
                if (dgvShowSupply.CurrentRow != null)
                {
                    if (Validate_Supply()) return;
                    epSupply.Clear();

                    DB.cmd.Parameters.Clear();
                    DB.cmd.Parameters.AddWithValue("@productdate", dtpSupplyProductDate.Value);
                    DB.cmd.Parameters.AddWithValue("@expiredate", dtpSupplyExpireDate.Value);
                    DB.cmd.Parameters.AddWithValue("@buydate", dtpBuyDate.Value);
                    DB.Run("update ProductsAndSuppliments set supplyname='" + txtSupplyName.Text + "',proddate=@productdate,prodexpiredate=@expiredate,prodprice=" + txtSupplyPrice.Text + ",prodqty=" + txtSupplyQty.Text + ",buydate=@buydate where supplyno=" + dgvShowSupply.CurrentRow.Cells["colsupplyno"].Value + "");
                    GetSupplyData();
                    lblMsg.Text += "تم التعديل على المنتج بنجاح ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteSupply_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowSupply.CurrentRow != null)
                {
                    lblMsg.Text = ">> ";
                    FrmConfirmDel frm = new FrmConfirmDel();
                    frm.lblHeader.Text = "هل تريد حذف البيانات الخاصه بالمكمل او المنتج";
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DB.Run("delete ProductsAndSuppliments where supplyno=" + dgvShowSupply.CurrentRow.Cells["colsupplyno"].Value);
                        GetSupplyData();
                        lblMsg.Text += "تم حذف بيانات المنتج ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSupplyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space) e.Handled = true;
        }

        private void txtSupplyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if(txtSupplyPrice.Text.Trim().Contains("."))
            {
                if (e.KeyChar == '.') e.Handled = true;
            }
        }

        private void txtSupplyQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private bool Validate_Supply()
        {
            bool Is_Valid = false;
            if(txtSupplyno.Text.Trim()=="")
            {
                epSupply.SetError(txtSupplyno, "حدث خطأ فى كود المكمل أو المنتج الرجاء التواصل مع مصمم البرنامج");
                Is_Valid = true;
            }
            else if(txtSupplyName.Text.Trim()=="")
            {
                epSupply.SetError(txtSupplyName, "برجاء ادخال اسم المكمل او المنتج ");
                Is_Valid = true;
            }
            else if(txtSupplyPrice.Text.Trim()=="")
            {
                epSupply.SetError(txtSupplyPrice, "برجاء ادخال سعر المكمل أو المنتج ");
                Is_Valid = true;
            }
            else if(txtSupplyQty.Text.Trim()=="")
            {
                epSupply.SetError(txtSupplyQty, "برجاء ادخال كميه المكمل او المنتج المتاحه");
                Is_Valid = true;
            }

            return Is_Valid;
        }

        private void FrmProductsAndSuppliments_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tblGetSuppluyData);
            string strFiltered = "";
            if(rdoProdName.Checked)
            {
                strFiltered = "supplyname like'%" + txtSearch.Text + "%' ";
            }
            else if(rdoProdPrice.Checked)
            {
                if (txtSearch.Text.Trim() == "") strFiltered = "supplyname like'%%'";
                else
                strFiltered = "prodprice=" +txtSearch.Text;
            }
            dv.RowFilter = strFiltered;
            dgvShowSupply.DataSource = dv;
        }

        private void rdoProdName_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Clear();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdoProdName.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space) e.Handled = true;
            }
            else if(rdoProdPrice.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
            }
        }
    }
}
