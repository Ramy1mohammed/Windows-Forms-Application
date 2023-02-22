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
    public partial class FrmRegieme : Form
    {
        public FrmRegieme()
        {
            InitializeComponent();
        }

        private void tcRegieme_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            // //TabPage page = tcRegieme.TabPages[e.Index];
            //// Color col = e.Index == 0 ? Color.Aqua : Color.Yellow;
            // e.Graphics.FillRectangle(Brushes.Black, e.Bounds.Left,e.Bounds.Top,e.Bounds.Width+200,e.Bounds.Height);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            foreach (TabPage tp in tcRegieme.TabPages)
            {
                TextRenderer.DrawText(e.Graphics, tp.Text, Font, paddedBounds, Color.Yellow);
            }
            // e.DrawBackground();
        }

        DataTable tblGetBodyBuliding = new DataTable();
        DataTable tbljoined = new DataTable();
        private void SelectTraineeBodyBuilding()
        {
            tblGetBodyBuliding.Rows.Clear();
            DB.GetData("select trno,trname from Trainee where exercisetype='تمرين كمال أجسام'", tblGetBodyBuliding);

            cbxBuildingTrName.DataSource = tblGetBodyBuliding;
            cbxBuildingTrName.DisplayMember = tblGetBodyBuliding.Columns[1].ToString();
            cbxBuildingTrName.ValueMember = tblGetBodyBuliding.Columns[0].ToString();
        }
        DataTable tblGetBuildingInfo = new DataTable();
        private void SelectTrainingInformation()
        {
            tblGetBuildingInfo.Rows.Clear();
            DB.GetData("select trainingno,trainingname,trainingimage from TrainingMap where trainingcategory='تمرين كمال أجسام'", tblGetBuildingInfo);
            dgvBuildingShowTrainingInfo.DataSource = tblGetBuildingInfo;
            dgvBuildingShowTrainingInfo.Columns[0].Visible = false;
        }
        public static DataTable tblGetTrainingDays = new DataTable();
        DataTable tblGetTraining = new DataTable();
        public static DataTable tblGetExercisesNames = new DataTable();
        public static DataTable tblGetAdvices = new DataTable();
        public static DataTable tblGetNotes = new DataTable();
        DataTable tblAll = new DataTable();

        private void SelectTrainingNamesAndDays(DataGridView dgv)
        {
            tblGetTrainingDays.Rows.Clear();
            tblGetTraining.Rows.Clear();
            tblGetExercisesNames.Rows.Clear();
            tblGetAdvices.Rows.Clear();
            tblGetNotes.Rows.Clear();
            tblAll.Rows.Clear();

            DB.GetData("select * from BodyBuildingOnly", tblGetTraining);
            DB.GetData("select * from Get_Days", tblGetTrainingDays);
            DB.GetData("select * from TrainingNames", tblGetExercisesNames);
            DB.GetData("select * from TraineeCoachAdvices", tblGetAdvices);
            DB.GetData("select * from TraineeNotes", tblGetNotes);

            if (tblGetTraining.Rows.Count > 0)
            {
                if (tblAll.Columns.Count < 1)
                {
                    tblAll.Columns.Add("trno", typeof(int));
                    tblAll.Columns.Add("trainingname");
                    tblAll.Columns.Add("traininghours", typeof(int));
                    tblAll.Columns.Add("trainingdays");
                    tblAll.Columns.Add("exercisesnames");
                    tblAll.Columns.Add("TraineeAdvices");
                    tblAll.Columns.Add("TraineeNotes");
                }
                for (int x = 0; x < tblGetTraining.Rows.Count; x++)
                {
                    DataRow row = tblAll.NewRow();
                    row[0] = tblGetTraining.Rows[x][0];
                    row[1] = tblGetTraining.Rows[x][1];
                    row[2] = tblGetTraining.Rows[x][2];

                    DataRow[] RowsDaysFiltered = tblGetTrainingDays.Select("trno=" + tblGetTraining.Rows[x][0]);
                    string strDays = "";
                    foreach (DataRow r in RowsDaysFiltered)
                    {
                        strDays += r[1] + Environment.NewLine;
                    }
                    row[3] = strDays;

                    DataRow[] RowsGetExercisesNames = tblGetExercisesNames.Select("trno=" + tblGetTraining.Rows[x][0]);
                    string strGetExercisesNames = "";
                    foreach (DataRow i in RowsGetExercisesNames)
                    {
                        strGetExercisesNames += i[1] + Environment.NewLine;
                    }
                    row[4] = strGetExercisesNames;

                    DataRow[] RowsGetTraineeAdvices = tblGetAdvices.Select("trno=" + tblGetTraining.Rows[x][0]);
                    string strGetAdvices = "";
                    foreach (DataRow i in RowsGetTraineeAdvices)
                    {
                        strGetAdvices += i[1] + Environment.NewLine;
                    }
                    row[5] = strGetAdvices;

                    DataRow[] RowsGetTrineeNotes = tblGetNotes.Select("trno=" + tblGetTraining.Rows[x][0]);
                    string strGetNotes = "";
                    foreach (DataRow i in RowsGetTrineeNotes)
                    {
                        strGetNotes += i[1] + Environment.NewLine;
                    }
                    row[6] = strGetNotes;

                    tblAll.Rows.Add(row);
                    dgvShowBuildingInfo.DataSource = tblAll;
                }
            }
        }

        private void DeleteItemsFromlbx(ListBox lbx, int index)
        {
            if (index == 0)
            {
                while (lbx.SelectedItems.Count > 0)
                {
                    lbx.Items.Remove(lbx.SelectedItems[0]);
                }

            }
            else if (index == 1)
            {
                if (lbx.Items.Count > 0)
                {
                    lbx.Items.RemoveAt(lbx.Items.Count - 1);
                }
            }
            else if (index == 2)
            {
                lbx.Items.Clear();
            }
        }

        private bool Making_Validation(ComboBox cbx, NumericUpDown nud, DataGridView dgv, ListBox lbxExercise, ListBox lbxAdvices, ListBox lbxNotes)
        {
            bool IsValid = false;
            if (cbx.Items.Count < 1)
            {
                epRegeime.SetError(cbx, "يمكنك التوجه لاداره المشتركين لاضافه مشتركين من نفس نوع التمرين ");
                IsValid = true;
            }
            else if (cbx.Text.Trim() == "")
            {
                epRegeime.SetError(cbx, "الرجاء الاختيار من القائمه الحاليه ");
                IsValid = true;
            }
            else if (nud.Value.ToString() == "")
            {
                epRegeime.SetError(nud, "الرجاء اختيار عدد ساعات التدريب ");
                IsValid = true;
            }
            else if (dgv.Rows.Count < 1)
            {
                epRegeime.SetError(dgv, "يمكنك التوجه  لاداره الخطط التدريبيه أولا واضافه تمارين من نفس النوع ");
                IsValid = true;
            }
            else if (lbxExercise.Items.Count < 1)
            {
                epRegeime.SetError(lbxExercise, "الرجاء اضافه تمارين من القائمه السابقه بالظغط المزدوج على التمرين");
                IsValid = true;
            }
            if (lbxAdvices.Items.Count < 1)
            {
                lbxAdvices.Items.Clear();
                lbxAdvices.Items.Add("بدون نصائح");
            }

            if (lbxNotes.Items.Count < 1)
            {
                lbxNotes.Items.Clear();
                lbxNotes.Items.Add("بدون ملاحظات");
            }
            return IsValid;
        }
        private void FrmRegieme_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            DB.cmd.CommandType = CommandType.Text;

            this.Activated += delegate
            {
                DB.cmd.CommandType = CommandType.Text;

                //BodyBuilding
                SelectTrainingInformation();
                SelectTraineeBodyBuilding();
                SelectTrainingNamesAndDays(new DataGridView());

                //Boxing
                DataForBoxing.GetBoxingTrainee(cbxBoxingTrName);
                DataForBoxing.GetBoxingExercises(dgvBoxingShowTrainingInfo);
                DataForBoxing.GetBoxingData(dgvShowBoxingInfo);

                //Massage
                DataForMass.GetMassageTrainee(cbxMassTrName);
                DataForMass.GetMassExercise(dgvMassShowTrainingInfo);
                DataForMass.GetMassData(dgvShowMassInfo);

                //Fitness
                DataForFitness.GetFitnessTrainee(cbxFitnessTrName);
                DataForFitness.GetFitnessExercise(dgvFitnessShowTrainingInfo);
                DataForFitness.GetFitnessData(dgvShowFitnessInfo);

                //Ayrobics
                DataForAyr.GetAyrTrainee(cbxAyrTrName);
                DataForAyr.GetAyrExercise(dgvAyrShowTrainingInfo);
                DataForAyr.GetAyrData(dgvShowAyrInfo);

                //Zomba
                DataForZomba.GetZombaTrainee(cbxZombaTrName);
                DataForZomba.GetZombaExercise(dgvZombaShowTrainingInfo);
                DataForZomba.GetZombaData(dgvShowZombaInfo);

                //OtherSp
                DataForOtherSp.GetOtherSpTrainee(cbxOtherSpTrName);
                DataForOtherSp.GetOtherSpExercise(dgvOtherSpShowTrainingInfo);
                DataForOtherSp.GetOtherSpData(dgvShowOtherSpInfo);

            };

            SelectTrainingInformation();
            SelectTraineeBodyBuilding();
            SelectTrainingNamesAndDays(new DataGridView());
        }

        private void dgvShowBuildingInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowBuildingInfo.CurrentRow != null)
                {
                    cbxBuildingTrName.Text = dgvShowBuildingInfo.CurrentRow.Cells["coltrainingname"].Value.ToString();
                    nudBuildingTrHours.Value = Convert.ToInt32(dgvShowBuildingInfo.CurrentRow.Cells["coltraininghours"].Value);
                    var r = from getDays in tblAll.AsEnumerable()
                            where getDays[0].ToString() == dgvShowBuildingInfo.CurrentRow.Cells["coltrno"].Value.ToString()
                            select
                            getDays[3]
                            ;
                    for (int x = 0; x < ClbxBuildingExercisesDays.Items.Count; x++)
                    {
                        ClbxBuildingExercisesDays.SetItemChecked(x, false);
                    }

                    foreach (var i in r)
                    {
                        if (i.ToString().Contains("السبت"))
                        {
                            ClbxBuildingExercisesDays.SetItemChecked(0, true);
                        }
                        if (i.ToString().Contains("الأحد"))
                        {
                            ClbxBuildingExercisesDays.SetItemChecked(1, true);
                        }
                        if (i.ToString().Contains("الاثنين"))
                        {
                            ClbxBuildingExercisesDays.SetItemChecked(2, true);
                        }
                        if (i.ToString().Contains("الثلاثاء"))
                        {
                            ClbxBuildingExercisesDays.SetItemChecked(3, true);
                        }
                        if (i.ToString().Contains("الأربعاء"))
                        {
                            ClbxBuildingExercisesDays.SetItemChecked(4, true);
                        }
                        if (i.ToString().Contains("الخميس"))
                        {
                            ClbxBuildingExercisesDays.SetItemChecked(5, true);
                        }
                        if (i.ToString().Contains("الجمعه"))
                        {
                            ClbxBuildingExercisesDays.SetItemChecked(6, true);
                        }
                    }

                    var v1 = from getEXNames in tblGetExercisesNames.AsEnumerable()
                             where getEXNames[0].ToString() == dgvShowBuildingInfo.CurrentRow.Cells["coltrno"].Value.ToString()
                             select getEXNames[1];
                    lbxBuildingChoosenExercises.Items.Clear();
                    foreach (var i in v1)
                    {
                        lbxBuildingChoosenExercises.Items.Add(i.ToString());
                    }

                    var v2 = from getAdvices in tblGetAdvices.AsEnumerable()
                             where getAdvices[0].ToString() == dgvShowBuildingInfo.CurrentRow.Cells["coltrno"].Value.ToString()
                             select getAdvices[1];
                    lbxBuildingAdvices.Items.Clear();
                    foreach (var i in v2)
                    {
                        lbxBuildingAdvices.Items.Add(i.ToString());
                    }

                    var v3 = from getNotes in tblGetNotes.AsEnumerable()
                             where getNotes[0].ToString() == dgvShowBuildingInfo.CurrentRow.Cells["coltrno"].Value.ToString()
                             select getNotes[1];
                    lbxBuildingCoachNotes.Items.Clear();
                    foreach (var i in v3)
                    {
                        lbxBuildingCoachNotes.Items.Add(i.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void ChoosingExercisesFromDgv(DataGridView dgv, ListBox lbxExercises)
        {
            string strMatched = "";
            if (dgv.CurrentRow != null)
            {
                strMatched = dgv.CurrentRow.Cells[1].Value.ToString();
                for (int x = 0; x < lbxExercises.Items.Count; x++)
                {
                    if (Regex.IsMatch(lbxExercises.Items[x].ToString(), strMatched))
                    {
                        return;
                    }
                }
                lbxExercises.Items.Add(dgv.CurrentRow.Cells[1].Value.ToString());
            }
        }
        private void dgvBuildingShowTrainingInfo_DoubleClick(object sender, EventArgs e)
        {
            ChoosingExercisesFromDgv(dgvBuildingShowTrainingInfo, lbxBuildingChoosenExercises);
        }

        private void btnDelBuildingAllAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingAdvices, 2);
        }

        private void btnDelBuildingSelectedAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingAdvices, 0);
        }

        private void btnDelBuildingLastItemAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingAdvices, 1);
        }

        private void btnDelBuildingAllNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingCoachNotes, 2);
        }

        private void btnDelBuildingLastItemNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingCoachNotes, 1);
        }

        private void btnDelBuildingSelectedNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingCoachNotes, 0);
        }


        private void AddNotesAndAdvices(TextBox txtFeatures, ListBox lbx)
        {
            if (txtFeatures.Text.Trim() != "")
            {
                lbx.Items.Add(txtFeatures.Text);
                string[] strItems = new string[lbx.Items.Count];
                for (int x = 0; x < lbx.Items.Count; x++)
                {
                    strItems[x] = lbx.Items[x].ToString();
                }
                string[] strWithoutRepeat = strItems.Distinct().ToArray<string>();
                lbx.Items.Clear();
                lbx.Items.AddRange(strWithoutRepeat);
                txtFeatures.Clear();
            }
        }

        private void btnAddBuildingAdvices_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtBuildingAdvices, lbxBuildingAdvices);
        }

        private void btnAddBuildingCoachNotes_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtBuildingCoachNotes, lbxBuildingCoachNotes);
        }


        private void ClearDataForNew(ComboBox cbx, NumericUpDown nud, TextBox txtAdvices, ListBox lbxExercises, ListBox lbxAdvices, CheckedListBox clb, TextBox txtNotes, ListBox lbxNotes, DataGridView dgv)
        {
            dgv.ClearSelection();
            if (cbx.Items.Count > 0)
            {
                cbx.SelectedIndex = 0;
            }
            else cbx.Text = "";

            nud.Value = 1;

            txtAdvices.Clear();
            lbxExercises.Items.Clear();
            lbxAdvices.Items.Clear();
            for (int x = 0; x < clb.Items.Count; x++)
            {
                clb.SetItemChecked(x, false);
            }
            txtNotes.Clear();
            lbxNotes.Items.Clear();

        }

        private void btnNewBuilding_Click(object sender, EventArgs e)
        {
            ClearDataForNew(cbxBuildingTrName, nudBuildingTrHours, txtBuildingAdvices, lbxBuildingChoosenExercises, lbxBuildingAdvices, ClbxBuildingExercisesDays, txtBuildingCoachNotes, lbxBuildingCoachNotes, dgvShowBuildingInfo);
        }

        private delegate void Cast_Sel_Data(DataGridView dgv);
        private void Inserting_Data(DataTable tblAll, ComboBox cbx, NumericUpDown nud, ListBox lbxExercise, CheckedListBox clbDays, ListBox lbxAdvices, ListBox lbxNotes, DataGridView dgv, Cast_Sel_Data data, bool IsBuilding = false)
        {
            lblMsg.Text = ">> ";
            try
            {
                var r = from trno in tblAll.AsEnumerable()
                        select new
                        {
                            trnorow = trno[0]
                        };
                FrmConfirmDel f = new FrmConfirmDel();
                foreach (var i in r)
                {
                    if (cbx.SelectedValue.ToString() == i.trnorow.ToString())
                    {
                        f.lblHeader.Text = "البرنامج التدريبى لهذا المشترك موجود بالفعل";
                        f.btnYes.Left = (f.Width - f.btnYes.Width) / 2;
                        f.btnYes.Text = "موافق";
                        f.btnNo.Visible = false;
                        f.ShowDialog();
                        return;
                    }
                }

                DB.cmd.Parameters.Clear();
                DB.cmd.Parameters.AddWithValue("@traininghours", nud.Value);

                DB.Run("insert into TrainingRegieme values(" + cbx.SelectedValue + ",@traininghours)");

                for (int x = 0; x < lbxExercise.Items.Count; x++)
                {
                    DB.Run("insert into TrainingNames values(" + cbx.SelectedValue + ",'" + lbxExercise.GetItemText(lbxExercise.Items[x]) + "')");
                }

                for (int x = 0; x < clbDays.CheckedItems.Count; x++)
                {
                    DB.Run("insert into TrainingDays values(" + cbx.SelectedValue + ",'" + clbDays.CheckedItems[x] + "')");
                }

                for (int x = 0; x < lbxAdvices.Items.Count; x++)
                {
                    DB.Run("insert into TraineeCoachAdvices values(" + cbx.SelectedValue + ",'" + lbxAdvices.GetItemText(lbxAdvices.Items[x]) + "')");
                }

                for (int x = 0; x < lbxNotes.Items.Count; x++)
                {
                    DB.Run("insert into TraineeNotes values(" + cbx.SelectedValue + ",'" + lbxNotes.GetItemText(lbxNotes.Items[x]) + "')");
                }
                if (IsBuilding)
                    SelectTrainingNamesAndDays(new DataGridView());
                data(dgv);
                lblMsg.Text += "تم اضافه البرنامج التدريبى لهذا المشترك ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxBuildingTrName, nudBuildingTrHours, dgvBuildingShowTrainingInfo, lbxBuildingChoosenExercises, lbxBuildingAdvices, lbxBuildingCoachNotes)) return;
            epRegeime.Clear();
            Inserting_Data(tblAll, cbxBuildingTrName, nudBuildingTrHours, lbxBuildingChoosenExercises, ClbxBuildingExercisesDays, lbxBuildingAdvices, lbxBuildingCoachNotes, new DataGridView(), SelectTrainingNamesAndDays);
        }

        private void btnDelBuildingSelectedChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingChoosenExercises, 0);

        }

        private void btnDelBuildingLastItemChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingChoosenExercises, 1);
        }

        private void btnDelBuildingAllChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBuildingChoosenExercises, 2);
        }

        private delegate void EditingDel(DataGridView dgv);
        private void Editing_Data(DataGridView dgv, NumericUpDown nud, ListBox lbxExercises, CheckedListBox clbDays, ListBox lbxAdvices, ListBox lbxNotes, EditingDel showEdited, DataGridView dgvCasting, bool IsBuilding = false)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (dgv.CurrentRow != null)
                {
                    DB.cmd.Parameters.Clear();
                    DB.cmd.Parameters.AddWithValue("@traininghours", nud.Value);
                    DB.Run("update TrainingRegieme set traininghours=@traininghours where trno=" + dgv.CurrentRow.Cells[0].Value);

                    DB.Run("delete from TrainingNames where trno=" + dgv.CurrentRow.Cells[0].Value);
                    for (int x = 0; x < lbxExercises.Items.Count; x++)
                    {
                        DB.Run("insert into TrainingNames values(" + dgv.CurrentRow.Cells[0].Value + ",'" + lbxExercises.GetItemText(lbxExercises.Items[x]) + "')");
                    }

                    DB.Run("delete from TrainingDays where trno=" + dgv.CurrentRow.Cells[0].Value);
                    for (int x = 0; x < clbDays.CheckedItems.Count; x++)
                    {
                        DB.Run("insert into TrainingDays values(" + dgv.CurrentRow.Cells[0].Value + ",'" + clbDays.CheckedItems[x] + "')");
                    }

                    DB.Run("delete from TraineeCoachAdvices where trno=" + dgv.CurrentRow.Cells[0].Value);
                    for (int x = 0; x < lbxAdvices.Items.Count; x++)
                    {
                        DB.Run("insert into TraineeCoachAdvices values(" + dgv.CurrentRow.Cells[0].Value + ",'" + lbxAdvices.GetItemText(lbxAdvices.Items[x]) + "')");
                    }

                    DB.Run("delete from TraineeNotes where trno=" + dgv.CurrentRow.Cells[0].Value);

                    for (int x = 0; x < lbxNotes.Items.Count; x++)
                    {
                        DB.Run("insert into TraineeNotes values(" + dgv.CurrentRow.Cells[0].Value + ",'" + lbxNotes.GetItemText(lbxNotes.Items[x]) + "')");
                    }

                    if (IsBuilding)
                        SelectTrainingNamesAndDays(new DataGridView());

                    showEdited(dgvCasting);
                    lblMsg.Text += "تم التعديل على البرنامج بنجاح";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEditBuilding_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxBuildingTrName, nudBuildingTrHours, dgvBuildingShowTrainingInfo, lbxBuildingChoosenExercises, lbxBuildingAdvices, lbxBuildingCoachNotes)) return;
            epRegeime.Clear();
            Editing_Data(dgvShowBuildingInfo, nudBuildingTrHours, lbxBuildingChoosenExercises, ClbxBuildingExercisesDays, lbxBuildingAdvices, lbxBuildingCoachNotes, SelectTrainingNamesAndDays, new DataGridView());
        }

        private delegate void DeletingDel(DataGridView dgv);
        private void Deleting_Data(DataGridView dgv, DeletingDel ShowAfterDel, DataGridView dgvCasting, bool IsBuilding = false)
        {
            lblMsg.Text = ">> ";
            try
            {
                if (dgv.CurrentRow != null)
                {
                    DB.Run("delete from TrainingRegieme where trno=" + dgv.CurrentRow.Cells[0].Value);
                    DB.Run("delete from TrainingNames where trno=" + dgv.CurrentRow.Cells[0].Value);
                    DB.Run("delete from TrainingDays where trno=" + dgv.CurrentRow.Cells[0].Value);
                    DB.Run("delete from TraineeCoachAdvices where trno=" + dgv.CurrentRow.Cells[0].Value);
                    DB.Run("delete from TraineeNotes where trno=" + dgv.CurrentRow.Cells[0].Value);

                    if (IsBuilding)
                        SelectTrainingNamesAndDays(new DataGridView());
                    ShowAfterDel(dgvCasting);
                    lblMsg.Text += "تم حذف البرنامج التدريبى للمشترك ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteBuilding_Click(object sender, EventArgs e)
        {
            if (dgvShowBuildingInfo.Rows.Count > 0)
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف النظام التدريبى لهذا المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Deleting_Data(dgvShowBuildingInfo, SelectTrainingNamesAndDays, new DataGridView());
                    btnNewBuilding.PerformClick();
                }
            }
        }

        private void tcRegieme_Selecting(object sender, TabControlCancelEventArgs e)
        {
            lblMsg.Text = ">> ";
            if (e.TabPage == tcRegieme.TabPages["tpBuildingTrainee"])
            {
                DB.cmd.CommandType = CommandType.Text;
                SelectTraineeBodyBuilding();
                SelectTrainingInformation();
                SelectTrainingNamesAndDays(new DataGridView());
                ClearDataForNew(cbxBuildingTrName, nudBuildingTrHours, txtBuildingAdvices, lbxBuildingChoosenExercises, lbxBuildingAdvices, ClbxBuildingExercisesDays, txtBuildingCoachNotes, lbxBuildingCoachNotes, dgvShowBuildingInfo);
                tcRegieme.TabPages["tpBuildingTrainee"].Controls.Add(lblMsg);
            }
            else if (e.TabPage == tcRegieme.TabPages["tpBoxingTrainee"])
            {
                DataForBoxing.GetBoxingTrainee(cbxBoxingTrName);
                DataForBoxing.GetBoxingExercises(dgvBoxingShowTrainingInfo);
                DataForBoxing.GetBoxingData(dgvShowBoxingInfo);

                ClearDataForNew(cbxBoxingTrName, nudBoxingTrHours, txtBoxingAdvices, lbxBoxingChoosenExercises, lbxBoxingAdvices, ClbxBoxingExercisesDays, txtBoxingCoachNotes, lbxBoxingCoachNotes, dgvShowBoxingInfo);
                tcRegieme.TabPages["tpBoxingTrainee"].Controls.Add(lblMsg);
            }
            else if (e.TabPage == tcRegieme.TabPages["tpMassageTrainee"])
            {
                DataForMass.GetMassageTrainee(cbxMassTrName);
                DataForMass.GetMassExercise(dgvMassShowTrainingInfo);
                DataForMass.GetMassData(dgvShowMassInfo);
                ClearDataForNew(cbxMassTrName, nudMassTrHours, txtMassAdvices, lbxMassChoosenExercises, lbxMassAdvices, ClbxMassExercisesDays, txtMassCoachNotes, lbxMassCoachNotes, dgvShowMassInfo);
                tcRegieme.TabPages["tpMassageTrainee"].Controls.Add(lblMsg);
            }
            else if (e.TabPage == tcRegieme.TabPages["tpFitnessTrainee"])
            {
                DataForFitness.GetFitnessTrainee(cbxFitnessTrName);
                DataForFitness.GetFitnessExercise(dgvFitnessShowTrainingInfo);
                DataForFitness.GetFitnessData(dgvShowFitnessInfo);

                ClearDataForNew(cbxFitnessTrName, nudFitnessTrHours, txtFitnessAdvices, lbxFitnessChoosenExercises, lbxFitnessAdvices, ClbxFitnessExercisesDays, txtFitnessCoachNotes, lbxFitnessCoachNotes, dgvShowFitnessInfo);
                tcRegieme.TabPages["tpFitnessTrainee"].Controls.Add(lblMsg);
            }
            else if (e.TabPage == tcRegieme.TabPages["tbAyrobicsTrainee"])
            {
                DataForAyr.GetAyrTrainee(cbxAyrTrName);
                DataForAyr.GetAyrExercise(dgvAyrShowTrainingInfo);
                DataForAyr.GetAyrData(dgvShowAyrInfo);

                ClearDataForNew(cbxAyrTrName, nudAyrTrHours, txtAyrAdvices, lbxAyrChoosenExercises, lbxAyrAdvices, ClbxAyrExercisesDays, txtAyrCoachNotes, lbxAyrCoachNotes, dgvShowAyrInfo);
                tcRegieme.TabPages["tbAyrobicsTrainee"].Controls.Add(lblMsg);
            }
            else if (e.TabPage == tcRegieme.TabPages["tpZombaTrainee"])
            {
                DataForZomba.GetZombaTrainee(cbxZombaTrName);
                DataForZomba.GetZombaExercise(dgvZombaShowTrainingInfo);
                DataForZomba.GetZombaData(dgvShowZombaInfo);

                ClearDataForNew(cbxZombaTrName, nudZombaTrHours, txtZombaAdvices, lbxZombaChoosenExercises, lbxZombaAdvices, ClbxZombaExercisesDays, txtZombaCoachNotes, lbxZombaCoachNotes, dgvShowZombaInfo);
                tcRegieme.TabPages["tpZombaTrainee"].Controls.Add(lblMsg);
            }
            else if (e.TabPage == tcRegieme.TabPages["tpOtherSportsTrainee"])
            {
                DataForOtherSp.GetOtherSpTrainee(cbxOtherSpTrName);
                DataForOtherSp.GetOtherSpExercise(dgvOtherSpShowTrainingInfo);
                DataForOtherSp.GetOtherSpData(dgvShowOtherSpInfo);

                ClearDataForNew(cbxOtherSpTrName, nudOtherSpTrHours, txtOtherSpAdvices, lbxOtherSpChoosenExercises, lbxOtherSpAdvices, ClbxOtherSpExercisesDays, txtOtherSpCoachNotes, lbxOtherSpCoachNotes, dgvShowOtherSpInfo);
                tcRegieme.TabPages["tpOtherSportsTrainee"].Controls.Add(lblMsg);
            }
        }

        private void dgvShowBoxingInfo_SelectionChanged(object sender, EventArgs e)
        {
            DataForBoxing.DGV_SelectionChanged(dgvShowBoxingInfo, cbxBoxingTrName, nudBoxingTrHours, ClbxBoxingExercisesDays, lbxBoxingChoosenExercises, lbxBoxingAdvices, lbxBoxingCoachNotes);
        }

        private void btnNewBoxing_Click(object sender, EventArgs e)
        {
            ClearDataForNew(cbxBoxingTrName, nudBoxingTrHours, txtBoxingAdvices, lbxBoxingChoosenExercises, lbxBoxingAdvices, ClbxBoxingExercisesDays, txtBoxingCoachNotes, lbxBoxingCoachNotes, dgvShowBoxingInfo);
        }

        private void dgvBoxingShowTrainingInfo_DoubleClick(object sender, EventArgs e)
        {
            ChoosingExercisesFromDgv(dgvBoxingShowTrainingInfo, lbxBoxingChoosenExercises);
        }

        private void btnDelBoxingSelectedChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingChoosenExercises, 0);
        }

        private void btnDelBoxingLastItemChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingChoosenExercises, 1);
        }

        private void btnDelBoxingAllChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingChoosenExercises, 2);
        }

        private void btnDelBoxingSelectedAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingAdvices, 0);
        }

        private void btnDelBoxingLastItemAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingAdvices, 1);
        }

        private void btnDelBoxingAllAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingAdvices, 2);
        }

        private void btnDelBoxingSelectedNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingCoachNotes, 0);
        }

        private void btnDelBoxingLastItemNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingCoachNotes, 1);
        }

        private void btnDelBoxingAllNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxBoxingCoachNotes, 2);
        }

        private void btnAddBoxing_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxBoxingTrName, nudBoxingTrHours, dgvBoxingShowTrainingInfo, lbxBoxingChoosenExercises, lbxBoxingAdvices, lbxBoxingCoachNotes)) return;
            epRegeime.Clear();
            Inserting_Data(DataForBoxing.tblAllData, cbxBoxingTrName, nudBoxingTrHours, lbxBoxingChoosenExercises, ClbxBoxingExercisesDays, lbxBoxingAdvices, lbxBoxingCoachNotes, dgvShowBoxingInfo, DataForBoxing.GetBoxingData, true);
        }

        private void btnAddBoxingAdvices_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtBoxingAdvices, lbxBoxingAdvices);
        }

        private void btnAddBoxingCoachNotes_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtBoxingCoachNotes, lbxBoxingCoachNotes);
        }

        private void btnEditBoxing_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxBoxingTrName, nudBoxingTrHours, dgvBoxingShowTrainingInfo, lbxBoxingChoosenExercises, lbxBoxingAdvices, lbxBoxingCoachNotes)) return;
            epRegeime.Clear();
            Editing_Data(dgvShowBoxingInfo, nudBoxingTrHours, lbxBoxingChoosenExercises, ClbxBoxingExercisesDays, lbxBoxingAdvices, lbxBoxingCoachNotes, DataForBoxing.GetBoxingData, dgvShowBoxingInfo, true);
        }

        private void btnDeleteBoxing_Click(object sender, EventArgs e)
        {
            if (dgvShowBoxingInfo.Rows.Count > 0)
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف النظام التدريبى لهذا المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Deleting_Data(dgvShowBoxingInfo, DataForBoxing.GetBoxingData, dgvShowBoxingInfo, true);
                    btnNewBoxing.PerformClick();
                }
            }
        }
        string str = "";
        private void cbxBuildingTrName_Validating(object sender, CancelEventArgs e)
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

        private void cbxBuildingTrName_Click(object sender, EventArgs e)
        {
            str = ((ComboBox)sender).Text;
        }

        private void cbxBuildingTrName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            str = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }

        private void cbxBuildingTrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                str = ((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem);
        }

        private void txtBoxingAdvices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != '-' && e.KeyChar != '/') e.Handled = true;
        }

        private void dgvFitnessShowTrainingInfo_DoubleClick(object sender, EventArgs e)
        {
            ChoosingExercisesFromDgv(dgvFitnessShowTrainingInfo, lbxFitnessChoosenExercises);
        }

        private void btnDelFitnessSelectedChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessChoosenExercises, 0);
        }

        private void btnDelFitnessLastItemChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessChoosenExercises, 1);
        }

        private void btnDelFitnessAllChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessChoosenExercises, 2);
        }

        private void btnDelFitnessSelectedAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessAdvices, 0);
        }

        private void btnDelFitnessLastItemAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessAdvices, 1);
        }

        private void btnDelFitnessAllAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessAdvices, 2);
        }

        private void btnDelFitnessSelectedNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessCoachNotes, 0);
        }

        private void btnDelFitnessLastItemNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessCoachNotes, 1);
        }

        private void btnDelFitnessAllNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxFitnessCoachNotes, 2);
        }

        private void btnAddFitness_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxFitnessTrName, nudFitnessTrHours, dgvFitnessShowTrainingInfo, lbxFitnessChoosenExercises, lbxFitnessAdvices, lbxFitnessCoachNotes)) return;
            epRegeime.Clear();
            Inserting_Data(DataForFitness.tblAllData, cbxFitnessTrName, nudFitnessTrHours, lbxFitnessChoosenExercises, ClbxFitnessExercisesDays, lbxFitnessAdvices, lbxFitnessCoachNotes, dgvShowFitnessInfo, DataForFitness.GetFitnessData, true);
        }

        private void btnEditFitness_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxFitnessTrName, nudFitnessTrHours, dgvFitnessShowTrainingInfo, lbxFitnessChoosenExercises, lbxFitnessAdvices, lbxFitnessCoachNotes)) return;
            epRegeime.Clear();
            Editing_Data(dgvShowFitnessInfo, nudFitnessTrHours, lbxFitnessChoosenExercises, ClbxFitnessExercisesDays, lbxFitnessAdvices, lbxFitnessCoachNotes, DataForFitness.GetFitnessData, dgvShowFitnessInfo, true);
        }

        private void btnDeleteFitness_Click(object sender, EventArgs e)
        {
            if (dgvShowFitnessInfo.Rows.Count > 0)
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف النظام التدريبى لهذا المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Deleting_Data(dgvShowFitnessInfo, DataForFitness.GetFitnessData, dgvShowFitnessInfo, true);
                    btnNewFitness.PerformClick();
                }
            }
        }

        private void btnAddFitnessAdvices_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtFitnessAdvices, lbxFitnessAdvices);
        }

        private void btnAddFitnessCoachNotes_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtFitnessCoachNotes, lbxFitnessCoachNotes);
        }

        private void dgvShowFitnessInfo_SelectionChanged(object sender, EventArgs e)
        {
            DataForFitness.DGV_SelectionChanged(dgvShowFitnessInfo, cbxFitnessTrName, nudFitnessTrHours, ClbxFitnessExercisesDays, lbxFitnessChoosenExercises, lbxFitnessAdvices, lbxFitnessCoachNotes);
        }

        private void Searching(DataTable tbl, RadioButton rdoName, RadioButton rdoDay, TextBox txt, DataGridView dgv)
        {
            DataView dv = new DataView(tbl);
            string strFiltered = "";
            if (rdoName.Checked)
            {
                strFiltered = "trainingname like'%" + txt.Text + "%'";
            }
            else if (rdoDay.Checked)
            {
                strFiltered = "trainingdays like'%" + txt.Text + "%'";
            }

            dv.RowFilter = strFiltered;
            dgv.DataSource = dv;
        }

        private void txtBuildingSearch_TextChanged(object sender, EventArgs e)
        {
            Searching(tblAll, rdoBuildingTrName, rdoBuildingTrDay, txtBuildingSearch, dgvShowBuildingInfo);
        }

        private void txtBoxingSearch_TextChanged(object sender, EventArgs e)
        {
            Searching(DataForBoxing.tblAllData, rdoBoxingTrName, rdoBoxingTrDay, txtBoxingSearch, dgvShowBoxingInfo);
        }

        private void txtFitnessSearch_TextChanged(object sender, EventArgs e)
        {
            Searching(DataForFitness.tblAllData, rdoFitnessTrName, rdoFitnessTrDay, txtFitnessSearch, dgvShowFitnessInfo);
        }

        private void btnNewFitness_Click(object sender, EventArgs e)
        {
            ClearDataForNew(cbxFitnessTrName, nudFitnessTrHours, txtFitnessAdvices, lbxFitnessChoosenExercises, lbxFitnessAdvices, ClbxFitnessExercisesDays, txtFitnessCoachNotes, lbxFitnessCoachNotes, dgvShowFitnessInfo);
        }

        private void btnAddMass_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxMassTrName, nudMassTrHours, dgvMassShowTrainingInfo, lbxMassChoosenExercises, lbxMassAdvices, lbxMassCoachNotes)) return;
            epRegeime.Clear();
            Inserting_Data(DataForMass.tblAllData, cbxMassTrName, nudMassTrHours, lbxMassChoosenExercises, ClbxMassExercisesDays, lbxMassAdvices, lbxMassCoachNotes, dgvShowMassInfo, DataForMass.GetMassData, true);
        }

        private void dgvMassShowTrainingInfo_DoubleClick(object sender, EventArgs e)
        {
            ChoosingExercisesFromDgv(dgvMassShowTrainingInfo, lbxMassChoosenExercises);
        }

        private void btnDelMassSelectedChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassChoosenExercises, 0);
        }

        private void btnDelMassLastItemChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassChoosenExercises, 1);
        }

        private void btnDelMassAllChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassChoosenExercises, 2);
        }

        private void btnDelMassSelectedAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassAdvices, 0);
        }

        private void btnDelMassLastItemAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassAdvices, 1);
        }

        private void btnDelMassAllAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassAdvices, 2);
        }

        private void btnDelMassSelectedNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassCoachNotes, 0);
        }

        private void btnDelMassLastItemNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassCoachNotes, 1);
        }

        private void btnDelMassAllNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxMassCoachNotes, 2);
        }

        private void btnAddMassAdvices_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtMassAdvices, lbxMassAdvices);
        }

        private void btnAddMassCoachNotes_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtMassCoachNotes, lbxMassCoachNotes);
        }

        private void btnEditMass_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxMassTrName, nudMassTrHours, dgvMassShowTrainingInfo, lbxMassChoosenExercises, lbxMassAdvices, lbxMassCoachNotes)) return;
            epRegeime.Clear();
            Editing_Data(dgvShowMassInfo, nudMassTrHours, lbxMassChoosenExercises, ClbxMassExercisesDays, lbxMassAdvices, lbxMassCoachNotes, DataForMass.GetMassData, dgvShowMassInfo, true);
        }

        private void dgvShowMassInfo_SelectionChanged(object sender, EventArgs e)
        {
            DataForMass.DGV_SelectionChanged(dgvShowMassInfo, cbxMassTrName, nudMassTrHours, ClbxMassExercisesDays, lbxMassChoosenExercises, lbxMassAdvices, lbxMassCoachNotes);
        }

        private void btnNewMass_Click(object sender, EventArgs e)
        {

            ClearDataForNew(cbxMassTrName, nudMassTrHours, txtMassAdvices, lbxMassChoosenExercises, lbxMassAdvices, ClbxMassExercisesDays, txtMassCoachNotes, lbxMassCoachNotes, dgvShowMassInfo);
        }

        private void btnDeleteMass_Click(object sender, EventArgs e)
        {
            if (dgvShowMassInfo.Rows.Count > 0)
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف النظام التدريبى لهذا المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Deleting_Data(dgvShowMassInfo, DataForMass.GetMassData, dgvShowMassInfo, true);
                    btnNewMass.PerformClick();
                }
            }
        }

        private void btnNewAyr_Click(object sender, EventArgs e)
        {
            ClearDataForNew(cbxAyrTrName, nudAyrTrHours, txtAyrAdvices, lbxAyrChoosenExercises, lbxAyrAdvices, ClbxAyrExercisesDays, txtAyrCoachNotes, lbxAyrCoachNotes, dgvShowAyrInfo);
        }

        private void btnAddAyr_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxAyrTrName, nudAyrTrHours, dgvAyrShowTrainingInfo, lbxAyrChoosenExercises, lbxAyrAdvices, lbxAyrCoachNotes)) return;
            epRegeime.Clear();
            Inserting_Data(DataForAyr.tblAllData, cbxAyrTrName, nudAyrTrHours, lbxAyrChoosenExercises, ClbxAyrExercisesDays, lbxAyrAdvices, lbxAyrCoachNotes, dgvShowAyrInfo, DataForAyr.GetAyrData, true);
        }

        private void btnDeleteAyr_Click(object sender, EventArgs e)
        {
            if (dgvShowAyrInfo.Rows.Count > 0)
            {

                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف النظام التدريبى لهذا المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Deleting_Data(dgvShowAyrInfo, DataForAyr.GetAyrData, dgvShowAyrInfo, true);
                    btnNewAyr.PerformClick();
                }
            }
        }

        private void dgvAyrShowTrainingInfo_DoubleClick(object sender, EventArgs e)
        {
            ChoosingExercisesFromDgv(dgvAyrShowTrainingInfo, lbxAyrChoosenExercises);
        }

        private void txtMassSearch_TextChanged(object sender, EventArgs e)
        {
            Searching(DataForMass.tblAllData, rdoMassTrName, rdoMassTrDay, txtMassSearch, dgvShowMassInfo);
        }

        private void btnEditAyr_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxAyrTrName, nudAyrTrHours, dgvAyrShowTrainingInfo, lbxAyrChoosenExercises, lbxAyrAdvices, lbxAyrCoachNotes)) return;
            epRegeime.Clear();
            Editing_Data(dgvShowAyrInfo, nudAyrTrHours, lbxAyrChoosenExercises, ClbxAyrExercisesDays, lbxAyrAdvices, lbxAyrCoachNotes, DataForAyr.GetAyrData, dgvShowAyrInfo, true);
        }

        private void dgvShowAyrInfo_SelectionChanged(object sender, EventArgs e)
        {
            DataForAyr.DGV_SelectionChanged(dgvShowAyrInfo, cbxAyrTrName, nudAyrTrHours, ClbxAyrExercisesDays, lbxAyrChoosenExercises, lbxAyrAdvices, lbxAyrCoachNotes);
        }

        private void btnDelAyrSelectedChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrChoosenExercises, 0);
        }

        private void btnDelAyrLastItemChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrChoosenExercises, 1);
        }

        private void btnDelAyrAllChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrChoosenExercises, 2);
        }

        private void btnDelAyrSelectedAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrAdvices, 0);
        }

        private void btnDelAyrLastItemAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrAdvices, 1);
        }

        private void btnDelAyrAllAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrAdvices, 2);
        }

        private void btnDelAyrSelectedNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrCoachNotes, 0);
        }

        private void btnDelAyrLastItemNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrCoachNotes, 1);
        }

        private void btnDelAyrAllNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxAyrCoachNotes, 2);
        }

        private void btnAddAyrAdvices_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtAyrAdvices, lbxAyrAdvices);
        }

        private void btnAddAyrCoachNotes_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtAyrCoachNotes, lbxAyrCoachNotes);
        }

        private void txtAyrSearch_TextChanged(object sender, EventArgs e)
        {
            Searching(DataForAyr.tblAllData, rdoAyrTrName, rdoAyrTrDay, txtAyrSearch, dgvShowAyrInfo);
        }

        private void btnAddZomba_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxZombaTrName, nudZombaTrHours, dgvZombaShowTrainingInfo, lbxZombaChoosenExercises, lbxZombaAdvices, lbxZombaCoachNotes)) return;
            epRegeime.Clear();
            Inserting_Data(DataForZomba.tblAllData, cbxZombaTrName, nudZombaTrHours, lbxZombaChoosenExercises, ClbxZombaExercisesDays, lbxZombaAdvices, lbxZombaCoachNotes, dgvShowZombaInfo, DataForZomba.GetZombaData, true);
        }

        private void btnNewZomba_Click(object sender, EventArgs e)
        {
            ClearDataForNew(cbxZombaTrName, nudZombaTrHours, txtZombaAdvices, lbxZombaChoosenExercises, lbxZombaAdvices, ClbxZombaExercisesDays, txtZombaCoachNotes, lbxZombaCoachNotes, dgvShowZombaInfo);
        }

        private void dgvZombaShowTrainingInfo_DoubleClick(object sender, EventArgs e)
        {
            ChoosingExercisesFromDgv(dgvZombaShowTrainingInfo, lbxZombaChoosenExercises);
        }

        private void btnDelZombaSelectedChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaChoosenExercises, 0);
        }

        private void btnDelZombaLastItemChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaChoosenExercises, 1);
        }

        private void btnDelZombaAllChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaChoosenExercises, 2);
        }

        private void btnDelZombaSelectedAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaAdvices, 0);
        }

        private void btnDelZombaLastItemAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaAdvices, 1);
        }

        private void btnDelZombaAllAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaAdvices, 2);
        }

        private void btnDelZombaSelectedNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaCoachNotes, 0);
        }

        private void btnDelZombaLastItemNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaCoachNotes, 1);
        }

        private void btnDelZombaAllNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxZombaCoachNotes, 2);
        }

        private void btnAddZombaAdvices_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtZombaAdvices, lbxZombaAdvices);
        }

        private void btnAddZombaCoachNotes_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtZombaCoachNotes, lbxZombaCoachNotes);
        }

        private void btnEditZomba_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxZombaTrName, nudZombaTrHours, dgvZombaShowTrainingInfo, lbxZombaChoosenExercises, lbxZombaAdvices, lbxZombaCoachNotes)) return;
            epRegeime.Clear();
            Editing_Data(dgvShowZombaInfo, nudZombaTrHours, lbxZombaChoosenExercises, ClbxZombaExercisesDays, lbxZombaAdvices, lbxZombaCoachNotes, DataForZomba.GetZombaData, dgvShowZombaInfo, true);
        }

        private void dgvShowZombaInfo_SelectionChanged(object sender, EventArgs e)
        {
            DataForZomba.DGV_SelectionChanged(dgvShowZombaInfo, cbxZombaTrName, nudZombaTrHours, ClbxZombaExercisesDays, lbxZombaChoosenExercises, lbxZombaAdvices, lbxZombaCoachNotes);
        }

        private void txtZombaSearch_TextChanged(object sender, EventArgs e)
        {
            Searching(DataForZomba.tblAllData, rdoZombaTrName, rdoZombaTrDay, txtZombaSearch, dgvShowZombaInfo);
        }

        private void Make_Action(TextBox txt, SansationRoundButton btn)
        {
            txt.KeyDown += delegate (object obj, KeyEventArgs E)
            {
                obj = txt;
                if (E.KeyData == Keys.Enter)
                {
                    btn.PerformClick();
                }
            };
        }
        private void txtBuildingAdvices_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddBuildingAdvices);
        }

        private void txtBuildingCoachNotes_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddBuildingCoachNotes);
        }

        private void txtBoxingAdvices_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddBoxingAdvices);
        }

        private void txtBoxingCoachNotes_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddBoxingCoachNotes);
        }

        private void txtMassAdvices_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddMassAdvices);
        }

        private void txtMassCoachNotes_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddMassCoachNotes);
        }

        private void txtFitnessAdvices_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddFitnessAdvices);
        }

        private void txtFitnessCoachNotes_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddFitnessCoachNotes);
        }

        private void txtAyrAdvices_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddAyrAdvices);
        }

        private void txtAyrCoachNotes_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddAyrCoachNotes);
        }

        private void txtZombaAdvices_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddZombaAdvices);
        }

        private void txtZombaCoachNotes_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddZombaCoachNotes);
        }

        private void btnDeleteZomba_Click(object sender, EventArgs e)
        {
            if (dgvShowZombaInfo.Rows.Count > 0)
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف النظام التدريبى لهذا المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Deleting_Data(dgvShowZombaInfo, DataForZomba.GetZombaData, dgvShowZombaInfo, true);
                    btnNewZomba.PerformClick();
                }
            }
        }

        private void btnNewOtherSp_Click(object sender, EventArgs e)
        {
            ClearDataForNew(cbxOtherSpTrName, nudOtherSpTrHours, txtOtherSpAdvices, lbxOtherSpChoosenExercises, lbxOtherSpAdvices, ClbxOtherSpExercisesDays, txtOtherSpCoachNotes, lbxOtherSpCoachNotes, dgvShowOtherSpInfo);
        }

        private void btnAddOtherSp_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxOtherSpTrName, nudOtherSpTrHours, dgvOtherSpShowTrainingInfo, lbxOtherSpChoosenExercises, lbxOtherSpAdvices, lbxOtherSpCoachNotes)) return;
            epRegeime.Clear();
            Inserting_Data(DataForOtherSp.tblAllData, cbxOtherSpTrName, nudOtherSpTrHours, lbxOtherSpChoosenExercises, ClbxOtherSpExercisesDays, lbxOtherSpAdvices, lbxOtherSpCoachNotes, dgvShowOtherSpInfo, DataForOtherSp.GetOtherSpData, true);
        }

        private void btnEditOtherSp_Click(object sender, EventArgs e)
        {
            if (Making_Validation(cbxOtherSpTrName, nudOtherSpTrHours, dgvOtherSpShowTrainingInfo, lbxOtherSpChoosenExercises, lbxOtherSpAdvices, lbxOtherSpCoachNotes)) return;
            epRegeime.Clear();
            Editing_Data(dgvShowOtherSpInfo, nudOtherSpTrHours, lbxOtherSpChoosenExercises, ClbxOtherSpExercisesDays, lbxOtherSpAdvices, lbxOtherSpCoachNotes, DataForOtherSp.GetOtherSpData, dgvShowOtherSpInfo, true);
        }

        private void btnDeleteOtherSp_Click(object sender, EventArgs e)
        {
            if (dgvShowOtherSpInfo.Rows.Count > 0)
            {
                FrmConfirmDel frm = new FrmConfirmDel();
                frm.lblHeader.Text = "هل تريد حذف النظام التدريبى لهذا المشترك بالفعل ";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Deleting_Data(dgvShowOtherSpInfo, DataForOtherSp.GetOtherSpData, dgvShowOtherSpInfo, true);
                    btnNewOtherSp.PerformClick();
                }
            }
        }

        private void dgvOtherSpShowTrainingInfo_DoubleClick(object sender, EventArgs e)
        {
            ChoosingExercisesFromDgv(dgvOtherSpShowTrainingInfo, lbxOtherSpChoosenExercises);
        }

        private void btnDelOtherSpSelectedChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpChoosenExercises, 0);
        }

        private void btnDelOtherSpLastItemChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpChoosenExercises,1 );
        }

        private void btnDelOtherSpAllChoosen_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpChoosenExercises, 2);
        }

        private void btnDelOtherSpSelectedAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpAdvices, 0);
        }

        private void btnDelOtherSpLastItemAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpAdvices, 1);
        }

        private void btnDelOtherSpAllAdv_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpAdvices, 2);
        }

        private void btnDelOtherSpSelectedNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpCoachNotes, 0);
        }

        private void btnDelOtherSpLastItemNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpCoachNotes, 1);
        }

        private void btnDelOtherSpAllNotes_Click(object sender, EventArgs e)
        {
            DeleteItemsFromlbx(lbxOtherSpCoachNotes, 2);
        }

        private void btnAddOtherSpAdvices_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtOtherSpAdvices, lbxOtherSpAdvices);
        }

        private void btnAddOtherSpCoachNotes_Click(object sender, EventArgs e)
        {
            AddNotesAndAdvices(txtOtherSpCoachNotes, lbxOtherSpCoachNotes);
        }

        private void txtOtherSpAdvices_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender, btnAddOtherSpAdvices);
        }

        private void txtOtherSpCoachNotes_KeyDown(object sender, KeyEventArgs e)
        {
            Make_Action((TextBox)sender,btnAddOtherSpCoachNotes);
        }

        private void dgvShowOtherSpInfo_SelectionChanged(object sender, EventArgs e)
        {
            DataForOtherSp.DGV_SelectionChanged(dgvShowOtherSpInfo, cbxOtherSpTrName, nudOtherSpTrHours, ClbxOtherSpExercisesDays, lbxOtherSpChoosenExercises, lbxOtherSpAdvices, lbxOtherSpCoachNotes);
        }
    }
}
