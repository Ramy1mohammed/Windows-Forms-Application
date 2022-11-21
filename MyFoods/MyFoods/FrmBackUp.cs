using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFoods
{
    public partial class FrmBackUp : Form
    {
        public FrmBackUp()
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

        private void btnCanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTakeBackUp_Click(object sender, EventArgs e)
        {
            DB.Close();
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "رجاء اخنر مكان لأخذ النسخه الاحتياطيه";
                if(fbd.ShowDialog()==DialogResult.OK)
                {
                    DateTime Now = DateTime.Now;
                    string fileName = fbd.SelectedPath + "\\myfoods_" + Now.Year + "_" + Now.Month + "_" + Now.Day + "___" + Now.Hour + "_" + Now.Minute + "_" + Now.Second + ".accdb";
                    File.Copy("myfoods.accdb",fileName);
                    MessageBox.Show("تم اخذ النسخه الاحتياطيه"+"\n"+"المكان الذى تم الحفظ فيه بالسطر التالى "+"\n"+fileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestoreBackUp_Click(object sender, EventArgs e)
        {
            DB.Close();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Access Files|*.accdb";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DB.ChangeDBFileName(ofd.FileName);
                    DB.Open();
                    string strAllTables = @"SELECT food.FoodCode, food.FoodName, food.FoodDesc, foodcategory.FoodCode, foodcategory.CategoryNo, category.CategoryNo, category.CategoryName, foodcomponent.FoodCode, foodcomponent.Component, foodimage.FoodCode, foodimage.FoodImage
                    FROM ((food INNER JOIN (category INNER JOIN foodcategory ON category.CategoryNo = foodcategory.CategoryNo) ON food.FoodCode = foodcategory.FoodCode) INNER JOIN foodcomponent ON food.FoodCode = foodcomponent.FoodCode) INNER JOIN foodimage ON food.FoodCode = foodimage.FoodCode";
                    DB.GetData(strAllTables);
                    DB.Close();
                    File.Delete("myfoods.accdb");
                    File.Copy(ofd.FileName, "myfoods.accdb");
                    DB.ChangeDBFileName("myfoods.accdb");
                    MessageBox.Show("تم استرجاع النسخه الاحتياطيه بنجاح" + "\n" + "وسوف يعاد تشغيل البرنامج");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("الملف الذى اخترته تالف ولا يصلح"+"\n"+"وسوف يعاد تشغيل البرنامج");
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    Application.Restart();
                }
            }
        }
    }
}
