using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmSubscriptionManage : Form
    {
        public FrmSubscriptionManage()
        {
            InitializeComponent();
        }
        DataTable tblSubsData = new DataTable();
        DataTable tblSubsFeaturesData = new DataTable();
        DataTable tblAllData = new DataTable();

        DataTable tblOrdered = new DataTable();
        private void ShowData(string strRange,DataGridView dgv,ComboBox cbx,TextBox txt)
        {
            tblSubsData.Rows.Clear();
            tblSubsFeaturesData.Rows.Clear(); 
            tblAllData.Rows.Clear();
            tblOrdered.Rows.Clear();

            DB.cmd.CommandType = CommandType.Text;
            DB.GetData("select subsno,substype,subsperiod,subsprice from subscription where subsno "+strRange,tblSubsData);
            DB.GetData("select * from SubscriptionFeateurs", tblSubsFeaturesData);
            if (tblSubsData.Rows.Count > 0)
            {
                if (tblAllData.Columns.Count < 1)
                {
                    tblAllData.Columns.Add("subsno", typeof(int));
                    tblAllData.Columns.Add("substype");
                    tblAllData.Columns.Add("subsperiod", typeof(int));
                    tblAllData.Columns.Add("subsprice", typeof(int));
                    //tblAllData.Columns.Add("subsfeatures");
                }


                for(int x=0;x<tblSubsData.Rows.Count;x++)
                {
                    DataRow row = tblAllData.NewRow();
                    row[0] = tblSubsData.Rows[x][0];
                    row[1] = tblSubsData.Rows[x][1];
                    row[2] = tblSubsData.Rows[x][2];
                    row[3] = tblSubsData.Rows[x][3];
                    //DataRow[] subsfetRows = tblSubsFeaturesData.Select("subsno= " + tblSubsData.Rows[x][0]);
                    //string strFets = "";
                    //foreach (DataRow r in subsfetRows)
                    //{
                    //    strFets += r[1] + Environment.NewLine;
                    //}
                    //row[4] = strFets;
                    tblAllData.Rows.Add(row);
                }
                
                IEnumerable<DataRow> ordering = tblAllData.AsEnumerable().OrderBy(p => p[0]);

                tblOrdered=ordering.CopyToDataTable();
                dgv.DataSource = tblOrdered;

                //dgv.Columns[4].Visible = false;
                cbx.DataSource = tblOrdered;
                cbx.DisplayMember = tblOrdered.Columns[1].ToString();
                cbx.ValueMember = tblOrdered.Columns[2].ToString();

                if (cbx.Items.Count > 0)
                    cbx.SelectedIndex = 0;
                if (cbx.SelectedValue != null)
                    txt.Text = cbx.SelectedValue.ToString()+" يوم ";
            }
            
        }
        private void AutoClear(TextBox txt,ListBox lbx)
        {
            txt.Clear();
            lbx.Items.Clear();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AutoClear(txtSubsPrice, lbxSubsFeatures);
        }

        private void FrmSubscriptionManage_Load(object sender, EventArgs e)
        {
            ShowData("in(1,2,3,4,5)", dgvShowSubscribtions, cbxSubsType, txtSubsPeriod);
        }

        private void CbxSelectionWithtxt(ComboBox cbx,TextBox txtPeriod)
        {
            if (cbx.SelectedValue != null)
            {
                    txtPeriod.Text = cbx.SelectedValue.ToString() + " يوم ";
            }
        }
        private void cbxSubsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSelectionWithtxt(cbxSubsType, txtSubsPeriod);
        }

        private void DgvSelectionWithElements(DataGridView dgv,TextBox txtno,TextBox txtprice,ListBox lbx)
        {
            
            if (dgv.CurrentRow != null)
            {
                    txtno.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    txtprice.Text = dgv.CurrentRow.Cells[3].Value.ToString();

                    var r = from fet in tblSubsFeaturesData.AsEnumerable()
                            where fet[0].ToString() == txtno.Text
                            select fet[1];
                    lbx.Items.Clear();

                    foreach (var i in r)
                    {
                        lbx.Items.Add(i);
                    }
            }

        }
        private void dgvShowSubscribtions_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionWithElements(dgvShowSubscribtions, txtSubsno, txtSubsPrice, lbxSubsFeatures);
        }

        private void DelSelection(ListBox lbx)
        {
            while (lbx.SelectedItems.Count > 0)
            {
                lbx.Items.Remove( lbx.SelectedItems[0] );
            }
        }

        private void DelLastSelcted(ListBox lbx)
        {
            if (lbx.Items.Count > 0)
            {
                lbx.Items.RemoveAt(lbx.Items.Count - 1);
            }
        }

        private void DelAllItems(ListBox lbx)
        {
            lbx.Items.Clear();
        }

        private void btnDelSelectedSubs_Click(object sender, EventArgs e)
        {
            DelSelection(lbxSubsFeatures);
        }

        private void btnDelLastSubsFeatures_Click(object sender, EventArgs e)
        {
            DelLastSelcted(lbxSubsFeatures);
        }

        private void btnDelAllSubsFeatures_Click(object sender, EventArgs e)
        {
            DelAllItems(lbxSubsFeatures);
        }

        private void EditingData(TextBox txtno,TextBox txtPrice,ListBox lbxFeatures,Label lblmsg)
        {
            lblmsg.Text = ">> ";
            try
            {
                if (ValidateSubscriptions(txtPrice)) return;
                if (lbxFeatures.Items.Count < 1) lbxFeatures.Items.Add("بدون مميزات ");
                DB.Run("update subscription set subsprice=" + txtPrice.Text + " where subsno=" + txtno.Text);
                DB.Run("delete from SubscriptionFeateurs where subsno=" + txtno.Text);
                for (int x = 0; x < lbxFeatures.Items.Count; x++)
                {
                    DB.Run("insert into SubscriptionFeateurs values(" + txtno.Text + ",'" + lbxFeatures.GetItemText(lbxFeatures.Items[x]) + "')");
                }
                epSubs.Clear();
                lblmsg.Text += " تم تعديل الاشتراك";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditSubs_Click(object sender, EventArgs e)
        {
            EditingData(txtSubsno, txtSubsPrice, lbxSubsFeatures, lblMsg);
            ShowData("in(1,2,3,4,5)", dgvShowSubscribtions, cbxSubsType, txtSubsPeriod);
        }

        private void AddFeatures(TextBox txtFeatures, ListBox lbx)
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
        private void btnAddFeatures_Click(object sender, EventArgs e)
        {
            AddFeatures(txtSubsFeatures, lbxSubsFeatures);
        }

        private void txtSubsFeatures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnAddFeatures.PerformClick();
        }

        private void cbxSubsType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private bool ValidateSubscriptions(TextBox txtprice)
        {
            bool Is_Valid = false;
            if(txtprice.Text.Trim()=="")
            {
                epSubs.SetError(txtprice, "من فضلك أدخل سعر الاشتراك ");
                Is_Valid = true;
            }
            return Is_Valid;
        }

        private void FrmSubscriptionManage_Deactivate(object sender, EventArgs e)
        {
            lblMsg.Text = ">> ";
            lblMsgBoxing.Text = ">> ";
        }

        private void txtSubsPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtSubsFeatures_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@' || e.KeyChar==(char)34 || e.KeyChar==(char)39) e.Handled = true;
        }

        private void tcSubscription_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                lblMsgBoxing.Text = ">> ";
                lblMsgMass.Text = ">> ";
                lblMsgFit.Text = ">> ";
                lblMsgAy.Text = ">> ";
                lblMsgZomba.Text = ">> ";
                lblMsgOther.Text = ">> ";
                ShowData("in(1,2,3,4,5)", dgvShowSubscribtions, cbxSubsType, txtSubsPeriod);
            }
            else if (e.TabPageIndex == 1)
            {
                lblMsg.Text = ">> ";
                lblMsgMass.Text = ">> ";
                lblMsgFit.Text = ">> ";
                lblMsgAy.Text = ">> ";
                lblMsgZomba.Text = ">> ";
                lblMsgOther.Text = ">> ";
                ShowData("in(6,7,8,9,10)", dgvShowSubscribtionsBoxing, cbxSubsTypeBoxing, txtSubsPeriodBoxing);
                CbxSelectionWithtxt(cbxSubsTypeBoxing, txtSubsPeriodBoxing);
            }
            else if(e.TabPageIndex==2)
            {
                lblMsg.Text = ">> ";
                lblMsgBoxing.Text = ">> ";
                lblMsgFit.Text = ">> ";
                lblMsgAy.Text = ">> ";
                lblMsgZomba.Text = ">> ";
                lblMsgOther.Text = ">> ";
                ShowData("in(11,12,13,14,15)", dgvShowSubscribtionsMass, cbxSubsTypeMass, txtSubsPeriodMass);
                CbxSelectionWithtxt(cbxSubsTypeMass, txtSubsPeriodMass);
            }
            else if (e.TabPageIndex == 3)
            {
                lblMsg.Text = ">> ";
                lblMsgBoxing.Text = ">> ";
                lblMsgMass.Text = ">> ";
                lblMsgAy.Text = ">> ";
                lblMsgZomba.Text = ">> ";
                lblMsgOther.Text = ">> ";
                ShowData("in(16,17,18,19,20)", dgvShowSubscribtionsFit, cbxSubsTypeFit, txtSubsPeriodFit);
                CbxSelectionWithtxt(cbxSubsTypeFit, txtSubsPeriodFit);
            }
            else if (e.TabPageIndex == 4)
            {
                lblMsgBoxing.Text = ">> ";
                lblMsgMass.Text = ">> ";
                lblMsgFit.Text = ">> ";
                lblMsg.Text = ">> ";
                lblMsgZomba.Text = ">> ";
                lblMsgOther.Text = ">> ";
                ShowData("in(21,22,23,24,25)", dgvShowSubscribtionsAy, cbxSubsTypeAy, txtSubsPeriodAy);
                CbxSelectionWithtxt(cbxSubsTypeAy, txtSubsPeriodAy);
            }
            else if(e.TabPageIndex == 5)
            {
                lblMsgBoxing.Text = ">> ";
                lblMsgMass.Text = ">> ";
                lblMsgFit.Text = ">> ";
                lblMsg.Text = ">> ";
                lblMsgAy.Text = ">> ";
                lblMsgOther.Text = ">> ";
                ShowData("in(26,27,28,29,30)", dgvShowSubscribtionsZomba, cbxSubsTypeZomba, txtSubsPeriodZomba);
                CbxSelectionWithtxt(cbxSubsTypeZomba, txtSubsPeriodZomba);
            }
            else if(e.TabPageIndex == 6)
            {
                lblMsgBoxing.Text = ">> ";
                lblMsgMass.Text = ">> ";
                lblMsgFit.Text = ">> ";
                lblMsg.Text = ">> ";
                lblMsgAy.Text = ">> ";
                lblMsgZomba.Text = ">> ";
                ShowData("in(31,32,33,34,35)", dgvShowSubscribtionsOther, cbxSubsTypeOther, txtSubsPeriodOther);
                CbxSelectionWithtxt(cbxSubsTypeOther, txtSubsPeriodOther);
            }
        }

        private void dgvShowSubscribtionsBoxing_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionWithElements(dgvShowSubscribtionsBoxing, txtSubsnoBoxing, txtSubsPriceBoxing, lbxSubsFeaturesBoxing);
        }

        private void cbxSubsTypeBoxing_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSelectionWithtxt(cbxSubsTypeBoxing, txtSubsPeriodBoxing);
        }

        private void btnEditSubsBoxing_Click(object sender, EventArgs e)
        {
            EditingData(txtSubsnoBoxing, txtSubsPriceBoxing, lbxSubsFeaturesBoxing, lblMsgBoxing);
            ShowData("in(6,7,8,9,10)", dgvShowSubscribtionsBoxing, cbxSubsTypeBoxing, txtSubsPeriodBoxing);
        }

        private void btnDelSelectedSubsBoxing_Click(object sender, EventArgs e)
        {
            DelSelection(lbxSubsFeaturesBoxing);
        }

        private void btnDelLastSubsFeaturesBoxing_Click(object sender, EventArgs e)
        {
            DelLastSelcted(lbxSubsFeaturesBoxing);
        }

        private void btnDelAllSubsFeaturesBoxing_Click(object sender, EventArgs e)
        {
            DelAllItems(lbxSubsFeaturesBoxing);
        }

        private void btnAddFeaturesBoxing_Click(object sender, EventArgs e)
        {
            AddFeatures(txtSubsFeaturesBoxing, lbxSubsFeaturesBoxing);
        }

        private void dgvShowSubscribtionsMass_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionWithElements(dgvShowSubscribtionsMass, txtSubsnoMass, txtSubsPriceMass, lbxSubsFeaturesMass);
        }

        private void cbxSubsTypeMass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSelectionWithtxt(cbxSubsTypeMass, txtSubsPeriodMass);
        }

        private void btnDelSelectedSubsMass_Click(object sender, EventArgs e)
        {
            DelSelection(lbxSubsFeaturesMass);
        }

        private void btnDelLastSubsFeaturesMass_Click(object sender, EventArgs e)
        {
            DelLastSelcted(lbxSubsFeaturesMass);
        }

        private void btnDelAllSubsFeaturesMass_Click(object sender, EventArgs e)
        {
            DelAllItems(lbxSubsFeaturesMass);
        }

        private void btnAddNewMass_Click(object sender, EventArgs e)
        {
            AutoClear(txtSubsPriceMass, lbxSubsFeaturesMass);
        }

        private void btnAddNewBoxing_Click(object sender, EventArgs e)
        {
            AutoClear(txtSubsPriceBoxing, lbxSubsFeaturesBoxing);
        }

        private void btnEditSubsMass_Click(object sender, EventArgs e)
        {
            EditingData(txtSubsnoMass, txtSubsPriceMass, lbxSubsFeaturesMass, lblMsgMass);
            ShowData("in(11,12,13,14,15)", dgvShowSubscribtionsMass, cbxSubsTypeMass, txtSubsPeriodMass);
        }

        private void btnAddFeaturesMass_Click(object sender, EventArgs e)
        {
            AddFeatures(txtSubsFeaturesMass, lbxSubsFeaturesMass);
        }

        private void dgvShowSubscribtionsFit_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionWithElements(dgvShowSubscribtionsFit, txtSubsnoFit, txtSubsPriceFit, lbxSubsFeaturesFit);
        }

        private void cbxSubsTypeFit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSelectionWithtxt(cbxSubsTypeFit, txtSubsPeriodFit);
        }

        private void btnDelSelectedSubsFit_Click(object sender, EventArgs e)
        {
            DelSelection(lbxSubsFeaturesFit);
        }

        private void btnDelLastSubsFeaturesFit_Click(object sender, EventArgs e)
        {
            DelLastSelcted(lbxSubsFeaturesFit);
        }

        private void btnDelAllSubsFeaturesFit_Click(object sender, EventArgs e)
        {
            DelAllItems(lbxSubsFeaturesFit);
        }

        private void btnAddNewFit_Click(object sender, EventArgs e)
        {
            AutoClear(txtSubsPriceFit, lbxSubsFeaturesFit);
        }

        private void btnEditSubsFit_Click(object sender, EventArgs e)
        {
            EditingData(txtSubsnoFit, txtSubsPriceFit, lbxSubsFeaturesFit, lblMsgFit);
            ShowData("in(16,17,18,19,20)", dgvShowSubscribtionsFit, cbxSubsTypeFit, txtSubsPeriodFit);
        }

        private void btnAddFeaturesFit_Click(object sender, EventArgs e)
        {
            AddFeatures(txtSubsFeaturesFit, lbxSubsFeaturesFit);
        }

        private void dgvShowSubscribtionsAy_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionWithElements(dgvShowSubscribtionsAy, txtSubsnoAy, txtSubsPriceAy, lbxSubsFeaturesAy);
        }

        private void cbxSubsTypeAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSelectionWithtxt(cbxSubsTypeAy, txtSubsPeriodAy);
        }

        private void btnDelSelectedSubsAy_Click(object sender, EventArgs e)
        {
            DelSelection(lbxSubsFeaturesAy);
        }

        private void btnDelLastSubsFeaturesAy_Click(object sender, EventArgs e)
        {
            DelLastSelcted(lbxSubsFeaturesAy);
        }

        private void btnDelAllSubsFeaturesAy_Click(object sender, EventArgs e)
        {
            DelAllItems(lbxSubsFeaturesAy);
        }

        private void btnAddNewAy_Click(object sender, EventArgs e)
        {
            AutoClear(txtSubsPriceAy, lbxSubsFeaturesAy);
        }

        private void btnEditSubsAy_Click(object sender, EventArgs e)
        {
            EditingData(txtSubsnoAy, txtSubsPriceAy, lbxSubsFeaturesAy, lblMsgAy);
            ShowData("in(21,22,23,24,25)", dgvShowSubscribtionsAy, cbxSubsTypeAy, txtSubsPeriodAy);
        }

        private void btnAddFeaturesAy_Click(object sender, EventArgs e)
        {
            AddFeatures(txtSubsFeaturesAy, lbxSubsFeaturesAy);
        }

        private void dgvShowSubscribtionsZomba_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionWithElements(dgvShowSubscribtionsZomba, txtSubsnoZomba, txtSubsPriceZomba, lbxSubsFeaturesZomba);
        }

        private void cbxSubsTypeZomba_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSelectionWithtxt(cbxSubsTypeZomba, txtSubsPeriodZomba);
        }

        private void btnDelSelectedSubsZomba_Click(object sender, EventArgs e)
        {
            DelSelection(lbxSubsFeaturesZomba);
        }

        private void btnDelLastSubsFeaturesZomba_Click(object sender, EventArgs e)
        {
            DelLastSelcted(lbxSubsFeaturesZomba);
        }

        private void btnDelAllSubsFeaturesZomba_Click(object sender, EventArgs e)
        {
            DelAllItems(lbxSubsFeaturesZomba);
        }

        private void btnAddNewZomba_Click(object sender, EventArgs e)
        {
            AutoClear(txtSubsPriceZomba, lbxSubsFeaturesZomba);
        }

        private void btnEditSubsZomba_Click(object sender, EventArgs e)
        {
            EditingData(txtSubsnoZomba, txtSubsPriceZomba, lbxSubsFeaturesZomba, lblMsgZomba);
            ShowData("in(26,27,28,29,30)", dgvShowSubscribtionsZomba, cbxSubsTypeZomba, txtSubsPeriodZomba);
        }

        private void btnAddFeaturesZomba_Click(object sender, EventArgs e)
        {
            AddFeatures(txtSubsFeaturesZomba, lbxSubsFeaturesZomba);
        }

        private void cbxSubsTypeOther_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSelectionWithtxt(cbxSubsTypeOther, txtSubsPeriodOther);
        }

        private void dgvShowSubscribtionsOther_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionWithElements(dgvShowSubscribtionsOther, txtSubsnoOther, txtSubsPriceOther, lbxSubsFeaturesOther);
        }

        private void btnDelSelectedSubsOther_Click(object sender, EventArgs e)
        {
            DelSelection(lbxSubsFeaturesOther);
        }

        private void btnDelLastSubsFeaturesOther_Click(object sender, EventArgs e)
        {
            DelLastSelcted(lbxSubsFeaturesOther);
        }

        private void btnDelAllSubsFeaturesOther_Click(object sender, EventArgs e)
        {
            DelAllItems(lbxSubsFeaturesOther);

        }

        private void btnAddNewOther_Click(object sender, EventArgs e)
        {
            AutoClear(txtSubsPriceOther, lbxSubsFeaturesOther);
        }

        private void btnEditSubsOther_Click(object sender, EventArgs e)
        {
            EditingData(txtSubsnoOther, txtSubsPriceOther, lbxSubsFeaturesOther, lblMsgOther);
            ShowData("in(31,32,33,34,35)", dgvShowSubscribtionsOther, cbxSubsTypeOther, txtSubsPeriodOther);
        }

        private void btnAddFeaturesOther_Click(object sender, EventArgs e)
        {
            AddFeatures(txtSubsFeaturesOther, lbxSubsFeaturesOther);
        }
    }
}
