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
    public partial class FrmGetGymBuyings : Form
    {
        public FrmGetGymBuyings()
        {
            InitializeComponent();
        }
        DataTable tblGetEmpResponsible = new DataTable();

        DataTable tblGetBuingDetails = new DataTable();
        DataTable tblGetBuing = new DataTable();
        DataTable tblGetAll = new DataTable();

        private void GeyEmpResponsible()
        {
            tblGetEmpResponsible.Rows.Clear();
            DB.GetData("select empno , empname from GymEmployee where jobtype='موظف شئون عاملين'", tblGetEmpResponsible);

            cbxResponsibleEmp.DataSource = tblGetEmpResponsible;
            cbxResponsibleEmp.DisplayMember = tblGetEmpResponsible.Columns[1].ToString();
             cbxResponsibleEmp.ValueMember = tblGetEmpResponsible.Columns[0].ToString();
        }

        private  void GetBuingDetails()
        {

            tblGetBuing.Rows.Clear();
            tblGetBuingDetails.Rows.Clear();
            tblGetAll.Rows.Clear();
            DB.GetData("select * from GetBuingDetailsData", tblGetBuingDetails);
            DB.GetData("select * from GymBuing", tblGetBuing);

            if (tblGetBuingDetails.Rows.Count > 0)
            {
                if (tblGetAll.Columns.Count < 1)
                {
                    tblGetAll.Columns.Add("invno");
                    tblGetAll.Columns.Add("empno", typeof(int));
                    tblGetAll.Columns.Add("empname");
                    tblGetAll.Columns.Add("buyingdate", typeof(DateTime));
                    tblGetAll.Columns.Add("thingimage", typeof(byte[]));
                    tblGetAll.Columns.Add("thingbyiedname");
                    tblGetAll.Columns.Add("thingqty");
                    tblGetAll.Columns.Add("thingprice");

                    for (int x = 0; x < tblGetBuingDetails.Rows.Count; x++)
                    {
                        DataRow row = tblGetAll.NewRow();
                        row[0] = tblGetBuingDetails.Rows[x][0];
                        row[1] = tblGetBuingDetails.Rows[x][1];
                        row[2] = tblGetBuingDetails.Rows[x][2];
                        row[3] = tblGetBuingDetails.Rows[x][3];
                        row[4] = tblGetBuingDetails.Rows[x][4];
                        DataRow[] rowbuyingname = tblGetBuing.Select("invno=" + tblGetBuingDetails.Rows[x][0]);
                        string strbuyname = "";
                        string strprice = "";
                        string strqty = "";
                        foreach (DataRow i in rowbuyingname)
                        {
                            strbuyname += i[1] + Environment.NewLine;
                            strqty += i[2] + Environment.NewLine;
                            strprice += i[3] + Environment.NewLine;
                        }
                        row[5] = strbuyname;
                        row[6] = strqty;
                        row[7] = strprice;
                        tblGetAll.Rows.Add(row);
                    }
                    dgvShowIncome.DataSource = tblGetAll;
                }
            }
        }
        private void btnNewIncome_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCalculateIncome_Load(object sender, EventArgs e)
        {

            DB.cmd.CommandType = CommandType.Text;
            GeyEmpResponsible();
            GetBuingDetails();

            this.Activated += delegate {
                DB.cmd.CommandType = CommandType.Text;
                GeyEmpResponsible();

                GetBuingDetails();
            };
        }

        private void btnAddInvPic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Filter = "Images|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(Image.FromFile(ofd.FileName), new Size(150, 150));
                    picInvImage.Image = bmp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            try
            {
                DB.cmd.Parameters.Clear();
                DB.cmd.Parameters.AddWithValue("@incomedate", dtpBuingDate.Value);

                if (picInvImage.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    picInvImage.Image.Save(ms,ImageFormat.Jpeg);
                    DB.cmd.Parameters.AddWithValue("@InvImage",ms.ToArray());
                }
                var r = from getinvno in tblGetAll.AsEnumerable()
                        select getinvno[0];
                foreach (var i in r)
                {
                    if(txtInvBuingNo.Text==i.ToString())
                    {
                        DB.Run("insert into GymBuing values('" + txtInvBuingNo.Text + "','" + txtBuingProdName.Text + "'," + txtProdQty.Text + "," + txtProdOneItemPrice.Text + ")");

                        GetBuingDetails();
                        return;
                    }
                }
                DB.Run("insert into GymBuingThingDetail values('" + txtInvBuingNo.Text + "'," + cbxResponsibleEmp.SelectedValue + ",@incomedate,@InvImage)");
                DB.Run("insert into GymBuing values('" + txtInvBuingNo.Text + "','" + txtBuingProdName.Text + "'," + txtProdQty.Text + "," + txtProdOneItemPrice.Text + ")");
                GetBuingDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShowIncome_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowIncome.CurrentRow != null)
                {
                    //txtInvBuingNo.Text = dgvShowIncome.CurrentRow.Cells["colInvno"].Value.ToString();
                    //dtpBuingDate.Value = (DateTime)dgvShowIncome.CurrentRow.Cells["colBuyDate"].Value;
                    //txtBuingProdName.Text = dgvShowIncome.CurrentRow.Cells["colBuiedProduct"].Value.ToString();
                    //txtProdQty.Text = dgvShowIncome.CurrentRow.Cells["colBuiedQty"].Value.ToString();

                    //txtTotalProdPrice.Text = dgvShowIncome.CurrentRow.Cells["colTotalBuiedProduct"].Value.ToString();
                    //cbxResponsibleEmp.Text = dgvShowIncome.CurrentRow.Cells["colBuyingResponsible"].Value.ToString();
                    
                    //MemoryStream ms = new MemoryStream((byte[])dgvShowIncome.CurrentRow.Cells["colProdImage"].Value);
                  
                    //picInvImage.Image =Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
