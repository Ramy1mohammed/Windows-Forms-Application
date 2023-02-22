using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Gym
{
    public partial class FrmMachine : Form
    {
        public FrmMachine()
        {
            InitializeComponent();
        }

        DataTable tblSupervisor = new DataTable();
        DataTable tblGetLcatedDept = new DataTable();
        private void GetSupervisor()
        {
            tblSupervisor.Rows.Clear();
            DB.GetData("select empno,empname from Gymemployee where jobtype='مشرف قسم'", tblSupervisor);
            cbxMachSupervision.DataSource = tblSupervisor;
            cbxMachSupervision.DisplayMember = tblSupervisor.Columns[1].ToString();
            cbxMachSupervision.ValueMember = tblSupervisor.Columns[0].ToString();

        }

        private void GetLocatedDept()
        {
            tblGetLcatedDept.Rows.Clear();
            DB.GetData("select deptno,deptname from Department ", tblGetLcatedDept);
            cbxMachLocation.DataSource = tblGetLcatedDept;
            cbxMachLocation.DisplayMember = tblGetLcatedDept.Columns[1].ToString();
            cbxMachLocation.ValueMember = tblGetLcatedDept.Columns[0].ToString();
        }
        DataTable tblGetLocationForMach = new DataTable();
        DataTable tblMAch = new DataTable();

        DataTable tblGetAll = new DataTable();
        DataTable tblGetSupervisor = new DataTable();
        private void GetMachineData()
        {
            tblMAch.Rows.Clear();
            tblGetLocationForMach.Rows.Clear();
            tblGetAll.Rows.Clear();
            tblGetSupervisor.Rows.Clear();

            DB.GetData("select * from GetLocation", tblGetLocationForMach);
            DB.GetData("select * from GetSupervisor", tblGetSupervisor);
            DB.GetData("select * from Machines", tblMAch);


            if (tblMAch.Rows.Count > 0)
            {
                if (tblGetAll.Columns.Count < 1)
                {
                    tblGetAll.Columns.Add("machno", typeof(int));
                    tblGetAll.Columns.Add("machname");
                    tblGetAll.Columns.Add("lastmaintain", typeof(DateTime));
                    tblGetAll.Columns.Add("maintainperiod", typeof(int));
                    tblGetAll.Columns.Add("nextmaintain", typeof(DateTime));
                    tblGetAll.Columns.Add("machprice", typeof(decimal));
                    tblGetAll.Columns.Add("machqty", typeof(int));
                    tblGetAll.Columns.Add("machsupervisormaintainor");
                    tblGetAll.Columns.Add("machlastsupervison", typeof(DateTime));
                    tblGetAll.Columns.Add("machperiodsupervision", typeof(int));
                    tblGetAll.Columns.Add("nextmachsupervision", typeof(DateTime));
                    tblGetAll.Columns.Add("machlocation");
                }
                for (int x = 0; x < tblMAch.Rows.Count; x++)
                {
                    DataRow row = tblGetAll.NewRow();
                    row[0] = tblMAch.Rows[x][0];
                    row[1] = tblMAch.Rows[x][1];
                    row[2] = tblMAch.Rows[x][2];
                    row[3] = tblMAch.Rows[x][3];
                    row[4] = tblMAch.Rows[x][4];
                    row[5] = tblMAch.Rows[x][5];
                    row[6] = tblMAch.Rows[x][6];

                    DataRow rowSupervisor = tblGetSupervisor.Rows[x];
                    row[7] = rowSupervisor[1];
                    row[8] = tblMAch.Rows[x][8];
                    row[9] = tblMAch.Rows[x][9];
                    row[10] = tblMAch.Rows[x][10];
                    DataRow[] rowLocation = tblGetLocationForMach.Select("machno=" + tblMAch.Rows[x][0]);
                    string strLocation = "";
                    foreach (DataRow i in rowLocation)
                    {
                        strLocation += i[1] + Environment.NewLine;
                    }
                    row[11] = strLocation;
                    tblGetAll.Rows.Add(row);
                }
                dgvShowMach.DataSource = tblGetAll;
            }
        }
        private void AutoMachNum()
        {
            Tools.ClearData(pnlMachine);

            string strAuto = "1";
            if (tblMAch.Rows.Count > 0)
            {
                int IntAuto = Convert.ToInt32(tblMAch.Compute("max(machno)", "")) + 1;
                strAuto = IntAuto.ToString();
                txtMachCode.Text = strAuto;
            }
            else
            {
                txtMachCode.Text = strAuto;
            }

            dtpLastMaintain.Value = DateTime.Now;
            dtpLastSupervision.Value = DateTime.Now;
            if (cbxMachSupervision.Items.Count > 0)
            {
                cbxMachSupervision.SelectedIndex = 0;
            }
            else cbxMachSupervision.Text = "";
            if (cbxMachLocation.Items.Count > 0)
            {
                cbxMachLocation.SelectedIndex = 0;
            }
            else cbxMachLocation.Text = "";

            EnablingBtn(false);
        }
        private void EnablingBtn(bool b = true)
        {
            btnAddMach.Enabled = !b;
            btnEditMach.Enabled = b;
            btnDeleteMach.Enabled = b;
            foreach (Control c in pnlMachine.Controls)
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

        private bool Validate_Mach()
        {
            bool Is_Valid = false;
            if (txtMachCode.Text.Trim() == "")
            {
                epMach.SetError(txtMachCode, "حدث مشكله فى كود الجهاز , برجاء التواصل مع مصمم البرنامج");
                Is_Valid = true;
            }
            else if (txtMachName.Text.Trim() == "")
            {
                epMach.SetError(txtMachName, "برجاء ادخال اسم الجهاز");
                Is_Valid = true;
            }
            else if (txtMaintainPeriod.Text.Trim() == "")
            {
                epMach.SetError(txtMaintainPeriod, "برجاء ادخال مده الصيانه اللامه للجهاز");
                Is_Valid = true;
            }
            else if (txtMachPrice.Text.Trim() == "")
            {
                epMach.SetError(txtMachPrice, "برجاء ادخال سعر الجهاز ولو بشكل وهمى");
                Is_Valid = true;
            }
            else if (txtMachQty.Text.Trim() == "")
            {
                epMach.SetError(txtMachQty, "برجاء ادخال الكميه المتاحه من الجهاز ولو بشكل وهمى");
                Is_Valid = true;
            }
            else if (cbxMachSupervision.Text.Trim() == "")
            {
                epMach.SetError(cbxMachSupervision, "برجاء اختيار المشرف على الجهاز من القائمه المتاحه");
                Is_Valid = true;
            }
            else if (txtSupervisionPeriod.Text.Trim() == "")
            {
                epMach.SetError(txtSupervisionPeriod, "برجاء ادخال مده الاشراف اللازمه للاشراف على الجهاز ولو بشكل وهمى");
                Is_Valid = true;
            }
            else if (cbxMachLocation.Text.Trim() == "")
            {
                epMach.SetError(cbxMachLocation, "برجاء اختيار القسم المتواجد به الجهاز بالختيار من القائمه المتاحه");
                Is_Valid = true;
            }
            if (cbxMachSupervision.Items.Count < 1)
            {
                epMach.SetError(cbxMachSupervision, "برجاء التوجه الى قسم اداره الموظفين واضافه موظفين بتخصص مشرف قسم");
                Is_Valid = true;
            }
            if (cbxMachLocation.Items.Count < 1)
            {
                epMach.SetError(cbxMachLocation, "برجاء التوجه الى اداره الاقسام واضافه اقسام حسب المطلوب");
                Is_Valid = true;
            }
            return Is_Valid;
        }

        private void FrmMachine_Load(object sender, EventArgs e)
        {
            GetMachineData();
            AutoMachNum();
            DB.cmd.CommandType = CommandType.Text;
            this.Activated += delegate
            {
                DB.cmd.CommandType = CommandType.Text;
                GetMachineData();
                AutoMachNum();
                GetSupervisor();
                GetLocatedDept();
                CalculateMantainPeriod();
                CalculateSupervisionPeriod();
            };
        }

        private void btnNewMach_Click(object sender, EventArgs e)
        {
            AutoMachNum();
        }

        private void dgvShowMach_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowMach.CurrentRow != null)
                {
                    txtMachCode.Text = dgvShowMach.CurrentRow.Cells["colmachno"].Value.ToString();
                    txtMachName.Text = dgvShowMach.CurrentRow.Cells["colMachName"].Value.ToString();
                    dtpLastMaintain.Value = (DateTime)dgvShowMach.CurrentRow.Cells["colLastMaintain"].Value;
                    txtMaintainPeriod.Text = dgvShowMach.CurrentRow.Cells["colMaintainPeriod"].Value.ToString();
                    dtpNextMaintain.Value = (DateTime)dgvShowMach.CurrentRow.Cells["colNextMaintain"].Value;
                    txtMachPrice.Text = dgvShowMach.CurrentRow.Cells["colMachPrice"].Value.ToString();
                    txtMachQty.Text = dgvShowMach.CurrentRow.Cells["colMachQty"].Value.ToString();
                    cbxMachSupervision.Text = dgvShowMach.CurrentRow.Cells["ColMachSupervisor"].Value.ToString();
                    dtpLastSupervision.Value = (DateTime)dgvShowMach.CurrentRow.Cells["colLastSupervision"].Value;
                    txtSupervisionPeriod.Text = dgvShowMach.CurrentRow.Cells["colSupervisionPeriod"].Value.ToString();
                    dtpNextSupervision.Value = (DateTime)dgvShowMach.CurrentRow.Cells["colNextSupervision"].Value;
                    cbxMachLocation.Text = dgvShowMach.CurrentRow.Cells["colMachLocation"].Value.ToString();
                    EnablingBtn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAddMach_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            DB.cmd.Parameters.Clear();
            try
            {
                if (Validate_Mach()) return;
                epMach.Clear();
                //var r = from getMachNames in tblGetAll.AsEnumerable()
                //        where getMachNames[1].ToString() == txtMachName.Text
                //        select getMachNames[1];
                //foreach (var i in r)
                //{
                //    if (i.ToString() == txtMachName.Text.Trim())
                //    {
                //        FrmConfirmDel frm = new FrmConfirmDel();
                //        frm.lblHeader.Font = new Font(this.Font.FontFamily, 12);
                //        frm.lblHeader.Text = "بيانات هذا الجهاز موجوده بالفعل يمكنك التعديل على هذه البيانات";
                //        frm.btnNo.Visible = false;
                //        frm.btnYes.Text = "موافق";
                //        frm.btnYes.Left = (frm.Width - frm.btnYes.Width) / 2;
                //        frm.ShowDialog();
                //        return;
                //    }
                //}

                DB.cmd.Parameters.AddWithValue("@lastmaintaindate", dtpLastMaintain.Value);
                DB.cmd.Parameters.AddWithValue("@nextmaintaindate", dtpNextMaintain.Value);
                DB.cmd.Parameters.AddWithValue("@machlastsupervision", dtpLastSupervision.Value);
                DB.cmd.Parameters.AddWithValue("@nextmachsupervision", dtpNextSupervision.Value);
                DB.Run("insert into Machines values(" + txtMachCode.Text + ",'" + txtMachName.Text + "',@lastmaintaindate," + txtMaintainPeriod.Text + ",@nextmaintaindate," + txtMachPrice.Text + "," + txtMachQty.Text + "," + cbxMachSupervision.SelectedValue + ",@machlastsupervision," + txtSupervisionPeriod.Text + ",@nextmachsupervision)");
                DB.Run("insert into MachineLocation values(" + txtMachCode.Text + "," + cbxMachLocation.SelectedValue + ")");
                GetMachineData();
                dgvShowMach.CurrentCell = dgvShowMach.Rows[dgvShowMach.Rows.Count - 1].Cells[0];
                lblMsg.Text += "تم اضافه البيانات الخاصه بالجهاز ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalculateMantainPeriod()
        {
            if (txtMaintainPeriod.Text.Trim() != "")
            {
                dtpNextMaintain.Value = dtpLastMaintain.Value.AddDays(Convert.ToDouble(txtMaintainPeriod.Text));
            }
        }

        private void dtpLastMaintain_ValueChanged(object sender, EventArgs e)
        {
            CalculateMantainPeriod();
        }

        private void txtMaintainPeriod_TextChanged(object sender, EventArgs e)
        {
            CalculateMantainPeriod();
        }

        private void CalculateSupervisionPeriod()
        {
            if (txtSupervisionPeriod.Text.Trim() != "")
            {
                dtpNextSupervision.Value = dtpLastSupervision.Value.AddDays(Convert.ToDouble(txtSupervisionPeriod.Text));
            }
        }
        private void dtpLastSupervision_ValueChanged(object sender, EventArgs e)
        {
            CalculateSupervisionPeriod();
        }

        private void txtSupervisionPeriod_TextChanged(object sender, EventArgs e)
        {
            CalculateSupervisionPeriod();
        }

        private void btnEditMach_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            DB.cmd.Parameters.Clear();
            try
            {
                if (dgvShowMach.CurrentRow != null)
                {
                    if (Validate_Mach()) return;
                    epMach.Clear();
                    DB.cmd.Parameters.AddWithValue("@lastmaintaindate", dtpLastMaintain.Value);
                    DB.cmd.Parameters.AddWithValue("@nextmaintaindate", dtpNextMaintain.Value);
                    DB.cmd.Parameters.AddWithValue("@machlastsupervision", dtpLastSupervision.Value);
                    DB.cmd.Parameters.AddWithValue("@nextmachsupervision", dtpNextSupervision.Value);
                    DB.Run("update Machines set machname='" + txtMachName.Text + "',lastmaintain=@lastmaintaindate,maintainperiod=" + txtMaintainPeriod.Text + ",nextmaintain=@nextmaintaindate,machprice=" + txtMachPrice.Text + ",machqty=" + txtMachQty.Text + ",machsupervisormaintainor=" + cbxMachSupervision.SelectedValue + ",machlastsupervison=@machlastsupervision,machperiodsupervision=" + txtSupervisionPeriod.Text + ",nextmachsupervision=@nextmachsupervision where machno=" + dgvShowMach.CurrentRow.Cells["colmachno"].Value + "");
                    DB.Run("update MachineLocation set deptno=" + cbxMachLocation.SelectedValue + " where machno=" + dgvShowMach.CurrentRow.Cells["colmachno"].Value);
                    GetMachineData();
                    lblMsg.Text += "تم التعديل على بيانات الجهاز ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteMach_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            try
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف البيانات الخاصه بهذا الجهاز ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (dgvShowMach.CurrentRow != null)
                    {
                        DB.Run("delete from MachineLocation where machno=" + dgvShowMach.CurrentRow.Cells["colmachno"].Value);
                        DB.Run("delete from Machines where machno=" + dgvShowMach.CurrentRow.Cells["colmachno"].Value);
                        GetMachineData();
                        lblMsg.Text += "تم حذف البيانات الخاصه بالجهاز ";
                        AutoMachNum();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMachine_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
        }

        private void txtMachName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space) e.Handled = true;
        }

        private void txtMaintainPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtMachPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (txtMachPrice.Text.Contains("."))
            {
                if (e.KeyChar == '.') e.Handled = true;
            }

        }
       private string strValidated = "";
        private void cbxMachSupervision_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).Items.Count > 0)
            {
                for (int x = 0; x < ((ComboBox)sender).Items.Count; x++)
                {
                    if (!Regex.IsMatch(((ComboBox)sender).Items[x].ToString().Trim(), ((ComboBox)sender).Text))
                    {
                        ((ComboBox)sender).Text = strValidated;
                        break;
                    }
                }
            }

        }

        private void cbxMachSupervision_Click(object sender, EventArgs e)
        {
            strValidated = ((ComboBox)sender).Text;
        }

        private void cbxMachSupervision_SelectionChangeCommitted(object sender, EventArgs e)
        {
            strValidated = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }

        private void cbxMachSupervision_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
                strValidated = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }
    }
}
