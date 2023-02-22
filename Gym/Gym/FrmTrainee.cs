using Gym.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmTrainee : Form
    {
        public FrmTrainee()
        {
            InitializeComponent();
        }


        DataTable tblTraineeData = new DataTable();
        DataTable tblPhones = new DataTable();

        DataTable tblCoachDetails = new DataTable();

        DataTable tblAllData = new DataTable();
        DataTable tblGetPrice = new DataTable();

        private void GetSubsPrice()
        {
            tblGetPrice.Rows.Clear();
            DB.GetData("select subsprice from subscription where substype='" + cbxSubsType.Text + "' and exercisetype='" + cbxExerciseType.Text + "'", tblGetPrice);
            if(tblGetPrice.Rows.Count > 0)
            txtSubsPrice.Text = tblGetPrice.Rows[0][0].ToString();
        }

        private void GetSomeDetails()
        {
            tblCoachDetails.Rows.Clear();

            DB.GetData("select empno,empname from Gymemployee where jobtype='كابتن تدريب (كمال أجسام)' or jobtype='كابتن تدريب Boxing' or jobtype='كابتن تدريب رياضات أخرى' or jobtype='كابتن تدريب تأهيل ولياقه بدنيه' or jobtype='مدرب أيروبكس و زومبا' or jobtype='مدرب مساج'", tblCoachDetails);

            if (tblCoachDetails.Rows.Count>0)
            {

                cbxTrCoachName.DataSource = tblCoachDetails;
                cbxTrCoachName.DisplayMember = tblCoachDetails.Columns[1].ToString();
                cbxTrCoachName.ValueMember = tblCoachDetails.Columns[0].ToString();
            }
        }
        private void ShowData()
        {
            tblTraineeData.Rows.Clear();
            tblPhones.Rows.Clear();
            tblAllData.Rows.Clear();

            DB.GetData("select * from Trainee", tblTraineeData);
            DB.GetData("select * from TraineePhones", tblPhones);
            GetSomeDetails();

            if (tblTraineeData.Rows.Count > 0)
            {
                if(tblAllData.Columns.Count < 1)
                {
                    tblAllData.Columns.Add("trno", typeof(int));
                    tblAllData.Columns.Add("trname");
                    tblAllData.Columns.Add("trssn");
                    tblAllData.Columns.Add("traddress");
                    tblAllData.Columns.Add("trbirthdate", typeof(DateTime));
                    tblAllData.Columns.Add("trimage", typeof(byte[]));
                    tblAllData.Columns.Add("trcoach");
                    tblAllData.Columns.Add("subscriptiontype");
                    tblAllData.Columns.Add("subscriptionstart", typeof(DateTime));
                    tblAllData.Columns.Add("subscriptionend", typeof(DateTime));
                    tblAllData.Columns.Add("exercisetype");

                    tblAllData.Columns.Add("trphone");

                    
                }
                for(int x=0;x<tblTraineeData.Rows.Count;x++)
                {
                    DataRow row = tblAllData.NewRow();

                    row[0] = tblTraineeData.Rows[x][0];
                    row[1] = tblTraineeData.Rows[x][1];
                    row[2] = tblTraineeData.Rows[x][2];
                    row[3] = tblTraineeData.Rows[x][3];
                    row[4] = tblTraineeData.Rows[x][4];
                    row[5] = tblTraineeData.Rows[x][5];
                    row[6] = tblTraineeData.Rows[x][6];
                    row[7] = tblTraineeData.Rows[x][7];
                    row[8] = tblTraineeData.Rows[x][8];
                    row[9] = tblTraineeData.Rows[x][9];
                    row[10] = tblTraineeData.Rows[x][10];
                    DataRow[] rows = tblPhones.Select("trno=" + tblTraineeData.Rows[x][0]);
                    string strPhones = "";
                    foreach (DataRow i in rows)
                    {
                        strPhones += i[1] + Environment.NewLine;
                    }
                    row[11] = strPhones;
                    tblAllData.Rows.Add(row);
                }
                dgvShowTrainee.DataSource = tblAllData;
                
            }

        }
        private void AutoNum()
        {
            Tools.ClearData(pnlTrainee);
            lbxTrPhones.Items.Clear();
            dtpTrBirth.Value = DateTime.Now;
            dtpSubsStart.Value = DateTime.Now;
            dtpSubsEnd.Value = DateTime.Now;
            if (cbxTrCoachName.Items.Count > 0)
                cbxTrCoachName.SelectedIndex = 0;
            else cbxTrCoachName.Text = "";
            if (cbxSubsType.Items.Count > 0)
                cbxSubsType.SelectedIndex = 0;
            else cbxSubsType.Text = "";
            if (cbxExerciseType.Items.Count > 0)
                cbxExerciseType.SelectedIndex = 0;
            else cbxExerciseType.Text = "";

            PicTrainee.Image = new PictureBox().Image;

            string strAuto = "1";
            if(tblAllData.Rows.Count>0)
            {
                int IntAuto = Convert.ToInt32(tblAllData.Compute("max(trno)", "")) + 1;
                strAuto = IntAuto.ToString();
                txtTrCode.Text = strAuto;
            }
            else { txtTrCode.Text = strAuto; }

            EnablingBtn(false);
        }
        public void FrmTrainee_Load_1(object sender, EventArgs e)
        {
            DB.cmd.CommandType = CommandType.Text;
            try
            {
                this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
                this.Activated += delegate
                {
                    DB.cmd.CommandType = CommandType.Text;
                    ShowData();
                    GetSomeDetails();
                    AutoNum();
                    CalcSubsEnd();
                    GetSubsPrice();
                };
                ShowData();
                AutoNum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void dgvShowTrainee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShowTrainee.CurrentRow != null)
            {
                txtTrCode.Text = dgvShowTrainee.CurrentRow.Cells["coltrno"].Value.ToString();
                txtTrName.Text = dgvShowTrainee.CurrentRow.Cells["coltrname"].Value.ToString();
                txtTrSsn.Text = dgvShowTrainee.CurrentRow.Cells["coltrssn"].Value.ToString();

                var r = from trphone in tblPhones.AsEnumerable()
                        where trphone[0].ToString() == txtTrCode.Text
                        select trphone[1];
                lbxTrPhones.Items.Clear();
                foreach (var i in r)
                {
                    lbxTrPhones.Items.Add(i);
                }

                txtTrAddress.Text = dgvShowTrainee.CurrentRow.Cells["coltraddress"].Value.ToString();
                dtpTrBirth.Value = Convert.ToDateTime(dgvShowTrainee.CurrentRow.Cells["coltrbdate"].Value);

                MemoryStream ms = new MemoryStream((byte[])dgvShowTrainee.CurrentRow.Cells["coltrimage"].Value);
                PicTrainee.Image = Image.FromStream(ms);
                cbxTrCoachName.Text = dgvShowTrainee.CurrentRow.Cells["coltrcoach"].Value.ToString();
                cbxSubsType.Text = dgvShowTrainee.CurrentRow.Cells["coltrsubtype"].Value.ToString();


                dtpSubsStart.Value = Convert.ToDateTime(dgvShowTrainee.CurrentRow.Cells["coltrstartsub"].Value);
                dtpSubsEnd.Value = Convert.ToDateTime(dgvShowTrainee.CurrentRow.Cells["coltrendsub"].Value);
                cbxExerciseType.Text = dgvShowTrainee.CurrentRow.Cells["colexercisetype"].Value.ToString();

                EnablingBtn();
            }
        }

        private void btnAddTrPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            of.Filter = "Images|*.jpg;*.png";
            if(of.ShowDialog()==DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(Image.FromFile(of.FileName), new Size(150, 150));
                PicTrainee.Image = bmp;
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (Validate_Trainee()) return;

                FrmConfirmDel f = new FrmConfirmDel();
                if (PicTrainee.Image==new PictureBox().Image)
                {
                    f.lblHeader.Text = "هل لا يوجد صوره للمشترك سيتم وضع صوره افتراضيه";
                    f.btnYes.Text = "موافق";
                    f.btnNo.Text = "لا";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        PicTrainee.Image = Resources._default;
                        return;
                    }
                    return;
                }
                DB.cmd.Parameters.Clear();
                DB.cmd.CommandType = CommandType.StoredProcedure;

                var r = from trSSn in tblAllData.AsEnumerable()
                        select new
                        {
                         trssnrow=trSSn[2]
                        };
                foreach (var s in r)
                {
                    if (txtTrSsn.Text.Trim()==s.trssnrow.ToString())
                    {
                        MessageBox.Show("رقم البطاقه موجود بالفعل لمشترك اخر ادخل رقم بطاقه صحيح");
                        return;
                    }
                }

                DB.cmd.Parameters.AddWithValue("@trno", txtTrCode.Text);
                DB.cmd.Parameters.AddWithValue("@trname", txtTrName.Text);
                DB.cmd.Parameters.AddWithValue("@trssn", txtTrSsn.Text);
                DB.cmd.Parameters.AddWithValue("@traddress", txtTrAddress.Text);
                DB.cmd.Parameters.AddWithValue("@trbirthdate", dtpTrBirth.Value);
                if (PicTrainee.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    PicTrainee.Image.Save(ms, ImageFormat.Jpeg);
                    DB.cmd.Parameters.AddWithValue("@trimage", ms.ToArray());
                }
                DB.cmd.Parameters.AddWithValue("@trcoach", cbxTrCoachName.Text);
                DB.cmd.Parameters.AddWithValue("@subscriptiontype", cbxSubsType.Text);
                DB.cmd.Parameters.AddWithValue("@subscriptionstart", dtpSubsStart.Value);
                DB.cmd.Parameters.AddWithValue("@subscriptionend", dtpSubsEnd.Value);
                DB.cmd.Parameters.AddWithValue("@exercisetype", cbxExerciseType.Text);
                DB.Run("add_trainee");

                DB.cmd.Parameters.Clear();
                DB.cmd.CommandType = CommandType.Text;
                if (lbxTrPhones.Items.Count > 0)
                {
                    for (int x=0;x<lbxTrPhones.Items.Count;x++)
                    {
                        DB.Run("insert into TraineePhones values(" + txtTrCode.Text + ",'" + lbxTrPhones.Items[x].ToString() + "')");
                    }
                }
                ShowData();
                
                dgvShowTrainee.CurrentCell = dgvShowTrainee.Rows[dgvShowTrainee.Rows.Count - 1].Cells[0];
                AutoNum();
                lblMsg.Text += " تم اضافه المشترك";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTrPhone_Click(object sender, EventArgs e)
        {
            if (txtTrPhone.Text.Trim() != "")
            {
                lbxTrPhones.Items.Add(txtTrPhone.Text);
                string[] strAllWithoutRepeat = new string[lbxTrPhones.Items.Count];
                for (int x = 0; x < lbxTrPhones.Items.Count; x++)
                {
                    strAllWithoutRepeat[x] = lbxTrPhones.Items[x].ToString();
                }

                string[] strFiltered = strAllWithoutRepeat.Distinct().ToArray();
                lbxTrPhones.Items.Clear();
                lbxTrPhones.Items.AddRange(strFiltered);
                txtTrPhone.Clear();
            }
        }

        private void btnDelSelectedlbxPhoneItem_Click(object sender, EventArgs e)
        {
            while(lbxTrPhones.SelectedItems.Count>0)
            {
                lbxTrPhones.Items.Remove(lbxTrPhones.SelectedItems[0]);
            }
        }

        private void btnDelLastlbxPhoneItem_Click(object sender, EventArgs e)
        {
            if (lbxTrPhones.Items.Count > 0)
                lbxTrPhones.Items.RemoveAt(lbxTrPhones.Items.Count - 1);
        }

        private void btnDelAlllbxPhone_Click(object sender, EventArgs e)
        {
            lbxTrPhones.Items.Clear();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (Validate_Trainee()) return;
                FrmConfirmDel f = new FrmConfirmDel();
                if (PicTrainee.Image == new PictureBox().Image)
                {
                    f.lblHeader.Text = "هل لا يوجد صوره للمشترك سيتم وضع صوره افتراضيه";
                    f.btnYes.Text = "موافق";
                    f.btnNo.Text = "لا";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        PicTrainee.Image = Resources._default;
                    }
                    return;
                }


                DB.cmd.Parameters.Clear();
                DB.cmd.CommandType = CommandType.StoredProcedure;
                DB.cmd.Parameters.AddWithValue("@trno", txtTrCode.Text);
                DB.cmd.Parameters.AddWithValue("@trname", txtTrName.Text);
                DB.cmd.Parameters.AddWithValue("@trssn", txtTrSsn.Text);
                DB.cmd.Parameters.AddWithValue("@traddress", txtTrAddress.Text);
                DB.cmd.Parameters.AddWithValue("@trbirthdate", dtpTrBirth.Value);
              
                if (PicTrainee.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    PicTrainee.Image.Save(ms, ImageFormat.Jpeg);
                    DB.cmd.Parameters.AddWithValue("@trimage", ms.ToArray());
                }
                DB.cmd.Parameters.AddWithValue("@trcoach", cbxTrCoachName.Text);
                DB.cmd.Parameters.AddWithValue("@subscriptiontype", cbxSubsType.Text);
                DB.cmd.Parameters.AddWithValue("@subscriptionstart", dtpSubsStart.Value);
                DB.cmd.Parameters.AddWithValue("@subscriptionend", dtpSubsEnd.Value);
                DB.cmd.Parameters.AddWithValue("@exercisetype", cbxExerciseType.Text);
                DB.Run("edit_trainee");

                DB.cmd.Parameters.Clear();
                DB.cmd.CommandType = CommandType.Text;
                DB.Run("delete from TraineePhones where trno=" + txtTrCode.Text);
                    for (int x = 0; x < lbxTrPhones.Items.Count; x++)
                    {
                    DB.Run("insert into TraineePhones values(" + txtTrCode.Text + ",'" + lbxTrPhones.Items[x].ToString() + "')");
                    }

                ShowData();
                lblMsg.Text += "تم تعديل بيانات المشترك ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DB.cmd.Parameters.Clear();
                    DB.cmd.CommandType = CommandType.StoredProcedure;
                    DB.cmd.Parameters.AddWithValue("@trno", txtTrCode.Text);
                    DB.Run("delete_trainee");

                    DB.cmd.Parameters.Clear();
                    DB.cmd.CommandType = CommandType.Text;
                    ShowData();
                    AutoNum();
                    lblMsg.Text += "تم حذف المشترك ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcSubsEnd()
        {
            if (cbxSubsType.SelectedIndex == 0)
            {
                dtpSubsEnd.Value = dtpSubsStart.Value.AddDays(7);
            }
            else if (cbxSubsType.SelectedIndex == 1)
            {
                dtpSubsEnd.Value = dtpSubsStart.Value.AddDays(30);
            }
            else if (cbxSubsType.SelectedIndex == 2)
            {
                dtpSubsEnd.Value = dtpSubsStart.Value.AddDays(90);
            }
            else if (cbxSubsType.SelectedIndex == 3)
            {
                dtpSubsEnd.Value = dtpSubsStart.Value.AddDays(180);
            }
            else if (cbxSubsType.SelectedIndex == 4)
            {
                dtpSubsEnd.Value = dtpSubsStart.Value.AddDays(365);
            }
        }
        private void dtpSubsStart_ValueChanged(object sender, EventArgs e)
        {
            CalcSubsEnd();
        }

        private void cbxSubsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSubsEnd();
            GetSubsPrice();
        }
        private bool Validate_Trainee()
        {
            bool Is_Valid = false;
          
            if(txtTrCode.Text.Trim()=="")
            {
                epTrainee.SetError(txtTrCode, " خطأ فى كود المشترك اذا استمرت المشكله رجاء تواصل مع مصمم البرنامج");
                Is_Valid = true;
            }
            else if(txtTrName.Text.Trim()=="")
            {
                epTrainee.SetError(txtTrName, "يرجى ادخال اسم المشترك ");
                Is_Valid = true;
            }
            else if(txtTrSsn.Text.Trim()=="")
            {
                epTrainee.SetError(txtTrSsn, "يرجى ادخال رقم قومى غير مخصص لمشترك اخر ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if(lbxTrPhones.Items.Count < 1)
            {
                epTrainee.SetError(lbxTrPhones, "يرجى ادخال رقم هاتف على الأقل ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if(txtTrAddress.Text.Trim()=="")
            {
                epTrainee.SetError(txtTrAddress, "يرجى ادخال العنوان ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if (cbxTrCoachName.Items.Count < 1)
            {
                epTrainee.SetError(cbxTrCoachName, " يرجى التوجه الى تبويب اداره الموظفين واضافه مدربين بتخصص كمال اجسام أو Boxing أوغيره");
                Is_Valid = true;
            }
            else if(cbxSubsType.Text.Trim()=="")
            {
                epTrainee.SetError(cbxSubsType, "برجاء اختيار نوع الاشتراك من القائمه");
                Is_Valid = true;
            }
            else if(cbxTrCoachName.Text.Trim()=="")
            {
                epTrainee.SetError(cbxTrCoachName, "برجاء اختيار اسم المدرب من القائمه");
                Is_Valid = true;
            }
            else if(cbxExerciseType.Text.Trim()=="")
            {
                epTrainee.SetError(cbxExerciseType, "برجاء اختيار نوع التمرين من القائمه");
                Is_Valid = true;
            }
            else
            {
                epTrainee.Clear();
            }

            return Is_Valid;
        }

        private void txtTrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space) e.Handled = true;
        }

        private void txtTrSsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTrAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            new FrmEmployee().txtEmpAddress_KeyPress(sender, e);
        }
        string str = "";
        private void cbxTrCoachName_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).Items.Count > 0)
            {
                for (int x = 0; x < ((ComboBox)sender).Items.Count; x++)
                {
                    if (!Regex.IsMatch(((ComboBox)sender).Items[x].ToString(), ((ComboBox)sender).Text))
                    {
                        cbxTrCoachName.Text = str;
                        break;
                    }
                }
            }
        }

        private void cbxTrCoachName_Click(object sender, EventArgs e)
        {
             str = cbxTrCoachName.Text;
        }

        private void cbxTrCoachName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            str = cbxTrCoachName.GetItemText(cbxTrCoachName.SelectedItem);
        }

        private void cbxSubsType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmTrainee_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
        }

        private void cbxTrCoachName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                str = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }
        private void EnablingBtn(bool b = true)
        {
            btnAddEmp.Enabled = !b;
            btnEditEmp.Enabled = b;
            btnDeleteEmp.Enabled = b;
            foreach (Control c in pnlTrainee.Controls)
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

        private void txtTrPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnAddTrPhone.PerformClick();
        }

        private void txtTrSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tblAllData);
            string strFiltered = "";
           
             if(rdoTrName.Checked)
            {
                strFiltered = "trname like'%" + txtTrSearch.Text + "%'";
            }
            else if(rdoTrSsn.Checked)
            {
                strFiltered = "trssn like'%" + txtTrSearch.Text + "%'";
            }
            else if(rdoTrCoach.Checked)
            {
                strFiltered = "trcoach like'%" + txtTrSearch.Text + "%'";
            }
            else if(rdoTrSubsType.Checked)
            {
                strFiltered = "subscriptiontype like'%" + txtTrSearch.Text + "%'";
            }
            else if (rdoTrCode.Checked)
            {
                if (txtTrSearch.Text.Trim() == "")
                    strFiltered = "trname like'%%'";
                else
                strFiltered = "trno=" + txtTrSearch.Text;
            }

            dv.RowFilter = strFiltered;
            dgvShowTrainee.DataSource = dv;
        }

        private void rdoTrCode_Click(object sender, EventArgs e)
        {
            txtTrSearch.Focus();
            txtTrSearch.Select();
        }

        private void txtTrSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rdoTrCode.Checked || rdoTrSsn.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled=true;
            }
            else if(rdoTrName.Checked || rdoTrCoach.Checked || rdoTrSubsType.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space) e.Handled = true;
            }
        }

        private void btnShowAllTrainee_Click(object sender, EventArgs e)
        {
            FrmShowAllTrainee frm = new FrmShowAllTrainee();
            Vars.tblShowAllTrainee = tblAllData;
            frm.ShowDialog();
        }

        private void cbxExerciseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSubsPrice();
        }

        private void btnSubsDetails_Click(object sender, EventArgs e)
        {
            FrmSubscriptionManage frm = new FrmSubscriptionManage();
            frm.MdiParent = Application.OpenForms[0];
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmSubscriptionManage)
                {
                    f.Activate();
                    ToolStrip ts = (ToolStrip)System.Windows.Forms.Application.OpenForms["FrmMian"].Controls["stripMain"];
                    ts.Items["tsLabelHeadLines"].Text = "اداره الاشتراكات";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
            ToolStrip ts1 = (ToolStrip)System.Windows.Forms.Application.OpenForms["FrmMian"].Controls["stripMain"];
            ts1.Items["tsLabelHeadLines"].Text = "اداره الاشتراكات";
        }
    }
}
