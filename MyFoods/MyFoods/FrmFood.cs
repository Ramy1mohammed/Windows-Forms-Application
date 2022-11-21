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
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

namespace MyFoods
{
    public partial class FrmFood : Form
    {
        public FrmFood()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point pt = Point.Empty;
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                pt = new Point(e.X, e.Y);
                pnlHeader.Cursor = Cursors.Hand;
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                pt = Point.Empty;
                pnlHeader.Cursor = Cursors.Default;
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(pt!=Point.Empty)
            {
                this.Location = new Point(Left + e.X - pt.X, Top + e.Y - pt.Y);
            }
        }
        private void AutoNum()
        {
            txtFoodCode.Text = DB.GetData("select max(FoodCode)+1 from food").Rows[0][0].ToString();
            if (txtFoodCode.Text.Trim() == "") txtFoodCode.Text = "1";
            txtFoodName.Text = "";
            txtFoodName.Text = "";
            picFood.Image = new PictureBox().Image;
            txtImgPath.Text = "";
            txtCatigories.Text = "";
            txtComponent.Text = "";
            lbxComponents.Items.Clear();
            txtDesc.Text = "";
            txtFoodName.Select();

            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        DataTable tblAll = new DataTable();
        private void ShowData()
        {
            tblAll.Rows.Clear();

            DataTable tblData = DB.GetData("select * from food_data");
            DataTable tblCat = DB.GetData("select * from food_cat");
            DataTable foodCom = DB.GetData("select * from foodcomponent");

            if(tblAll.Columns.Count < 1)
            {
                tblAll.Columns.Add("FoodName");
                tblAll.Columns.Add("FoodImage", typeof(byte[]));
                tblAll.Columns.Add("Category");
                tblAll.Columns.Add("Components");
                tblAll.Columns.Add("Desc");
                tblAll.Columns.Add("FoodCode");
            }
            for(int x=0;x<tblData.Rows.Count;x++)
            {
                DataRow row = tblAll.NewRow();
                row[0] = tblData.Rows[x][1];
                row[1] = tblData.Rows[x][2];

                DataRow[] cat = tblCat.Select("FoodCode=" + tblData.Rows[x][0]);
                string strCat = "";
                foreach (var i in cat)
                {
                    strCat += i[1] + Environment.NewLine;
                }
                row[2] = strCat;

                string strCom = "";
                DataRow[] com = foodCom.Select("FoodCode=" + tblData.Rows[x][0]);
                foreach (var i in com)
                {
                    strCom += i[1] + Environment.NewLine;
                }

                row[3] = strCom;

                row[4] = tblData.Rows[x][3];
                row[5] = tblData.Rows[x][0];

                tblAll.Rows.Add(row);
            }

            dgvFood.DataSource = tblAll;
            ShowCount();

        }
        private void ShowCount()
        {
            lblCount.Text="معروض " + dgvFood.Rows.Count + " أكله";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            picIcon.Image=Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName).ToBitmap();
            DB.Open();
            ShowData();
            AutoNum();
        }

        private void btnAddImag_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Filter = "Images Files |*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(ofd.FileName))
                    {
                        txtImgPath.Text = ofd.FileName;
                        Bitmap bmp = new Bitmap(Image.FromFile(txtImgPath.Text), new Size(150, 150));
                        picFood.Image = bmp;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ">> " + "حدث خطأ , " + ex.Message;
            }
        }

        private void btnAddCatigories_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Icon = this.Icon;
            frm.ShowDialog();
            txtCatigories.Text = "";
            foreach (var item in Vars.categories)
            {
                txtCatigories.Text += " " + item.Item2 + " , ";
            }
        }

        private void FrmFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            if(txtComponent.Text.Trim()!="")
            {
                lbxComponents.Items.Add(txtComponent.Text);
            }

            string[] strItems = new string[lbxComponents.Items.Count];
            lbxComponents.Items.CopyTo(strItems, 0);
            string[] strFilteredItems = strItems.Distinct().ToArray();

            lbxComponents.Items.Clear();
            lbxComponents.Items.AddRange(strFilteredItems);
            txtComponent.Clear();
        }

        private void txtComponent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                btnAddComponent.PerformClick();
            }
        }

        private void btnDelSelected_Click(object sender, EventArgs e)
        {
            while(lbxComponents.SelectedItems.Count > 0)
            {
                lbxComponents.Items.Remove(lbxComponents.SelectedItems[0]);
            }
        }

        private void btnDelLast_Click(object sender, EventArgs e)
        {
            if(lbxComponents.Items.Count > 0)
            {
                lbxComponents.Items.RemoveAt(lbxComponents.Items.Count - 1);
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lbxComponents.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            if(txtFoodCode.Text.Trim()=="")
            {
                lblMessage.Text = ">> " + " حدث مشكله بالكود المخفى , رجاء اتصل بمصمم البرنامج لمعالجه المشكله";
            }
            else if(txtFoodName.Text.Trim()=="")
            {
                lblMessage.Text = ">> " + "الاســم فارغ";
                txtFoodName.Select();
            }
            else if (txtImgPath.Text.Trim() == "")
            {
                lblMessage.Text = ">> " + "رجاء قم باختيار صوره للطعام";
            }
            else if(txtCatigories.Text.Trim()=="")
            {
                lblMessage.Text = ">> " + " لابد من اضافه تصنيف واحد على الأقل";
                txtCatigories.Select();
            }
            else if(lbxComponents.Items.Count == 0)
            {
                lblMessage.Text = ">> " + " لا يوجد مقادير";
                txtComponent.Select();
            }
            else if(txtDesc.Text.Trim()=="")
            {
                lblMessage.Text = ">> " + " طريقه التحضير فارغه";
                txtDesc.Select();
            }
            else
            {
                lblMessage.Text = ">> ";
                try
                {
                    DB.Run("insert into food values(" + txtFoodCode.Text + ",'" + txtFoodName.Text + "','" + txtDesc.Text + "')");
                    lblMessage.Text += " تم اضافه الطعام";

                    MemoryStream ms = new MemoryStream();
                    picFood.Image.Save(ms,ImageFormat.Jpeg);
                    DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());
                    DB.Run("insert into foodimage values(" + txtFoodCode.Text + ",@img)");
                    lblMessage.Text += " , " + " تم اضافه الصوره";

                    foreach (var i in Vars.categories)
                    {
                        DB.Run("insert into foodcategory values(" + txtFoodCode.Text + "," + i.Item1 + ")");
                    }
                    lblMessage.Text += " ," + " تم اضافه التصنيفات";

                    foreach (var i in lbxComponents.Items)
                    {
                        DB.Run("insert into foodcomponent values(" + txtFoodCode.Text + ",'" + i + "')");
                    }
                    lblMessage.Text += " , " + " تم اضافه المقادير";
                   
                    ShowData();
                    AutoNum();
                }
                catch (Exception ex)
                {
                    lblMessage.Text += " ,خطأ: " + ex.Message;
                }
            }
        }

        private void txtCatigories_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyData ==Keys.Enter)
            {
                btnAddCatigories.PerformClick();
            }
        }

        private void txtCatigories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnCreateView_Click(object sender, EventArgs e)
        {
            //DB.Run("create view food_cat as select FoodCode,CategoryName,category.CategoryNo from category,foodcategory where category.CategoryNo=foodcategory.CategoryNo");
           // DB.Run("create view food_data as select food.FoodCode,FoodName,FoodImage,FoodDesc from food,foodimage where food.FoodCode=foodimage.FoodCode");
        }

        private void btnAdd_EnabledChanged(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = (((Button)sender).Enabled) ? Color.Pink : Color.LightGray;
        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvFood.CurrentRow!=null)
            {
                txtFoodCode.Text = dgvFood.CurrentRow.Cells[5].Value.ToString();
                txtFoodName.Text = dgvFood.CurrentRow.Cells[0].Value.ToString();
                txtImgPath.Text = "";
                MemoryStream ms = new MemoryStream( (byte[])dgvFood.CurrentRow.Cells[1].Value);
                picFood.Image = Image.FromStream(ms);

                DataTable tblcat = DB.GetData("select * from food_cat where FoodCode=" + txtFoodCode.Text);
                Vars.categories.Clear();
                foreach (DataRow row in tblcat.Rows)
                {
                    Vars.categories.Add(new Tuple<int, string>((int)row[2], row[1].ToString()));
                }
                txtCatigories.Text = "";
                foreach  (var i in Vars.categories)
                {
                    txtCatigories.Text += i.Item2 + " , ";
                }
                
                DataTable tblcom = DB.GetData("select * from foodcomponent where FoodCode=" + txtFoodCode.Text);
                lbxComponents.Items.Clear();
                foreach (DataRow row in tblcom.Rows)
                {
                    lbxComponents.Items.Add(row[1]);
                }
                txtDesc.Text = dgvFood.CurrentRow.Cells[4].Value.ToString();
            }
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            if (txtFoodCode.Text.Trim() == "")
            {
                lblMessage.Text = ">> " + " حدث مشكله بالكود المخفى , رجاء اتصل بمصمم البرنامج لمعالجه المشكله";
            }
            else if (txtFoodName.Text.Trim() == "")
            {
                lblMessage.Text = ">> " + "الاســم فارغ";
                txtFoodName.Select();
            }
            else if (txtCatigories.Text.Trim() == "")
            {
                lblMessage.Text = ">> " + " لابد من اضافه تصنيف واحد على الأقل";
                txtCatigories.Select();
            }
            else if (lbxComponents.Items.Count == 0)
            {
                lblMessage.Text = ">> " + " لا يوجد مقادير";
                txtComponent.Select();
            }
            else if (txtDesc.Text.Trim() == "")
            {
                lblMessage.Text = ">> " + " طريقه التحضير فارغه";
                txtDesc.Select();
            }
            else
            {
                lblMessage.Text = ">> ";
                try
                {
                    DB.Run("update food set FoodName='" + txtFoodName.Text + "',FoodDesc='" + txtDesc.Text + "' where FoodCode="+txtFoodCode.Text);
                    lblMessage.Text += " تم تعديل الطعام";

                    if(txtImgPath.Text.Trim()!="")
                    {
                        DB.Run("delete from foodimage where FoodCode=" + txtFoodCode.Text);

                        MemoryStream ms = new MemoryStream();
                        picFood.Image.Save(ms, ImageFormat.Jpeg);
                        DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());
                        DB.Run("insert into foodimage values(" + txtFoodCode.Text + ",@img)");
                        lblMessage.Text += " , " + " تم تعديل الصوره";
                    }

                    DB.Run("delete from foodcategory where FoodCode=" + txtFoodCode.Text);
                    foreach (var i in Vars.categories)
                    {
                        DB.Run("insert into foodcategory values(" + txtFoodCode.Text + "," + i.Item1 + ")");
                    }
                    lblMessage.Text += " ," + " تم تعديل التصنيفات";

                    DB.Run("delete from foodcomponent where FoodCode=" + txtFoodCode.Text);
                    foreach (var i in lbxComponents.Items)
                    {
                        DB.Run("insert into foodcomponent values(" + txtFoodCode.Text + ",'" + i + "')");
                    }
                    lblMessage.Text += " , " + " تم تعديل المقادير";
                    ShowData();
                    AutoNum();
                }
                catch (Exception ex)
                {
                    lblMessage.Text += " ,خطأ: " + ex.Message;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblMessage.Text = ">> ";
            try
            {
                if (new FrmConfirmDel().ShowDialog() == DialogResult.OK)
                {
                    DB.Run("delete from foodimage where FoodCode=" + txtFoodCode.Text);
                    lblMessage.Text += " , " + "تم حذف الصوره ";

                    DB.Run("delete from foodcategory where FoodCode=" + txtFoodCode.Text);
                    lblMessage.Text += " , " + "تم حذف التصنيفات";

                    DB.Run("delete from foodcomponent where FoodCode=" + txtFoodCode.Text);
                    lblMessage.Text += " , " + "تم حذف المقادير";

                    DB.Run("delete from food where FoodCode=" + txtFoodCode.Text);
                    lblMessage.Text += " , " + "تم حذف الأكله";
                    ShowData();
                    AutoNum();
                }

            }
            catch(Exception ex)
            {
                lblMessage.Text += " , خطأ" + ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmConfirmDel().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();
            frm.Icon = this.Icon;
            ReportDataSource rds = new ReportDataSource("DataSet1", tblAll);

            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rds);
            frm.reportViewer1.LocalReport.Refresh();
            frm.ShowDialog();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string strPatt = "";
            if (rdoName.Checked) strPatt += "FoodName";
            else if (rdoCategory.Checked) strPatt += "Category";
            else if (rdoComponents.Checked) strPatt += "Components";
            else if (rdoDesc.Checked) strPatt += "Desc";

            strPatt += " like'%" + txtSearch.Text + "%'";
            DataView dv = new DataView(tblAll);
            dv.RowFilter = strPatt;
            dgvFood.DataSource = dv;
            ShowCount();
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            if(txtCatSuggest.Text.Trim()!="")
            {
                string strFilter = "";
                for(int x=0;x<Vars.categories.Count;x++)
                {
                    strFilter += " Category like'%" + Vars.categories[x].Item2 + "%'";
                    if (x < Vars.categories.Count - 1) strFilter += " or ";
                }
                DataRow[] rows = tblAll.Select(strFilter);
                if(rows.Count() > 0)
                {
                    tblAll = rows.CopyToDataTable();
                    dgvFood.DataSource = tblAll;
                }
                else
                { 
                    lblMessage.Text = ">> " + " لايوجد أكلات حسب التصنيف";
                    return;
                }
            }
           if(tblAll.Rows.Count > 0)
            {
                lblMessage.Text = ">> ";
                Random rnd = new Random();
                int indexRandomFood = rnd.Next(0, tblAll.Rows.Count);
                FrmDetails frm = new FrmDetails();
                frm.txtFoodName.Text = tblAll.Rows[indexRandomFood][0].ToString();
                frm.txtCategories.Text = tblAll.Rows[indexRandomFood][2].ToString();
                frm.txtComponents.Text = tblAll.Rows[indexRandomFood][3].ToString();
                frm.txtDesc.Text = tblAll.Rows[indexRandomFood][4].ToString();

                MemoryStream ms = new MemoryStream((byte[])tblAll.Rows[indexRandomFood][1]);
                frm.picFood.Image = Image.FromStream(ms);
                ShowCount();
                frm.ShowDialog();
            }
        }

        private void btnAddSuggest_Click(object sender, EventArgs e)
        {
            Vars.categories.Clear();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            FrmCategory frm = new FrmCategory();
            frm.Icon = this.Icon;
            frm.ShowDialog();
            txtCatSuggest.Clear();
            foreach (var i in Vars.categories)
            {
                txtCatSuggest.Text += i.Item2 + " , ";
            }
        }

        private void btnShowAllInBiGForm_Click(object sender, EventArgs e)
        {
            FrmShowAll frm = new FrmShowAll();
            Vars.tblAll = tblAll;
            frm.ShowDialog();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            FrmBackUp frm = new FrmBackUp();
            frm.ShowDialog();
        }
    }
}
