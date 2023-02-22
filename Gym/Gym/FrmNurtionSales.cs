using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmNurtionSales : Form
    {
        public FrmNurtionSales()
        {
            InitializeComponent();
        }

        DataTable tblGetProducts = new DataTable();
        private void GetMaxInvNo()
        {
            Tools.ClearData(pnlNurtionSales);

            using (
            SqlCommand cmd = new SqlCommand("Select invnum from BuySuppliments", DB.conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                int[] GetRow = new int[1];
                int InGetMax = 0;
                int x = 0;
                while (reader.Read())
                {
                    GetRow[x] = Convert.ToInt32(reader[0]);
                    Array.Resize(ref GetRow, GetRow.Length + 1);
                    x++;
                }
                InGetMax = Convert.ToInt32(GetRow.Max()) + 1;
                string StrGetMax = string.Format("{0:d9}", InGetMax);

                txtInvNum.Invoke((MethodInvoker)delegate { txtInvNum.Text = StrGetMax; });
                if(cbxSaledProd.Items.Count>0)
                {
                    cbxSaledProd.SelectedIndex = 0;
                }
                else
                {
                    cbxSaledProd.Text = "";
                }
                dtpSaleDate.Value = DateTime.Now;
            }
        }
        private void GetProducts()
        { 
            tblGetProducts.Rows.Clear();
            DB.GetData("select supplyno,supplyname from ProductsAndSuppliments", tblGetProducts);
            cbxSaledProd.DataSource = tblGetProducts;

                cbxSaledProd.DisplayMember = tblGetProducts.Columns[1].ToString();
            cbxSaledProd.ValueMember = tblGetProducts.Columns[0].ToString();
        }
        
        private void FrmNurtionSales_Load(object sender, EventArgs e)
        {
            GetProducts();
            GetMaxInvNo();
           
            this.Activated += delegate {
                GetProducts();
            };
        }
        private void btnAddNewSaledProd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < dgvShowSaledProd.Rows.Count; x++)
                {
                    if (Regex.IsMatch(dgvShowSaledProd.Rows[x].Cells["colProdNo"].Value.ToString(), cbxSaledProd.SelectedValue.ToString()))
                    {
                        FrmConfirmDel frm = new FrmConfirmDel();
                        frm.lblHeader.Text = "هذا الصنف مضاف بالفعل قم باضافه صنف اخر";
                        frm.btnYes.Text = "موافق";
                        frm.btnYes.Left = (frm.Width - frm.btnYes.Width) / 2;
                        frm.btnNo.Visible = false;
                        frm.ShowDialog();
                        return;
                    }
                }

                int IntQty = Convert.ToInt32(txtSaledQty.Text);
                    double doublePrice = Convert.ToDouble(txtSaledProdPrice.Text);
                    double SubProice = IntQty * doublePrice;
                    object[] InvInfo = new object[] { txtInvNum.Text,cbxSaledProd.Text, txtSaledQty.Text, txtSaledProdPrice.Text, SubProice, cbxSaledProd.SelectedValue };
                    dgvShowSaledProd.Rows.Add(InvInfo);
              
                DB.cmd.Parameters.Clear();
                DB.cmd.Parameters.AddWithValue("@BuingDate", dtpSaleDate.Value);
                using (
           SqlCommand cmd = new SqlCommand("Select invnum from BuySuppliments", DB.conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == txtInvNum.Text)
                        {
                            reader.Close();
                            DB.Run("insert into SupplyBuierName values('" + txtInvNum.Text + "'," + cbxSaledProd.SelectedValue + ")");
                            DB.Run("insert into SupplyBuierNamePrice_qty values('" + txtInvNum.Text + "'," + cbxSaledProd.SelectedValue + "," + txtSaledProdPrice.Text + "," + txtSaledQty.Text + ")");
                            return;
                        }
                    }
                }

                    DB.Run("insert into BuySuppliments values('" + txtInvNum.Text + "','"+txtBuyerName.Text+ "',@BuingDate)");
                DB.Run("insert into SupplyBuierName values('" + txtInvNum.Text + "',"+cbxSaledProd.SelectedValue+")");
                DB.Run("insert into SupplyBuierNamePrice_qty values('" + txtInvNum.Text + "'," + cbxSaledProd.SelectedValue + "," + txtSaledProdPrice.Text + "," + txtSaledQty.Text + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowOldInv_Click(object sender, EventArgs e)
        {
            FrmShowOldInv frm = new FrmShowOldInv();
            frm.ShowDialog();
        }

        private void Test()
        {
            double dblSum = 0;
            for(int x=0;x<dgvShowSaledProd.Rows.Count;x++)
            {
                dblSum += Convert.ToDouble(dgvShowSaledProd.Rows[x].Cells["colSubTotalProd"].Value);
            }
            txtTotal.Invoke((MethodInvoker)delegate { txtTotal.Text = dblSum.ToString(); }); 

        }
        private void dgvShowSaledProd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Task.Run(Test);
        }

        int m = -1;
        private void btnPrintInv_Click(object sender, EventArgs e)
        {
            m = -1;
            ((Form)ppDialog).WindowState = FormWindowState.Maximized;
            if(ppDialog.ShowDialog()==DialogResult.OK)
            {
                pDoc.Print();
            }
        }

        private void pDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            m++;
            float margin = 40;
            Font f = new Font("Arial", 18, FontStyle.Bold);

            string strInvNum ="NO# "+ txtInvNum.Text;
            string strbuyingDate ="التاريخ: "+dtpSaleDate.Value.ToString();
            string strCustName = "مطلوب من السيد: " + txtBuyerName.Text;

            SizeF GetInvNumMeasure = e.Graphics.MeasureString(strInvNum, f);
            SizeF GetBuyingDateMesaure = e.Graphics.MeasureString(strbuyingDate, f);
            SizeF GetCustNameMesaure = e.Graphics.MeasureString(strCustName, f);

            e.Graphics.DrawString(strInvNum, f, Brushes.Red, ((e.PageBounds.Width - GetInvNumMeasure.Width) / 2), margin);
            e.Graphics.DrawString(strbuyingDate, f, Brushes.Black, e.PageBounds.Width - GetBuyingDateMesaure.Width - margin, margin + GetInvNumMeasure.Height);
            e.Graphics.DrawString(strCustName, f, Brushes.Black, e.PageBounds.Width - GetCustNameMesaure.Width - margin, margin + GetInvNumMeasure.Height + GetBuyingDateMesaure.Height);
            e.Graphics.DrawImage(Properties.Resources._1591187049492, 5, 5, 200, 200);

            float preHeights = margin + GetInvNumMeasure.Height + GetBuyingDateMesaure.Height + GetCustNameMesaure.Height + 70;

            e.Graphics.DrawRectangle(Pens.Black, margin / 2, preHeights, e.PageBounds.Width - margin, e.PageBounds.Height - preHeights - margin / 2);

            float colHeight = 50;

            float col1width = 300;
            float col2width = 125 + col1width;
            float col3width = 125 + col2width;
            float col4width = 250 + col3width;

            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin / 2, preHeights + colHeight, margin / 2, preHeights + colHeight);

            e.Graphics.DrawString("الصنف", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col1width + 120, preHeights + colHeight - 40);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - (margin / 2) - col1width, preHeights, e.PageBounds.Width - (margin / 2) - col1width, e.PageBounds.Height - (margin) / 2);

            e.Graphics.DrawString("الكميه", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col2width + 40, preHeights + colHeight - 40);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - (margin / 2) - col2width, preHeights, e.PageBounds.Width - (margin / 2) - col2width, e.PageBounds.Height - (margin) / 2);

            e.Graphics.DrawString("سعر الوحده", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col3width + 15, preHeights + colHeight - 40);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - (margin / 2) - col3width, preHeights, e.PageBounds.Width - (margin / 2) - col3width, e.PageBounds.Height - (margin / 2));

            e.Graphics.DrawString("الاجمالى الفرعى", f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col3width - 200, preHeights + colHeight - 40);

            float rowHeight = 50;

            for (; m < dgvShowSaledProd.Rows.Count; m++)
            {
                e.Graphics.DrawString(dgvShowSaledProd.Rows[m].Cells[0].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - (margin / 2) - col1width, preHeights + rowHeight + colHeight - 30);
                e.Graphics.DrawString(dgvShowSaledProd.Rows[m].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col2width, preHeights + colHeight + rowHeight - 30);
                e.Graphics.DrawString(dgvShowSaledProd.Rows[m].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col3width, preHeights + colHeight + rowHeight - 30);
                e.Graphics.DrawString(dgvShowSaledProd.Rows[m].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col4width, preHeights + colHeight + rowHeight - 30);

                e.Graphics.DrawLine(Pens.Black, margin / 2, preHeights + colHeight + rowHeight, e.PageBounds.Width - (margin / 2), preHeights + colHeight + rowHeight);

                rowHeight += 50;

                if (rowHeight == e.PageBounds.Height - 300)
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            if (rowHeight < e.PageBounds.Height - 300)
            {
                e.Graphics.DrawString("الاجمالى", f, Brushes.Red, e.PageBounds.Width - (margin / 2) - col3width, preHeights + colHeight + rowHeight - 30);
                e.Graphics.DrawString(txtTotal.Text, f, Brushes.Black, e.PageBounds.Width - (margin / 2) - col4width, preHeights + colHeight + rowHeight - 30);
            }

        }

        private void dgvShowSaledProd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                if (dgvShowSaledProd.Rows.Count < 1)
                    txtTotal.Text = "0";
                if (dgvShowSaledProd.Rows.Count >= 1 && dgvShowSaledProd.CurrentRow!=null)
                {
                    double itotal = 0;
                    foreach (DataGridViewRow r in dgvShowSaledProd.Rows)
                    {
                        itotal += (double)r.Cells[3].Value;
                    }
                    txtTotal.Text = itotal.ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void dgvShowSaledProd_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowSaledProd.CurrentRow != null)
                {
                    txtInvNum.Text = dgvShowSaledProd.CurrentRow.Cells["colInvNum"].Value.ToString();
                    cbxSaledProd.Text = dgvShowSaledProd.CurrentRow.Cells["colsaledProd"].Value.ToString();
                    txtSaledQty.Text = dgvShowSaledProd.CurrentRow.Cells["colSaledProdQty"].Value.ToString();
                    txtSaledProdPrice.Text = dgvShowSaledProd.CurrentRow.Cells["colSaledProdPrice"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditProds_Click(object sender, EventArgs e)
        {

        }

        private void dgvShowSaledProd_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (dgvShowSaledProd.CurrentRow != null)
                {
                    if (dgvShowSaledProd.Rows.Count > 1)
                    {
                        DB.Run("delete from SupplyBuierNamePrice_qty where supplyno=" + e.Row.Cells["colProdNo"].Value);
                        DB.Run("delete from SupplyBuierName where supplyno=" + e.Row.Cells["colProdNo"].Value);
                    }

                    else if (dgvShowSaledProd.Rows.Count == 1)
                    {
                        DB.Run("delete from SupplyBuierNamePrice_qty where invnum=" + dgvShowSaledProd.CurrentRow.Cells["colInvNum"].Value);
                        DB.Run("delete from SupplyBuierName where invnum=" + dgvShowSaledProd.CurrentRow.Cells["colInvNum"].Value);
                        DB.Run("delete from BuySuppliments where invnum=" + dgvShowSaledProd.CurrentRow.Cells["colInvNum"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtSaledProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
           if(txtSaledProdPrice.Text.Contains("."))
            {
                if (e.KeyChar == '.') e.Handled = true;
            }
        }

        private void txtSaledQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&!char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
