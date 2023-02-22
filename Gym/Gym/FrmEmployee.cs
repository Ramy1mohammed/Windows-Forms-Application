using Gym.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Net.Mime;

namespace Gym
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        DataTable tblalldata = new DataTable();
        DataTable tblPhones = new DataTable();
        DataTable tblEmp = new DataTable();
        DataTable tblDept = new DataTable();


        public void ShowData()
        {

            tblalldata.Clear();
            tblPhones.Rows.Clear();
            tblEmp.Rows.Clear();
            
            DB.cmd.CommandType = CommandType.Text;
            DB.GetData("select * from EmployeePhones", tblPhones);
            DB.GetData("select * from Gymemployee", tblalldata);
            

            if (tblalldata.Rows.Count > 0)
            {
                if (tblEmp.Columns.Count < 1)
                {
                    tblEmp.Columns.Add("empno", typeof(int));
                    tblEmp.Columns.Add("empname");
                    tblEmp.Columns.Add("empssn");
                    tblEmp.Columns.Add("empaddress");
                    tblEmp.Columns.Add("empbirthdate", typeof(DateTime));
                    tblEmp.Columns.Add("jobtype");
                    tblEmp.Columns.Add("salary", typeof(decimal));
                    tblEmp.Columns.Add("empimage", typeof(byte[]));
                    tblEmp.Columns.Add("deptworkfor");
                    tblEmp.Columns.Add("workstartdate", typeof(DateTime));
                    tblEmp.Columns.Add("workhours", typeof(int));
                    tblEmp.Columns.Add("workshift");
                    tblEmp.Columns.Add("empphone");
                }

                for (int x = 0; x < tblalldata.Rows.Count; x++)
                {
                    DataRow row = tblEmp.NewRow();
                    row[0] = tblalldata.Rows[x][0];
                    row[1] = tblalldata.Rows[x][1];
                    row[2] = tblalldata.Rows[x][2];
                    row[3] = tblalldata.Rows[x][3];
                    row[4] = tblalldata.Rows[x][4];
                    row[5] = tblalldata.Rows[x][5];
                    row[6] = tblalldata.Rows[x][6];
                    row[7] = tblalldata.Rows[x][7];
                    row[8] = tblalldata.Rows[x][8];
                    row[9] = tblalldata.Rows[x][9];
                    row[10] = tblalldata.Rows[x][10];
                    row[11] = tblalldata.Rows[x][11];
                    DataRow[] empPhone = tblPhones.Select("empno=" + tblalldata.Rows[x][0]);
                    string strResult = "";
                    foreach (DataRow i in empPhone)
                    {
                        strResult += i[1] + Environment.NewLine;
                    }
                    row[12] = strResult;

                    tblEmp.Rows.Add(row);
                }


                dgvShowEmp.DataSource = tblEmp;
                RefreshDeptData();
            }
        }
        private void RefreshDeptData()
        {
            tblDept.Rows.Clear();
            DB.GetData("select * from Department", tblDept);

            var v = from dept in tblDept.AsEnumerable()
                    select dept[1];
            cbxChooseDept.Items.Clear();

            cbxChooseDept.Items.Add("مكتب سكرتاريه رئيس مجلس الاداره");
            cbxChooseDept.Items.Add("مكتب مساعد رئيس مجلس الاداره");
            cbxChooseDept.Items.Add("مكتب سكرتاريه مساعد رئيس مجلس الاداره ");
            cbxChooseDept.Items.Add("مكتب المدير");
            cbxChooseDept.Items.Add("مكتب سكرتاريه المدير");
            cbxChooseDept.Items.Add("قسم الاستقبال");
            cbxChooseDept.Items.Add("صاله تدريب كمال اجسام");
            cbxChooseDept.Items.Add("صاله تدريب Boxing");
            cbxChooseDept.Items.Add("صاله تدريب ايروبكس");
            cbxChooseDept.Items.Add("صاله تدريب زومبا");
            cbxChooseDept.Items.Add("قسم الجاكوزى- الساونا-البخار");
            cbxChooseDept.Items.Add("غرفه تغيير الملابس");
            cbxChooseDept.Items.Add("قسم المكملات الغذائيه");
            cbxChooseDept.Items.Add("قسم بيع منتجات رياضيه");
            cbxChooseDept.Items.Add("قسم المشروبات والمأكولات");
            cbxChooseDept.Items.Add("قسم الشكاوى والمقترحات");
            cbxChooseDept.Items.Add("قسم الأشياء المفقوده");
            cbxChooseDept.Items.Add("قسم أعمال صيانه الأجهزه");
            cbxChooseDept.Items.Add("قسم المراحيض ");
            cbxChooseDept.Items.Add("قسم أخصائى العلاج الطبيعى");

            foreach (var i in v)
            {
                cbxChooseDept.Items.Add(i);
            }
        }
        private void Autonum()
        {
            Tools.ClearData(pnlEmpControls);
            lbxEmpPhones.Items.Clear();
            dtpEmpBDate.Value = DateTime.Now;
            dtpJobStart.Value = DateTime.Now;
            nudWorkHours.Value = 1;
            picEmp.Image = new PictureBox().Image;
            
            if(cbxChooseDept.Items.Count>0)
            cbxChooseDept.SelectedIndex = 0;
            if (cbxEmpJobType.Items.Count > 0)
                cbxEmpJobType.SelectedIndex = 0;

            string strAuto = "1";
            if (tblEmp.Rows.Count > 0)
            {
                int intAuto = Convert.ToInt32(tblEmp.Compute("max(empno)", "")) + 1;
                strAuto = intAuto.ToString();
                txtEmpCode.Text = strAuto;
            }
            else
            {
                txtEmpCode.Text = strAuto;
            }
            txtEmpName.Focus();
            txtEmpName.Select();
            txtEmpName.SelectAll();
            EnablingBtn(false);
        }

       
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
         
            try
            {
             
                this.Activated += delegate {
                    DB.cmd.CommandType = CommandType.Text;
                        RefreshDeptData();
                   
                };

                ShowData();
                Autonum();
                dgvShowEmp.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Vars.elements.Clear();
            DB.cmd.Parameters.Clear();
            lblMsg.Text = ">>";

            try
            {
                if (Validate_emp()) return;
                FrmConfirmDel f = new FrmConfirmDel();
                if (picEmp.Image == new PictureBox().Image)
                {
                    f.lblHeader.Text = "هل لا يوجد صوره للموظف سيتم وضع صوره افتراضيه";
                    f.btnYes.Text = "موافق";
                    f.btnNo.Text = "اختيار صوره";

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        picEmp.Image = Resources._default;
                    }
                    else
                        btnAddEmpImage.PerformClick();
                    return;
                }
                MemoryStream ms = new MemoryStream();
                picEmp.Image.Save(ms, ImageFormat.Jpeg);
                DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());

                int Workhours = (int)nudWorkHours.Value;
                string strShift = "";
                if (rdo12_1Shift.Checked)
                    strShift = "شيفت 12 فتره اولى";
                else if (rdo12_2Shift.Checked)
                    strShift = "شيفت 12 فتره ثانيه";
                else if (rdo8_1Shift.Checked)
                    strShift = "شيفت 8 فتره اولى";
                else if(rdo8_2Shift.Checked)
                    strShift = "شيفت 8 فتره ثانيه";
                else if(rdo8_3Shift.Checked)
                    strShift = "شيفت 8 فتره ثالثه";

                DB.cmd.Parameters.AddWithValue("@bdate", dtpEmpBDate.Value);
                DB.cmd.Parameters.AddWithValue("@jobdate", dtpJobStart.Value);

                var r = from emp in tblEmp.AsEnumerable()
                        select new
                        {
                            rowssn = emp[2]
                        };

                foreach (var i in r)
                {
                    if (txtEmpSsn.Text == i.rowssn.ToString())
                    {
                        f.lblHeader.Text = " رقم البطاقه موجود بالفعل لموظف اخر ادخل رقم بطاقه صحيح ";
                        f.btnYes.Text = "موافق";
                        f.btnYes.Left = (f.Width - f.btnYes.Width) / 2;
                        f.btnNo.Visible = false;
                        f.ShowDialog();
                        return;
                    }
                }

                string strCmd = "insert into Gymemployee values(" + txtEmpCode.Text + ",'" + txtEmpName.Text + "','" + txtEmpSsn.Text + "','" + txtEmpAddress.Text + "',@bdate,'" + cbxEmpJobType.Text + "'," + txtEmpSalary.Text + ",@img,'" + cbxChooseDept.Text + "',@jobdate," + Workhours + ",'"+strShift+"')";

                DB.Run(strCmd);
                foreach (var item in lbxEmpPhones.Items)
                {
                    DB.Run("insert into EmployeePhones values(" + txtEmpCode.Text + ",'" + item.ToString() + "')");
                }
                lblMsg.Text += " تم اضافه الموظف ";

                ShowData();
                
                dgvShowEmp.CurrentCell = dgvShowEmp.Rows[dgvShowEmp.Rows.Count - 1].Cells[0];
                Autonum();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddEmpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Filter = "Images|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(System.Drawing.Image.FromFile(ofd.FileName), new Size(150, 150));
                picEmp.Image = bmp;
            }
        }       

        private void btnAddPhones_Click(object sender, EventArgs e)
        {
            if (txtEmpPhone.Text.Trim() != "")
            {
                lbxEmpPhones.Items.Add(txtEmpPhone.Text);
                string[] strAllWithoutRepeat = new string[lbxEmpPhones.Items.Count];
                for (int x = 0; x < lbxEmpPhones.Items.Count; x++)
                {
                    strAllWithoutRepeat[x] = lbxEmpPhones.Items[x].ToString();
                }

                string[] strFiltered = strAllWithoutRepeat.Distinct().ToArray();
                lbxEmpPhones.Items.Clear();
                lbxEmpPhones.Items.AddRange(strFiltered);
                txtEmpPhone.Clear();
            }
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {

            DB.cmd.Parameters.Clear();
            lblMsg.Text = ">>";
            try
            {
                if (Validate_emp()) return;
                FrmConfirmDel f = new FrmConfirmDel();
                if (picEmp.Image == new PictureBox().Image)
                {
                    f.lblHeader.Text = "هل لا يوجد صوره للموظف سيتم وضع صوره افتراضيه";
                    f.btnYes.Text = "موافق";
                    f.btnNo.Text = "اختيار صوره";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        picEmp.Image = Resources._default;
                    }

                    return; ;
                }
                MemoryStream ms = new MemoryStream();
                picEmp.Image.Save(ms, ImageFormat.Jpeg);
                DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());

                int Workhours = (int)nudWorkHours.Value;

                string strShift = "";
                if (rdo12_1Shift.Checked)
                    strShift = "شيفت 12 فتره اولى";
                else if (rdo12_2Shift.Checked)
                    strShift = "شيفت 12 فتره ثانيه";
                else if (rdo8_1Shift.Checked)
                    strShift = "شيفت 8 فتره اولى";
                else if (rdo8_2Shift.Checked)
                    strShift = "شيفت 8 فتره ثانيه";
                else if (rdo8_3Shift.Checked)
                    strShift = "شيفت 8 فتره ثالثه";


                DB.cmd.Parameters.AddWithValue("@bdate", dtpEmpBDate.Value);
                DB.cmd.Parameters.AddWithValue("@jobdate", dtpJobStart.Value);

                string strCmd = "update Gymemployee set empname='" + txtEmpName.Text + "', empssn='" + txtEmpSsn.Text + "', empaddress='" + txtEmpAddress.Text + "', empbirthdate=@bdate, jobtype='" + cbxEmpJobType.Text + "', salary=" + txtEmpSalary.Text + ", deptworkfor='"+cbxChooseDept.Text+"', empimage=@img, workstartdate=@jobdate, workhours=" + Workhours + ", workShift='"+strShift+"' where empno=" + txtEmpCode.Text;

                DB.Run(strCmd);

                DB.Run("delete from EmployeePhones where empno=" + txtEmpCode.Text);
                foreach (var item in lbxEmpPhones.Items)
                {
                    DB.Run("insert into EmployeePhones values(" + txtEmpCode.Text + ",'" + item.ToString() + "')");
                }
                lblMsg.Text += " تم تعديل بيانات الموظف ";
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvShowEmp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShowEmp.CurrentRow != null)
            {
                txtEmpCode.Text = dgvShowEmp.CurrentRow.Cells[0].Value.ToString();
                txtEmpName.Text = dgvShowEmp.CurrentRow.Cells[1].Value.ToString();
                txtEmpSsn.Text = dgvShowEmp.CurrentRow.Cells[2].Value.ToString();

                var r = from empphone in tblPhones.AsEnumerable()
                        where empphone[0].ToString() == txtEmpCode.Text
                        select empphone[1];
                lbxEmpPhones.Items.Clear();
                foreach (var i in r)
                {
                    lbxEmpPhones.Items.Add(i);
                }

                txtEmpAddress.Text = dgvShowEmp.CurrentRow.Cells[3].Value.ToString();
                dtpEmpBDate.Value = Convert.ToDateTime(dgvShowEmp.CurrentRow.Cells[4].Value);
                cbxEmpJobType.Text = dgvShowEmp.CurrentRow.Cells[5].Value.ToString();
                txtEmpSalary.Text = dgvShowEmp.CurrentRow.Cells[6].Value.ToString();

                MemoryStream ms = new MemoryStream((byte[])dgvShowEmp.CurrentRow.Cells[7].Value);
                picEmp.Image = System.Drawing.Image.FromStream(ms);

                cbxChooseDept.Text = dgvShowEmp.CurrentRow.Cells[8].Value.ToString();
                dtpJobStart.Value = Convert.ToDateTime(dgvShowEmp.CurrentRow.Cells[9].Value.ToString());
                nudWorkHours.Value = Convert.ToDecimal(dgvShowEmp.CurrentRow.Cells[10].Value);
                string strShowShift = "";
                strShowShift = dgvShowEmp.CurrentRow.Cells[11].Value.ToString();
                if (strShowShift == "شيفت 12 فتره اولى")
                    rdo12_1Shift.Checked = true;
                else if (strShowShift == "شيفت 12 فتره ثانيه")
                    rdo12_2Shift.Checked = true;
                else if (strShowShift == "شيفت 8 فتره اولى")
                    rdo8_1Shift.Checked = true;
                else if (strShowShift == "شيفت 8 فتره ثانيه")
                    rdo8_2Shift.Checked = true;
                else if (strShowShift == "شيفت 8 فتره ثالثه")
                    rdo8_3Shift.Checked = true;
                   
                EnablingBtn();
            }
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {

            if (dgvShowEmp.Rows.Count > 0)
                dgvShowEmp.CurrentRow.Selected = false;
            Autonum();
            EnablingBtn(false);
        }

        private void btnDelSelectedlbxPhoneItem_Click(object sender, EventArgs e)
        {
            while (lbxEmpPhones.SelectedItems.Count > 0)
            {
                lbxEmpPhones.Items.Remove(lbxEmpPhones.SelectedItems[0]);
            }
        }

        private void btnDelLastlbxPhoneItem_Click(object sender, EventArgs e)
        {
            if (lbxEmpPhones.Items.Count > 0)
                lbxEmpPhones.Items.RemoveAt(lbxEmpPhones.Items.Count - 1);
        }

        private void btnDelAlllbxPhone_Click(object sender, EventArgs e)
        {
            lbxEmpPhones.Items.Clear();
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف الموظف بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (txtEmpCode.Text.Trim() != "")
                    {
                        DB.Run("delete from Gymemployee where empno=" + txtEmpCode.Text);
                        DB.Run("delete from EmployeePhones where empno=" + txtEmpCode.Text);
                        ShowData();
                        Autonum();
                        lblMsg.Text += " تم حذف الموظف";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEmpSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(tblEmp);
                string strFiltered = "";
                if (rdoEmpName.Checked)
                {
                    strFiltered = "empname like'%" + txtEmpSearch.Text + "%'";
                }
                else if (rdoEmpssn.Checked)
                {
                    strFiltered = "empssn like'%" + txtEmpSearch.Text + "%'";
                }
                else if (rdoJobtype.Checked)
                {
                    strFiltered = "jobtype like'%" + txtEmpSearch.Text + "%'";
                }
                else
                {
                    strFiltered = "deptworkfor like'%" + txtEmpSearch.Text + "%'";
                }
                dv.RowFilter = strFiltered;
                dgvShowEmp.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void sansationRoundButton1_Click(object sender, EventArgs e)
        {
            //Vars.tblShowAllEmps.Rows.Clear();
            Vars.tblShowAllEmps = tblEmp;
            new FrmShowAllEmps().ShowDialog();
        }

        private void rdoEmpName_Click(object sender, EventArgs e)
        {
            txtEmpSearch.Select();
            txtEmpSearch.Focus();
        }

        private void txtEmpPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnAddPhones.PerformClick();
        }

        private bool Validate_emp()
        {
            bool Is_Valid = false;
            if (txtEmpCode.Text.Trim() == "")
            {
                epEmp.SetError(txtEmpCode, "خطأ فى كود الموظف اذا استمرت المشكله رجاء تواصل مع مصمم البرنامج");
                Is_Valid = true;
            }
            else if (txtEmpName.Text.Trim() == "")
            {
                epEmp.SetError(txtEmpName, "يرجى ادخال اسم الموظف");
                Is_Valid = true;
            }
            else if (txtEmpSsn.Text.Trim() == "")
            {
                epEmp.SetError(txtEmpSsn, "يرجى ادخال رقم قومى غير مخصص لموظف اخر ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if (lbxEmpPhones.Items.Count < 1)
            {
                epEmp.SetError(lbxEmpPhones, "يرجى ادخال رقم هاتف على الأقل ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if (txtEmpAddress.Text.Trim() == "")
            {
                epEmp.SetError(txtEmpAddress, "يرجى ادخال العنوان ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if (cbxEmpJobType.Text.Trim() == "")
            {
                epEmp.SetError(cbxEmpJobType, "يرجى اختيار نوع الوظيفه");
                Is_Valid = true;
            }
            else if (txtEmpSalary.Text.Trim() == "")
            {
                epEmp.SetError(txtEmpSalary, "يرجى ادخال المرتب ولو بشكل افتراضى");
                Is_Valid = true;
            }
            else if (cbxChooseDept.Text.Trim() == "")
            {
                epEmp.SetError(cbxChooseDept, "يرجى اختيار القسم للموظف");
                Is_Valid = true;
            }
            else if (nudWorkHours.Value.ToString() == "")
            {
                epEmp.SetError(nudWorkHours, "يرجى اختيار عدد ساعات العمل بشكل صحيح");
                Is_Valid = true;
            }
            else
            {
                epEmp.Clear();
                Is_Valid = false;
            }
            return Is_Valid;
        }
        private void EnablingBtn(bool b = true)
        {
            btnAddEmp.Enabled = !b;
            btnEditEmp.Enabled = b;
            btnDeleteEmp.Enabled = b;
            foreach (Control c in pnlEmpControls.Controls)
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

        public void txtEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space) e.Handled = true;
        }

        public void txtEmpSsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        public void txtEmpAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != '-' && e.KeyChar != '/') e.Handled = true;
        }

        private void txtEmpSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (txtEmpSalary.Text.Contains("."))
            {
                if (e.KeyChar == '.') e.Handled = true;
            }
        }

        private void txtEmpSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rdoEmpssn.Checked)
            {
                txtEmpSsn_KeyPress(sender, e);
            }
            else if(rdoEmpName.Checked || rdoDept.Checked ||rdoJobtype.Checked)
            {
                txtEmpName_KeyPress(sender, e);
            }
        }

        
        string str = "";
        private void cbxChooseDept_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).Items.Count > 0)
            {
                for (int x = 0; x < ((ComboBox)sender).Items.Count; x++)
                {
                    if (!Regex.IsMatch(((ComboBox)sender).Items[x].ToString().Trim(), ((ComboBox)sender).Text))
                    {
                        ((ComboBox)sender).Text = str;
                        break;
                    }
                }
            }
        }

        private void FrmEmployee_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteEmp_Move(object sender, EventArgs e)
        {
            btnDeleteEmp.ForeColor = Color.Black;
        }

        private void FrmEmployee_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            DB.cmd.Parameters.Clear();
        }

        private void cbxChooseDept_Click(object sender, EventArgs e)
        {
            str = ((ComboBox)sender).Text;
        }

        private void cbxChooseDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            str = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }

        private void cbxChooseDept_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            str = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }

        private void btnReportEmp_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.cmd.Parameters.Clear();
        }

       
        private void btngotoDeptScreen_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            frm.MdiParent =System.Windows.Forms.Application.OpenForms["FrmMian"];

            foreach (Form f in System.Windows.Forms.Application.OpenForms)
            {
                if(f is FrmDepartment)
                {
                    f.Activate();

                    ToolStrip ts =(ToolStrip)System.Windows.Forms.Application.OpenForms["FrmMian"].Controls["stripMain"];
                    ts.Items["tsLabelHeadLines"].Text = "اداره الأقسام";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();

            ToolStrip ts1 = (ToolStrip)System.Windows.Forms.Application.OpenForms["FrmMian"].Controls["stripMain"];
            ts1.Items["tsLabelHeadLines"].Text = "اداره الأقسام";
        }
    }
}

