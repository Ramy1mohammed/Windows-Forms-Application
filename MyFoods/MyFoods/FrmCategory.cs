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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
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
            Vars.categories.Clear();
            this.Close();
        }
         private void GetAuto()
        {
            DataTable tbl = DB.GetData("select max(CategoryNo)+1 from category");
            txtCategoryNo.Text = tbl.Rows[0][0].ToString();
            if (txtCategoryNo.Text.Trim() == "") txtCategoryNo.Text = "1";
            btnAddCategory.Enabled = true;
            btnDelCategory.Enabled = false;
            txtCategoryName.Select();
            txtCategoryName.Focus();
        }
        DataTable tbl = new DataTable();
        private void ShowCategory()
        {
            tbl= DB.GetData("select * from category");
            dgvCategory.DataSource = tbl;
        }
        private void ClearAndShow()
        {
            txtCategoryName.Text = "";
            ShowCategory();
            GetAuto();
        }       
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            ClearAndShow();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            GetAuto();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCategoryName.Text.Trim()!="")
                {
                    DB.Run("insert into category values(" + txtCategoryNo.Text + ",'" + txtCategoryName.Text + "')");
                    ClearAndShow();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ">> " + "حدث خطأ , " + ex.Message;
            }
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            dgvCategory.CurrentRow.Selected = false;
            if(dgvCategory.CurrentRow!=null)
            {
                txtCategoryNo.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                txtCategoryName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();

                btnAddCategory.Enabled = false;
                if (lbxAdded.Items.Count == 0)
                    btnDelCategory.Enabled = true;
                else
                    btnDelCategory.Enabled = false;
            }
        }

        private void btnAddCategory_EnabledChanged(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = (((Button)sender).Enabled) ? Color.Pink : Color.LightGray;
        }

        List<Tuple<int, string>> data = new List<Tuple<int, string>>();

        private void SetItems()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Distinct();
            lbxAdded.DataSource = bs;
            lbxAdded.ValueMember = "Item1";
            lbxAdded.DisplayMember = "Item2";
        }
        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            if(dgvCategory.CurrentRow!=null)
            {
                data.Add(new Tuple<int, string>((int)dgvCategory.CurrentRow.Cells[0].Value, dgvCategory.CurrentRow.Cells[1].Value.ToString()));                               
            }
            SetItems();
            btnDelCategory.Enabled = false;
        }

        private void btnAddAl_Click(object sender, EventArgs e)
        {
            data.Clear();
            foreach(DataGridViewRow r in dgvCategory.Rows)
            {
                data.Add( new Tuple<int, string>( (int)r.Cells[0].Value, r.Cells[1].Value.ToString() ) );
            }
            SetItems();
            btnDelCategory.Enabled = false;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            data.Clear();
            lbxAdded.DataSource = data;
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoryNo.Text.Trim() == "") txtCategoryNo.Text = "0";
                DB.Run("delete from category where CategoryNo=" + txtCategoryNo.Text);
                ClearAndShow();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ">> " + "حدث خطأ , " + ex.Message;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tbl);
            dv.RowFilter = "CategoryName like'%" + txtSearch.Text + "%'";
            dgvCategory.DataSource = dv;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lbxAdded.Items.Count < 1)
            {
                lblMessage.Text = ">> لم يتم اختيار تصنيفات";
                return;
            }
            Vars.categories.Clear();
            
            for(int x=0;x<lbxAdded.Items.Count;x++)
            {
                lbxAdded.SelectedIndex = x;
                Vars.categories.Add(new Tuple<int, string>((int)lbxAdded.SelectedValue, lbxAdded.GetItemText(lbxAdded.SelectedItem)));
            }
            this.Close();
        }
    }
}
