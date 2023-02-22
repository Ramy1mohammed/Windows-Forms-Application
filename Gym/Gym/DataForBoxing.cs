using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public class DataForBoxing
    {
        static DataTable tblGetBoxingTrainee = new DataTable();
        static DataTable tblGetBoxingExercises = new DataTable();
        public static void GetBoxingTrainee(ComboBox cbx)
        {
            tblGetBoxingTrainee.Rows.Clear();
            DB.GetData("select trno,trname from Trainee where exercisetype='تمرين Boxing'", tblGetBoxingTrainee);
            cbx.DataSource = tblGetBoxingTrainee;
            cbx.DisplayMember = tblGetBoxingTrainee.Columns[1].ToString();
            cbx.ValueMember = tblGetBoxingTrainee.Columns[0].ToString();
        }

        public static void GetBoxingExercises(DataGridView dgv)
        {
            tblGetBoxingExercises.Rows.Clear();
            DB.GetData("select trainingno,trainingname,trainingimage from TrainingMap where trainingcategory='تمرين Boxing'", tblGetBoxingExercises);
            dgv.DataSource = tblGetBoxingExercises;
            dgv.Columns[0].Visible = false;
        }

        static DataTable tblGetBoxingActiveOnly = new DataTable();

       public static DataTable tblAllData = new DataTable();
        public static void GetBoxingData(DataGridView dgv)
        {
            tblGetBoxingActiveOnly.Rows.Clear();
            tblAllData.Rows.Clear();

            DB.GetData("select * from BoxingOnly", tblGetBoxingActiveOnly);
            
            if(tblGetBoxingActiveOnly.Rows.Count>0)
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

                for(int x=0;x<tblGetBoxingActiveOnly.Rows.Count;x++)
                {
                    DataRow row = tblAllData.NewRow();
                    row[0] = tblGetBoxingActiveOnly.Rows[x][0];
                    row[1] = tblGetBoxingActiveOnly.Rows[x][1];
                    row[2] = tblGetBoxingActiveOnly.Rows[x][2];

                    DataRow[] daysRows = FrmRegieme.tblGetTrainingDays.Select("trno=" + tblGetBoxingActiveOnly.Rows[x][0]);
                    string strDays = "";
                    foreach (DataRow  r in daysRows)
                    {
                        strDays += r[1] + Environment.NewLine;
                    }
                    row[3] = strDays;

                    DataRow[] RowsGetExercisesNames =FrmRegieme.tblGetExercisesNames.Select("trno=" + tblGetBoxingActiveOnly.Rows[x][0]);
                    string strGetExercisesNames = "";
                    foreach (DataRow i in RowsGetExercisesNames)
                    {
                        strGetExercisesNames += i[1] + Environment.NewLine;
                    }
                    row[4] = strGetExercisesNames;

                    DataRow[] RowsGetTraineeAdvices = FrmRegieme.tblGetAdvices.Select("trno=" + tblGetBoxingActiveOnly.Rows[x][0]);
                    string strGetAdvices = "";
                    foreach (DataRow i in RowsGetTraineeAdvices)
                    {
                        strGetAdvices += i[1] + Environment.NewLine;
                    }
                    row[5] = strGetAdvices;

                    DataRow[] RowsGetTrineeNotes = FrmRegieme.tblGetNotes.Select("trno=" + tblGetBoxingActiveOnly.Rows[x][0]);
                    string strGetNotes = "";
                    foreach (DataRow i in RowsGetTrineeNotes)
                    {
                        strGetNotes += i[1] + Environment.NewLine;
                    }
                    row[6] = strGetNotes;

                    tblAllData.Rows.Add(row);
                }
                dgv.DataSource = tblAllData;
            }
        }

        public static void DGV_SelectionChanged(DataGridView dgv,ComboBox cbx,NumericUpDown nud,CheckedListBox clb,ListBox lbxExercices, ListBox lbxAdvices,ListBox lbxNotes)
        {
            if (dgv.CurrentRow != null)
            {
                cbx.Text = dgv.CurrentRow.Cells["coltrnameboxing"].Value.ToString();
                nud.Value = Convert.ToInt32(dgv.CurrentRow.Cells["coltraininghoursboxing"].Value);
                var r = from getDays in tblAllData.AsEnumerable()
                        where getDays[0].ToString() == dgv.CurrentRow.Cells["coltrnoboxing"].Value.ToString()
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
                         where getEXNames[0].ToString() == dgv.CurrentRow.Cells["coltrnoboxing"].Value.ToString()
                         select getEXNames[1];
                lbxExercices.Items.Clear();
                foreach (var i in v1)
                {
                    lbxExercices.Items.Add(i.ToString());
                }

                var v2 = from getAdvices in FrmRegieme.tblGetAdvices.AsEnumerable()
                         where getAdvices[0].ToString() == dgv.CurrentRow.Cells["coltrnoboxing"].Value.ToString()
                         select getAdvices[1];
                lbxAdvices.Items.Clear();
                foreach (var i in v2)
                {
                    lbxAdvices.Items.Add(i.ToString());
                }

                var v3 = from getNotes in FrmRegieme.tblGetNotes.AsEnumerable()
                         where getNotes[0].ToString() == dgv.CurrentRow.Cells["coltrnoboxing"].Value.ToString()
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
