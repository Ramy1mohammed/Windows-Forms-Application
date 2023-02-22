using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    internal class DataForFitness
    {
        static DataTable tblGetFitnessTrainee = new DataTable();
        static DataTable tblGetFitnessExercises = new DataTable();
        public static void GetFitnessTrainee(ComboBox cbx)
        {
            tblGetFitnessTrainee.Rows.Clear();
            DB.GetData("select trno,trname from Trainee  where exercisetype='تمرين لياقه بدنيه وتأهيل بدنى'", tblGetFitnessTrainee);
            cbx.DataSource = tblGetFitnessTrainee;
            cbx.DisplayMember = tblGetFitnessTrainee.Columns[1].ToString();
            cbx.ValueMember = tblGetFitnessTrainee.Columns[0].ToString();
        }
        public static void GetFitnessExercise(DataGridView dgv)
        {
            tblGetFitnessExercises.Rows.Clear();
            DB.GetData("select trainingno,trainingname,trainingimage from TrainingMap where trainingcategory='تمرين لياقه بدنيه وتأهيل بدنى'", tblGetFitnessExercises);
            dgv.DataSource = tblGetFitnessExercises;
            dgv.Columns[0].Visible = false;
        }

        static DataTable tblGetFitnessActiveOnly = new DataTable();
        public static DataTable tblAllData = new DataTable();
        public static void GetFitnessData(DataGridView dgv)
        {
            tblGetFitnessActiveOnly.Rows.Clear();
            tblAllData.Rows.Clear();

            DB.GetData("select * from FitnessOnly", tblGetFitnessActiveOnly);

            if (tblGetFitnessActiveOnly.Rows.Count > 0)
            {
                if (tblAllData.Columns.Count < 1)
                {
                    tblAllData.Columns.Add("trno", typeof(int));
                    tblAllData.Columns.Add("trainingname");
                    tblAllData.Columns.Add("traininghours", typeof(int));
                    tblAllData.Columns.Add("trainingdays");
                    tblAllData.Columns.Add("exercisesnames");
                    tblAllData.Columns.Add("TraineeAdvices");
                    tblAllData.Columns.Add("TraineeNotes");
                }

                for (int x = 0; x < tblGetFitnessActiveOnly.Rows.Count; x++)
                {
                    DataRow row = tblAllData.NewRow();
                    row[0] = tblGetFitnessActiveOnly.Rows[x][0];
                    row[1] = tblGetFitnessActiveOnly.Rows[x][1];
                    row[2] = tblGetFitnessActiveOnly.Rows[x][2];

                    DataRow[] rowDays = FrmRegieme.tblGetTrainingDays.Select("trno=" + tblGetFitnessActiveOnly.Rows[x][0]);
                    string strDays = "";
                    foreach (DataRow i in rowDays)
                    {
                        strDays += i[1] + Environment.NewLine;
                    }
                    row[3] = strDays;
                    DataRow[] rowExNames = FrmRegieme.tblGetExercisesNames.Select("trno=" + tblGetFitnessActiveOnly.Rows[x][0]);
                    string strExNames = "";
                    foreach (DataRow i in rowExNames)
                    {
                        strExNames += i[1] + Environment.NewLine;
                    }
                    row[4] = strExNames;

                    DataRow[] rowAdvices = FrmRegieme.tblGetAdvices.Select("trno=" + tblGetFitnessActiveOnly.Rows[x][0]);
                    string strAdvices = "";
                    foreach (DataRow i in rowAdvices)
                    {
                        strAdvices += i[1] + Environment.NewLine;
                    }
                    row[5] = strAdvices;

                    DataRow[] rowNotes = FrmRegieme.tblGetNotes.Select("trno=" + tblGetFitnessActiveOnly.Rows[x][0]);
                    string strNotes = "";
                    foreach (DataRow i in rowNotes)
                    {
                        strNotes += i[1] + Environment.NewLine;
                    }
                    row[6] = strNotes;
                    tblAllData.Rows.Add(row);
                }
                dgv.DataSource = tblAllData;
            }
        }
        public static void DGV_SelectionChanged(DataGridView dgv, ComboBox cbx, NumericUpDown nud, CheckedListBox clb, ListBox lbxExercices, ListBox lbxAdvices, ListBox lbxNotes)
        {
            if (dgv.CurrentRow != null)
            {
                cbx.Text = dgv.CurrentRow.Cells["coltrnameFitness"].Value.ToString();
                nud.Value = Convert.ToInt32(dgv.CurrentRow.Cells["coltraininghoursFitness"].Value);
                var r = from getDays in tblAllData.AsEnumerable()
                        where getDays[0].ToString() == dgv.CurrentRow.Cells["coltrnoFitness"].Value.ToString()
                        select
                        getDays[3]
                        ;
                for (int x = 0; x < clb.Items.Count; x++)
                {
                    clb.SetItemChecked(x, false);
                }

                foreach (var i in r)
                {
                    if (i.ToString().Contains("السبت"))
                    {
                        clb.SetItemChecked(0, true);
                    }
                    if (i.ToString().Contains("الأحد"))
                    {
                        clb.SetItemChecked(1, true);
                    }
                    if (i.ToString().Contains("الاثنين"))
                    {
                        clb.SetItemChecked(2, true);
                    }
                    if (i.ToString().Contains("الثلاثاء"))
                    {
                        clb.SetItemChecked(3, true);
                    }
                    if (i.ToString().Contains("الأربعاء"))
                    {
                        clb.SetItemChecked(4, true);
                    }
                    if (i.ToString().Contains("الخميس"))
                    {
                        clb.SetItemChecked(5, true);
                    }
                    if (i.ToString().Contains("الجمعه"))
                    {
                        clb.SetItemChecked(6, true);
                    }
                }

                var v1 = from getEXNames in FrmRegieme.tblGetExercisesNames.AsEnumerable()
                         where getEXNames[0].ToString() == dgv.CurrentRow.Cells["coltrnoFitness"].Value.ToString()
                         select getEXNames[1];
                lbxExercices.Items.Clear();
                foreach (var i in v1)
                {
                    lbxExercices.Items.Add(i.ToString());
                }

                var v2 = from getAdvices in FrmRegieme.tblGetAdvices.AsEnumerable()
                         where getAdvices[0].ToString() == dgv.CurrentRow.Cells["coltrnoFitness"].Value.ToString()
                         select getAdvices[1];
                lbxAdvices.Items.Clear();
                foreach (var i in v2)
                {
                    lbxAdvices.Items.Add(i.ToString());
                }

                var v3 = from getNotes in FrmRegieme.tblGetNotes.AsEnumerable()
                         where getNotes[0].ToString() == dgv.CurrentRow.Cells["coltrnoFitness"].Value.ToString()
                         select getNotes[1];
                lbxNotes.Items.Clear();
                foreach (var i in v3)
                {
                    lbxNotes.Items.Add(i.ToString());
                }
            }
        }

    }
}
