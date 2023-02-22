using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmEmployeePrecenceAndAbscence : Form
    {
        public FrmEmployeePrecenceAndAbscence()
        {
            InitializeComponent();
        }

        private void cBoxPresenceState_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxPresenceState.Checked)
            {
                gBoxPresence.Enabled = true;
                gBoxAbsence.Enabled = false;
            }
            else
            {
                gBoxPresence.Enabled = false;
                gBoxAbsence.Enabled = true;
            }
        }
        DataTable tblGetEmps = new DataTable();
        DataTable tblGetEmpPresence = new DataTable();
        private void GetAllEmps()
        {
            tblGetEmps.Rows.Clear();

            DB.GetData("GetEmpPresence", tblGetEmps);
            cbxEmpName.DataSource = tblGetEmps;
            cbxEmpName.ValueMember = tblGetEmps.Columns[0].ToString();
            cbxEmpName.DisplayMember = tblGetEmps.Columns[1].ToString();
        }
        private void GetEmpPresence()
        {
            tblGetEmpPresence.Rows.Clear();
            DB.cmd.Parameters.Clear();
            DB.GetData("formatedTime", tblGetEmpPresence);
            dgvShowPresence.DataSource = tblGetEmpPresence;
            dgvShowPresence.Columns[0].Visible = false;
        }
        DataTable tblGetEmpAbsence = new DataTable();
        private void GetEmpAbsence()
        {
            tblGetEmpAbsence.Rows.Clear();
            DB.cmd.Parameters.Clear();
            DB.GetData("getempabsence", tblGetEmpAbsence);
            dgvShowAbsence.DataSource = tblGetEmpAbsence;
            dgvShowAbsence.Columns[0].Visible = false;
        }
        DataTable tblGetEmpVacancy = new DataTable();
        DataTable tblVacancyfromTable = new DataTable();
        DataTable tblGetAllVacancy = new DataTable();
        private void GetEmpvacany()
        {

            tblGetAllVacancy.Rows.Clear();
            tblGetEmpVacancy.Rows.Clear();
            tblVacancyfromTable.Rows.Clear();

            DB.cmd.Parameters.Clear();
            DB.GetData("getallvacancies", tblVacancyfromTable);
            DB.GetData("getempvacancy", tblGetEmpVacancy);

            if (tblGetEmpVacancy.Rows.Count > 0)
            {
                if (tblGetAllVacancy.Columns.Count < 1)
                {
                    tblGetAllVacancy.Columns.Add("empno", typeof(int));
                    tblGetAllVacancy.Columns.Add("empname");
                    tblGetAllVacancy.Columns.Add("empvacancy");
                }
                for(int x=0;x<tblGetEmpVacancy.Rows.Count;x++)
                {
                    DataRow row = tblGetAllVacancy.NewRow();
                    row[0] = tblGetEmpVacancy.Rows[x][0];
                    row[1] = tblGetEmpVacancy.Rows[x][1];
                    DataRow[] rowvacancy = tblVacancyfromTable.Select("empno=" + tblGetEmpVacancy.Rows[x][0]);

                    string strVacancy = "";
                    foreach (DataRow r in rowvacancy)
                    {
                        strVacancy += r[1] + Environment.NewLine;
                    }

                    row[2] = strVacancy;

                    tblGetAllVacancy.Rows.Add(row);
                }
            }
            dgvShowVacancies.DataSource = tblGetAllVacancy;
        }
     
        private bool Validate_emp_addition()
        {
            bool Is_Valid = false;
            if(cbxEmpName.Items.Count < 1)
            {
                epEmpAddition.SetError(cbxEmpName, "برجاء التوجه لقسم الموظفين واضافه موظفين ");
                Is_Valid = true;
            }
            if(cbxEmpName.Text.Trim()=="")
            {
                epEmpAddition.SetError(cbxEmpName, "برجاء الاختيار من القائمه الحاليه ");
                Is_Valid = true;
            }

            return Is_Valid;
        }

        private void FrmEmployeePrecenceAndAbscence_Load(object sender, EventArgs e)
        {

            DB.cmd.CommandType = CommandType.StoredProcedure;

            dtpPresenceAbsenceDate.Select();
            dtpPresenceAbsenceDate.Focus();

            this.Activated += delegate {

                DB.cmd.CommandType = CommandType.StoredProcedure;
                DB.cmd.Parameters.Clear();

                dtpPresenceAbsenceDate.Select();
                dtpPresenceAbsenceDate.Focus();

                GetAllEmps();
                GetEmpPresence();
                GetEmpAbsence();
                GetEmpvacany();
            };

            GetAllEmps();
            GetEmpPresence();
            GetEmpAbsence();
            GetEmpvacany();

        }

        private void GetAutSet()
        {
            if (cBoxAutoSet.Checked)
            {
                var r = from getShift in tblGetEmps.AsEnumerable()
                        where getShift[0].ToString() == cbxEmpName.SelectedValue.ToString()
                        select
                        getShift[2];

                foreach (var i in r)
                {
                    if (i.ToString() == "شيفت 12 فتره اولى" || i.ToString() == "شيفت 12 فتره ثانيه")
                    {
                        dtpGoingTime.Value = dtpPresentTime.Value.AddHours(12);
                    }
                    else if (i.ToString() == "شيفت 8 فتره اولى" || i.ToString() == "شيفت 8 فتره ثانيه" || i.ToString() == "شيفت 8 فتره ثالثه")
                    {
                        dtpGoingTime.Value = dtpPresentTime.Value.AddHours(8);
                    }
                }


            }
        }
        private void cbxMachSupervision_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAutSet();
        }

        private void cBoxAutoSet_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxAutoSet.Checked)
            {
                dtpGoingTime.Enabled = false;
                GetAutSet(); 
            }
            else
            {
                dtpGoingTime.Enabled = true;
            }
        }
        
        private bool PreventRepeat(DataTable tbl,string str)
        {
            var r = from NoRepeate in tbl.AsEnumerable()
                    select NoRepeate[0];

            foreach (var i in r)
            {
                if (cbxEmpName.SelectedValue.ToString() == i.ToString())
                {
                    FrmConfirmDel f = new FrmConfirmDel();
                    f.lblHeader.Font = new Font(f.Font.FontFamily, 14);
                    f.lblHeader.Text = str;

                    f.btnNo.Visible = false;
                    f.btnYes.Text = "موافق";
                    f.btnYes.Left = (f.Width - f.btnYes.Width) / 2;
                    f.ShowDialog();
                    return true;
                }
            }
            return false;
        }
        private void btnAddPresence_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();

            try
            {
                if (Validate_emp_addition()) return;
               if(PreventRepeat(tblGetEmpPresence, "هذا الموظف مثبت حضوره بالفعل يمكنك التعديل على بيانات الحضور فقط"))return;

                DB.cmd.Parameters.AddWithValue("@empno", cbxEmpName.SelectedValue);
                DB.cmd.Parameters.AddWithValue("@presentdate", dtpPresenceAbsenceDate.Value);
                DB.cmd.Parameters.AddWithValue("@presenttime", dtpPresentTime.Value);
                DB.cmd.Parameters.AddWithValue("@goingtime", dtpGoingTime.Value);
                DB.Run("AddPresence");

                GetEmpPresence();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpPresentTime_ValueChanged(object sender, EventArgs e)
        {
            GetAutSet();
        }

        private void btnEditPresence_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            try
            {
                if (dgvShowPresence.CurrentRow != null)
                {
                    if (Validate_emp_addition()) return;

                    DB.cmd.Parameters.AddWithValue("@empno", dgvShowPresence.CurrentRow.Cells[0].Value);
                    DB.cmd.Parameters.AddWithValue("@presentdate", dtpPresenceAbsenceDate.Value);
                    DB.cmd.Parameters.AddWithValue("@presenttime", dtpPresentTime.Value);
                    DB.cmd.Parameters.AddWithValue("@goingtime", dtpGoingTime.Value);

                    DB.Run("editpresence");

                    GetEmpPresence();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelPresence_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();

            try
            {
                FrmConfirmDel f = new FrmConfirmDel();

                f.lblHeader.Text = "هل تريد حذف بيانات الحضور لهذا الموظف";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DB.cmd.Parameters.AddWithValue("@empno", dgvShowPresence.CurrentRow.Cells[0].Value);
                    DB.Run("deletepresence");

                    GetEmpPresence();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelAllPresence_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfirmDel f = new FrmConfirmDel();

                f.lblHeader.Text = "هل تريد حذف جميع بيانات الحضور لكل الموظفين";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    f.lblHeader.Text = "للتأكيد اضغط موافق للالغاء اضغط لا ";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        DB.cmd.Parameters.Clear();
                        DB.Run("deleteallpresence");
                        GetEmpPresence();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAbsence_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            try
            {
                if (Validate_emp_addition()) return;

                if (PreventRepeat(tblGetEmpAbsence, "هذا الموظف مثبت غيابه بالفعل يمكنك التعديل على بيانات الغياب فقط"))return;

                DB.cmd.Parameters.AddWithValue("@empno", cbxEmpName.SelectedValue);
                DB.cmd.Parameters.AddWithValue("@abscencedate", dtpPresenceAbsenceDate.Value);
                DB.Run("addabsence");
                GetEmpAbsence();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditAbsence_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();

            try
            {
                if (dgvShowAbsence.CurrentRow != null)
                {
                    if (Validate_emp_addition()) return;

                    DB.cmd.Parameters.AddWithValue("@empno", dgvShowAbsence.CurrentRow.Cells[0].Value);
                    DB.cmd.Parameters.AddWithValue("@abscencedate", dtpPresenceAbsenceDate.Value);
                    DB.Run("editempabsence");

                    GetEmpAbsence();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelAbsence_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();

            try
            {
                if (dgvShowAbsence.CurrentRow != null)
                {
                    FrmConfirmDel f = new FrmConfirmDel();
                    f.lblHeader.Text = "هل تريد حذف بيانات غياب هذا الموظف ";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        DB.cmd.Parameters.AddWithValue("@empno", dgvShowAbsence.CurrentRow.Cells[0].Value);
                        DB.Run("deleteempabsence");

                        GetEmpAbsence();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelAllAbsence_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfirmDel f = new FrmConfirmDel();
                f.lblHeader.Text = "هل تريد حذف جميع بيانات غياب ابموظفين";
                if(f.ShowDialog()==DialogResult.OK)
                {
                    f.lblHeader.Text = "للتأكيد اضغط موافق للالغاء اضغط لا";
                    if(f.ShowDialog()==DialogResult.OK)
                    {
                        DB.cmd.Parameters.Clear();
                        DB.Run("deleteallempabsence");

                        GetEmpAbsence();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShowPresence_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowPresence.CurrentRow != null)
                {
                    cbxEmpName.Text = dgvShowPresence.CurrentRow.Cells["colempno"].Value.ToString();
                    dtpPresenceAbsenceDate.Value = (DateTime)dgvShowPresence.CurrentRow.Cells["colpresentdate"].Value;

                    dtpPresentTime.Value = Convert.ToDateTime(dgvShowPresence.CurrentRow.Cells["colpresenttime"].Value);

                    dtpGoingTime.Value = Convert.ToDateTime(dgvShowPresence.CurrentRow.Cells["colpresentgo"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShowVacancies_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvShowVacancies.CurrentRow!=null)
            {
                cbxEmpName.Text = dgvShowVacancies.CurrentRow.Cells["colempname"].Value.ToString();


                var r = from getvacancy in tblVacancyfromTable.AsEnumerable()
                        where getvacancy[0].ToString() == dgvShowVacancies.CurrentRow.Cells["colempnovacancy"].Value.ToString()
                        select getvacancy[1];

                for(int x=0;x<clbVacanciesDays.Items.Count;x++)
                {
                    clbVacanciesDays.SetItemChecked(x, false);
                }

                foreach (var i in r)
                {
                    if (i.ToString().Contains("السبت"))
                    {
                        clbVacanciesDays.SetItemChecked(0, true);
                    }
                    if (i.ToString().Contains("الأحد"))
                    {
                        clbVacanciesDays.SetItemChecked(1, true);
                    }
                    if (i.ToString().Contains("الاثنين"))
                    {
                        clbVacanciesDays.SetItemChecked(2, true);
                    }
                    if (i.ToString().Contains("الثلاثاء"))
                    {
                        clbVacanciesDays.SetItemChecked(3, true);
                    }
                    if (i.ToString().Contains("الأربعاء"))
                    {
                        clbVacanciesDays.SetItemChecked(4, true);
                    }
                    if (i.ToString().Contains("الخميس"))
                    {
                        clbVacanciesDays.SetItemChecked(5, true);
                    }
                    if (i.ToString().Contains("الجمعه"))
                    {
                        clbVacanciesDays.SetItemChecked(6, true);
                    }
                }
            }
        }

        private void btnAddVacancies_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();

            try
            {
                if ( Validate_emp_addition() ) return;

                if (PreventRepeat(tblGetEmpVacancy, "هذا الموظف مثبت أجازاته بالفعل يمكنك التعديل عليه فقط")) return;

                if(clbVacanciesDays.CheckedItems.Count < 1)
                {
                    DB.cmd.Parameters.AddWithValue("@empno", cbxEmpName.SelectedValue);

                    DB.cmd.Parameters.AddWithValue("@empvacancy", "");
                    DB.Run("addempvacancy");
                }

                for (int x = 0; x < clbVacanciesDays.CheckedItems.Count; x++)
                {
                    DB.cmd.Parameters.AddWithValue("@empno", cbxEmpName.SelectedValue);

                    DB.cmd.Parameters.AddWithValue("@empvacancy", clbVacanciesDays.CheckedItems[x].ToString());
                    DB.Run("addempvacancy");

                    DB.cmd.Parameters.Clear();

                }
                GetEmpvacany();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditVacancies_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();

            try
            {
                if (Validate_emp_addition()) return;


                if (dgvShowVacancies.CurrentRow != null)
                {
                    DB.cmd.Parameters.AddWithValue("@empno", dgvShowVacancies.CurrentRow.Cells["colempnovacancy"].Value);
                    DB.Run("deleteempvacancy");

                    DB.cmd.Parameters.Clear();


                    for (int x = 0; x < clbVacanciesDays.CheckedItems.Count; x++)
                    {

                        DB.cmd.Parameters.AddWithValue("@empno", dgvShowVacancies.CurrentRow.Cells["colempnovacancy"].Value);

                        DB.cmd.Parameters.AddWithValue("@empvacancy", clbVacanciesDays.CheckedItems[x].ToString());

                        DB.Run("editempvacancy");
                        DB.cmd.Parameters.Clear();
                    }

                    GetEmpvacany();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelVacancies_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();

            try
            {
                if (dgvShowVacancies.CurrentRow != null)
                {
                    FrmConfirmDel f = new FrmConfirmDel();
                    f.lblHeader.Text = "هل تريد حذف بيانات الأجازه الخاصه بهذا الموظف ";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        DB.cmd.Parameters.AddWithValue("@empno", dgvShowVacancies.CurrentRow.Cells["colempnovacancy"].Value);
                        DB.Run("deleteempvacancy");

                        GetEmpvacany();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelAllVacancies_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfirmDel f = new FrmConfirmDel();
                f.lblHeader.Text = "هل تريد حذف جميع بيانات الأجازات الخاصه بالموظفين";
                if(f.ShowDialog()==DialogResult.OK)
                {
                    f.lblHeader.Text = "للتأكيد اضغط نعم للالغاء اضغط لا";
                    if(f.ShowDialog()==DialogResult.OK)
                    {
                        DB.Run("deleteallempvacancy");
                        GetEmpvacany();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string strValid = "";
        private void cbxEmpName_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < cbxEmpName.Items.Count; i++)
            {
                if (!Regex.IsMatch(cbxEmpName.Items[i].ToString().Trim(),cbxEmpName.Text))
                {
                    cbxEmpName.Text = strValid;
                    break;
                }
            }
        }

        private void cbxEmpName_Click(object sender, EventArgs e)
        {
            strValid = cbxEmpName.Text;
        }

        private void cbxEmpName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbxEmpName.Items.Count > 0)
            {
                strValid = cbxEmpName.GetItemText(cbxEmpName.SelectedItem);
            }
        }

        private void cbxEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                strValid = cbxEmpName.GetItemText(cbxEmpName.SelectedItem);
            }
        }

        private void dgvShowAbsence_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowAbsence.CurrentRow != null)
                {
                    cbxEmpName.Text = dgvShowAbsence.CurrentRow.Cells[1].Value.ToString();
                    dtpPresenceAbsenceDate.Value = (DateTime)dgvShowAbsence.CurrentRow.Cells[2].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

