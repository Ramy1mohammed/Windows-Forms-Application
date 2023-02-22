using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmTrainingMap : Form
    {
        public FrmTrainingMap()
        {
            InitializeComponent();
        }
        DataTable tblData = new DataTable();
       static SqlDataAdapter adapter = new SqlDataAdapter("select * from TrainingMap",DB.conn);
        private void ShowData()
        {
            tblData.Rows.Clear();
            adapter.FillSchema(tblData, SchemaType.Mapped);
            adapter.Fill(tblData);
            dgvShowTrainingMap.DataSource = tblData;
        }
        private void AutoNum()
        {
            dgvShowTrainingMap.ClearSelection();
            txtMapName.Clear();
            txtMapName.Focus(); txtMapName.Select();
            txtTrainingDesc.Clear();                          
          
            PicTainingMap.Image = new PictureBox().Image;

            string strAuto = "1";
            if(tblData.Rows.Count < 1)
            {
                txtMapCode.Text = strAuto;
            }
            else
            {
                int IntAuto = Convert.ToInt32(tblData.Compute("max(trainingno)", "")) + 1;
                strAuto = IntAuto.ToString();
                txtMapCode.Text = strAuto;
            }
           
        }
       
        private void btnNewMapTraining_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void dgvShowTrainingMap_SelectionChanged(object sender, EventArgs e)
        {            
            if(dgvShowTrainingMap.CurrentRow!=null)
            {
                txtMapCode.Text = dgvShowTrainingMap.CurrentRow.Cells["colmapcode"].Value.ToString();
                txtMapName.Text = dgvShowTrainingMap.CurrentRow.Cells["colmapname"].Value.ToString();
                txtTrainingDesc.Text = dgvShowTrainingMap.CurrentRow.Cells["colmapdesc"].Value.ToString();
                cbxMapCategory.Text = dgvShowTrainingMap.CurrentRow.Cells["colmapcat"].Value.ToString();

                MemoryStream ms = new MemoryStream((byte[])dgvShowTrainingMap.CurrentRow.Cells["colmapimage"].Value);
                PicTainingMap.Image = Image.FromStream(ms);
            }
        }
        private void FrmTrainingMap_Load(object sender, EventArgs e)
        {
            this.Activated += delegate {
                AutoNum();
                if(cbxMapCategory.Items.Count>0)
                cbxMapCategory.SelectedIndex = 0;
            };
            ShowData();
            AutoNum();
        }


        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
        private void btnAddNewMapTraining_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (ValidateTrainingMap()) return;
                epTrMap.Clear();

                if (PicTainingMap.Image==new PictureBox().Image)
                {
                    FrmConfirmDel f = new FrmConfirmDel();
                    f.lblHeader.Text = "سيتم وضع صوره افتراضيه للبرنامج التدريبى ";
                    if(f.ShowDialog()==DialogResult.OK)
                    {
                        PicTainingMap.Image = Properties.Resources.pesas_gym_png_2;
                    }
                    else { return; }
                }

                DataRow row = tblData.NewRow(); 
                     row[0] = txtMapCode.Text;
                     row[1]= txtMapName.Text;

                    MemoryStream ms = new MemoryStream();
                    PicTainingMap.Image.Save(ms, ImageFormat.Jpeg);
                    row[2] = ms.ToArray();

                    row[3] = cbxMapCategory.Text;
                    row[4] = txtTrainingDesc.Text;
                tblData.Rows.Add(row);
                    adapter.Update(tblData);
                    ShowData();
                dgvShowTrainingMap.CurrentCell = dgvShowTrainingMap.Rows[dgvShowTrainingMap.Rows.Count - 1].Cells[0];
                lblMsg.Text = " تم اضافه االبرنامج التدريبى ";
                AutoNum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddTrainingPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Filter = "Images|*.jpg;*.png";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(Image.FromFile(ofd.FileName), new Size(150, 150));
                PicTainingMap.Image = bmp;
            }
            else
            {
                PicTainingMap.Image = Properties.Resources.pesas_gym_png_2;
            }
        }

        private void btnEditMapTraining_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (ValidateTrainingMap()) return;
                epTrMap.Clear();

                if (PicTainingMap.Image == new PictureBox().Image)
                {
                    FrmConfirmDel f = new FrmConfirmDel();
                    f.lblHeader.Text = "سيتم وضع صوره افتراضيه للبرنامج التدريبى ";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        PicTainingMap.Image = Properties.Resources.pesas_gym_png_2;
                    }
                    else { return; }
                }

                if (tblData.Constraints.Count < 1)
                {
                    tblData.Constraints.Add("trainingno_PK", tblData.Columns[0], true);
                }
                DataRow row = tblData.Rows.Find(txtMapCode.Text);
                row[0] = txtMapCode.Text;
                row[1] = txtMapName.Text;
                MemoryStream ms = new MemoryStream();
                PicTainingMap.Image.Save(ms, ImageFormat.Jpeg);
                row[2] = ms.ToArray();

                row[3] = cbxMapCategory.Text;
                row[4] = txtTrainingDesc.Text;
                adapter.Update(tblData);
                lblMsg.Text += " تم التعديل على الخطه التدريبيه";
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteMapTraining_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                FrmConfirmDel f = new FrmConfirmDel();
                f.lblHeader.Text = "هل تريد حذف الخطه التدريبيه";
                if (f.ShowDialog() == DialogResult.OK)
                {

                    if (tblData.Constraints.Count < 1)
                    {
                        tblData.Constraints.Add("trainingno_PK", tblData.Columns[0], true);
                    }
                    DataRow row = tblData.Rows.Find(txtMapCode.Text);

                    row.Delete();
                    adapter.Update(tblData);
                    lblMsg.Text += "تم حذف الخطه التدريبيه ";
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxMapCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmTrainingMap_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
        }
        private bool ValidateTrainingMap()
        {
            bool Is_Valid = false;
            if(txtMapCode.Text.Trim()=="")
            {
                epTrMap.SetError(txtMapCode, "حدث مشكله بكود البرنامج التدريبى اذا استمرت المشكله من فضلك قم بالتواصل مع مصمم البرنامج ");
                Is_Valid = true;
            }
            else if(txtMapName.Text.Trim()=="")
            {
                epTrMap.SetError(txtMapName, "من فضلك ادخل اسم البرنامج التدريبى ");
                Is_Valid = true;
            }
            else if(cbxMapCategory.Text.Trim()=="")
            {
                epTrMap.SetError(cbxMapCategory, "من فضلك قم باختيار تصنيف التمرين من القائمه ");
                Is_Valid = true;
            }
            else if(txtTrainingDesc.Text.Trim()=="")
            {
                epTrMap.SetError(txtTrainingDesc, "من فضلك قم بادخال وصف التمرين ");
                Is_Valid = true;
            }
            return Is_Valid;
        }
    }
}
