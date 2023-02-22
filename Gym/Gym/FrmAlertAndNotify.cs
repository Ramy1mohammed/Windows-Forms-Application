using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmAlertAndNotify : Form
    {
        public FrmAlertAndNotify()
        {
            InitializeComponent();
        }

        Point pt = Point.Empty;
        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = new Point(e.X, e.Y);
                pnlHead.Cursor = Cursors.Hand;
            }
        }

        private void pnlHead_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = Point.Empty;
                pnlHead.Cursor = Cursors.Default;
            }
        }

        private void pnlHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (pt != Point.Empty)
            {
                this.Location = new Point(Left + e.X - pt.X, Top + e.Y - pt.Y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
            else WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        DataTable tblGetTrEndedSubs = new DataTable();
        SansationRoundButton[] btnConfirmRenew = new SansationRoundButton[1];
        string[] getSubsType = new string[1];
        

        private void GetTrEndedSubs()
        {
            tblGetTrEndedSubs.Rows.Clear();
            DB.GetData("select trno,trname,trimage,subscriptiontype,subscriptionstart,subscriptionend,exercisetype from Trainee where subscriptionend='" + DateTime.Now.ToShortDateString() + "'", tblGetTrEndedSubs);
          
            int SetTop = 20;
            for (int x = 0; x < tblGetTrEndedSubs.Rows.Count; x++)
            {
                Label lblDetails = new Label();
                MyPictureBox Trpic = new MyPictureBox();
                lblDetails.Font = new Font(this.Font.FontFamily, 12); lblDetails.ForeColor = Color.Yellow;
                lblDetails.AutoSize = true;

                lblDetails.Text = "كود المشترك : " + tblGetTrEndedSubs.Rows[x][0].ToString() + Environment.NewLine
                               + "اسم المشترك : " + tblGetTrEndedSubs.Rows[x][1].ToString() + Environment.NewLine
                               + "نوع الاشتراك : " + tblGetTrEndedSubs.Rows[x][3].ToString() + Environment.NewLine
                      + "تاريخ بدايه الاشتراك : " + tblGetTrEndedSubs.Rows[x][4].ToString() + Environment.NewLine
                               + " تاريخ انتهاء الاشتراك => اليوم : " + tblGetTrEndedSubs.Rows[x][5].ToString() + Environment.NewLine
                               + "نوع التمرين : " + tblGetTrEndedSubs.Rows[x][6].ToString();

                lblDetails.Left = (this.Width - lblDetails.Width) / 2;
                lblDetails.Top = SetTop;
                Trpic.Size = new Size(150, 150);
                Trpic.Left = lblDetails.Width - 10;
                Trpic.Top = SetTop;
                Trpic.BorderStyle = BorderStyle.Fixed3D;
                Trpic.SizeMode = PictureBoxSizeMode.StretchImage;
                MemoryStream ms = new MemoryStream((byte[])tblGetTrEndedSubs.Rows[x][2]);
                Trpic.Image = Image.FromStream(ms);
                btnConfirmRenew[x] = new SansationRoundButton();

                btnConfirmRenew[x].BackColor = Color.Pink;
                btnConfirmRenew[x].Text = "التجديد التلقائى";
                btnConfirmRenew[x].AutoSize = true;
                btnConfirmRenew[x].Font = new Font(this.Font.FontFamily, 12);
                btnConfirmRenew[x].BackColorMouseOver = Color.LawnGreen;
                btnConfirmRenew[x].Left = (this.Width - 320);
                btnConfirmRenew[x].Top = SetTop;

                getSubsType[x] = tblGetTrEndedSubs.Rows[x][3].ToString();
                pnlAlertAndNotify.Controls.Add(btnConfirmRenew[x]);
                pnlAlertAndNotify.Controls.AddRange(new Control[] { lblDetails, Trpic  });

              

                Label lblline = new Label();
                lblline.ForeColor = Color.Yellow;
                lblline.Font = new Font(this.Font.FontFamily, 12);
                lblline.Width = this.Width;
                lblline.AutoSize = true;
                lblline.Text = "____________________________________________________________________________________________________________________________________________";

                if (SetTop >= 20)
                {
                    lblline.Top = SetTop + 170;
                    pnlAlertAndNotify.Controls.Add(lblline);
                }

                SetTop += 200;

                if (x == tblGetTrEndedSubs.Rows.Count - 1)
                {
                    break;
                }
                Array.Resize(ref btnConfirmRenew, btnConfirmRenew.Length + 1);
                Array.Resize(ref getSubsType, getSubsType.Length + 1);
            }

        }
       
        private void RenewSubs()
        {            
            foreach (Control c in pnlAlertAndNotify.Controls)
            {
                if(c is SansationRoundButton)
                {
                    c.Click += delegate {

                        int CalcDays = 0;
                        if (getSubsType[ pnlAlertAndNotify.Controls.IndexOf(c) / 4] .Contains("اسبوعى"))
                            CalcDays = 7;
                        else if (getSubsType[pnlAlertAndNotify.Controls.IndexOf(c) / 4] .Contains("شهرى"))
                            CalcDays = 30;
                        else if (getSubsType[pnlAlertAndNotify.Controls.IndexOf(c) / 4] .Contains("ثلاث شهور"))
                            CalcDays = 90;
                        else if (getSubsType[pnlAlertAndNotify.Controls.IndexOf(c) / 4].Contains( "ست شهور"))
                            CalcDays = 180;
                        else if (getSubsType[pnlAlertAndNotify.Controls.IndexOf(c) / 4] .Contains( "سنوى"))
                            CalcDays = 365;
                        DB.Run("update Trainee set subscriptionstart='" + DateTime.Now + "',subscriptionend='" + DateTime.Now.AddDays(CalcDays) + "' where trno=" + tblGetTrEndedSubs.Rows[pnlAlertAndNotify.Controls.IndexOf(c)/4][0]);

                        FrmConfirmDel frm = new FrmConfirmDel();
                        frm.lblHeader.Text = "تم التجديد التلقائى للمشترك ";
                        frm.btnNo.Visible = false;
                        frm.btnYes.Text = "موافق";
                        frm.btnYes.Left = (frm.Width - frm.btnYes.Width) / 2;
                        frm.ShowDialog();
                    };
                }
            }
        }
        private void FrmAlertAndNotify_Load(object sender, EventArgs e)
        {
            GetTrEndedSubs();
            RenewSubs();
        }

        private void FrmAlertAndNotify_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmTrainee)
                {
                    Application.OpenForms["FrmTrainee"].Close();
                    break;
                }
            }
        }
    }
}
