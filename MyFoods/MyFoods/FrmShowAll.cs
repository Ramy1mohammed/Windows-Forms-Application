using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFoods
{
    public partial class FrmShowAll : Form
    {
        public FrmShowAll()
        {
            InitializeComponent();
        }

        Point pt = Point.Empty;
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = new Point(e.X, e.Y);
                pnlHeader.Cursor = Cursors.Hand;
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = Point.Empty;
                pnlHeader.Cursor = Cursors.Default;
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (pt != Point.Empty)
            {
                this.Location = new Point(Left + e.X - pt.X, Top + e.Y - pt.Y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowCount()
        {
            lblCount.Text = "معروض " + dgvFood.Rows.Count + " أكله";
        }
        private void FrmShowAll_Load(object sender, EventArgs e)
        {
            dgvFood.DataSource = Vars.tblAll;
            ShowCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string strPatt = "";
            if (rdoName.Checked) strPatt += "FoodName";
            else if (rdoCategory.Checked) strPatt += "Category";
            else if (rdoComponents.Checked) strPatt += "Components";
            else if (rdoDesc.Checked) strPatt += "Desc";

            strPatt += " like'%" + txtSearch.Text + "%'";
            DataView dv = new DataView(Vars.tblAll);
            dv.RowFilter = strPatt;
            dgvFood.DataSource = dv;
            ShowCount();
        }

        private void btnBigOrSmal_Click(object sender, EventArgs e)
        {
            if(btnBigOrSmal.Text== "تكبير الشاشه")
            {
                this.WindowState = FormWindowState.Maximized;
                btnBigOrSmal.Text = "تصغير الشاشه";
                dgvFood.Height = this.Height - (pnlHeader.Height + txtSearch.Height + 30);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnBigOrSmal.Text = "تكبير الشاشه";
                dgvFood.Height = 475;
            }
        }
    }
}
