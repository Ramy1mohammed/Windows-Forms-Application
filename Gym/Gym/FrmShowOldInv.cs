using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmShowOldInv : Form
    {
        public FrmShowOldInv()
        {
            InitializeComponent();
        }

        Point pt = Point.Empty;
        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = new Point(e.X, e.Y);
                pnlHead.Cursor = Cursors.Hand;
            }
        }

        private void pnlHead_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = Point.Empty;
                pnlHead.Cursor = Cursors.Default;
            }
        }

        private void pnlHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (pt != Point.Empty)
            {
                this.Location = new Point(Left + e.X - pt.X, Top + e.Y - pt.Y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) {
                WindowState = FormWindowState.Normal;
                dgvShowOldSaledSuppliments.Height -= 170;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                dgvShowOldSaledSuppliments.Height += 170;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        DataTable tblGetOldSaled = new DataTable();
        DataTable GetRelatedProdName = new DataTable();
        DataTable tblGetPriceQty = new DataTable();
        DataTable tblGetAll = new DataTable();

        private void GetOldSaled()
        {

            tblGetOldSaled.Rows.Clear();
            GetRelatedProdName.Rows.Clear();
            tblGetPriceQty.Rows.Clear();
            tblGetAll.Rows.Clear();
            DB.GetData("select * from BuySuppliments", tblGetOldSaled);
            DB.GetData("select * from GetBuySuppliment", GetRelatedProdName);
            DB.GetData("select * from SupplyBuierNamePrice_qty", tblGetPriceQty);
            if(tblGetOldSaled.Rows.Count > 0)
            {
                if (tblGetAll.Columns.Count < 1)
                {
                    tblGetAll.Columns.Add("invnum");
                    tblGetAll.Columns.Add("trname");
                    tblGetAll.Columns.Add("supplyname");
                    tblGetAll.Columns.Add("buydate", typeof(DateTime));
                    tblGetAll.Columns.Add("price");
                    tblGetAll.Columns.Add("qty");
                   // tblGetAll.Columns.Add("supplyno", typeof(int));
                }
                for(int x=0;x< tblGetOldSaled.Rows.Count;x++)
                {
                    DataRow row = tblGetAll.NewRow();
                    row[0] = tblGetOldSaled.Rows[x][0];
                    row[1] = tblGetOldSaled.Rows[x][1];

                    DataRow[] rowGetProdName = GetRelatedProdName.Select("invnum=" + tblGetOldSaled.Rows[x][0]);
                    string strGetProdName = "";
                    foreach (DataRow i in rowGetProdName)
                    {
                        strGetProdName += i[2].ToString() + Environment.NewLine;
                    }
                    row[2] = strGetProdName;
                    //Filteration on tblGetOldSaled
                    row[3] = tblGetOldSaled.Rows[x][2];
                    IEnumerable<DataRow> rowGetPrice = tblGetPriceQty.Select("invnum=" + tblGetOldSaled.Rows[x][0]);
                    string strGetPrice = "";
                    string strGetQty = "";
                    foreach (DataRow i in rowGetPrice)
                    {
                        strGetPrice += i[2] + Environment.NewLine;
                        strGetQty += i[3] + Environment.NewLine;
                    }
                    row[4] = strGetPrice;
                    row[5] = strGetQty;

                    tblGetAll.Rows.Add(row);
                }
                dgvShowOldSaledSuppliments.DataSource = tblGetAll;
            }
        }

        private void FrmShowOldInv_Load(object sender, EventArgs e)
        {
            GetOldSaled();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string strFiltered = "";
            try
            {
                DataView dv = new DataView(tblGetAll);
                if(rdoInvNum.Checked)
                {
                    strFiltered = "invnum like'%" + txtSearch.Text + "%'";
                }
                else if(rdoBuierName.Checked)
                {
                    strFiltered = "trname like'%" + txtSearch.Text + "%'";
                }
                dv.RowFilter = strFiltered;
                dgvShowOldSaledSuppliments.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdoInvNum_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Clear();
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvShowOldSaledSuppliments.CurrentRow!=null)
                {
                    DB.Run("delete from SupplyBuierNamePrice_qty where invnum=" + dgvShowOldSaledSuppliments.CurrentRow.Cells["colInvNum"].Value);
                    DB.Run("delete from SupplyBuierName where invnum="+dgvShowOldSaledSuppliments.CurrentRow.Cells["colInvNum"].Value);
                    DB.Run("delete from BuySuppliments where invnum=" + dgvShowOldSaledSuppliments.CurrentRow.Cells["colInvNum"].Value);
                    FrmConfirmDel frm = new FrmConfirmDel();
                    frm.lblHeader.Text = "تم حذف الفاتوره لهذا المشترى";
                    frm.btnYes.Left = (frm.Width - frm.btnYes.Width) / 2;
                    frm.btnYes.Text = "موافق";
                    frm.btnNo.Visible = false;
                    frm.ShowDialog();
                    GetOldSaled();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteAllOldInv_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف جميع الفواتير بالفعل";
                if(frm.ShowDialog()==DialogResult.OK)
                {
                    frm.lblHeader.Text = "هل متأكد من حذف الجميع"; 
                    if(frm.ShowDialog()==DialogResult.OK)
                    {
                        DB.Run("delete from SupplyBuierNamePrice_qty");
                        DB.Run("delete from SupplyBuierName");
                        DB.Run("delete from BuySuppliments");
                        GetOldSaled();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
