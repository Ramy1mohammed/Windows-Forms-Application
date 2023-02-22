using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Gym
{
    public partial class FrmMian : Form
    {
        public FrmMian()
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
            if(pt!=Point.Empty)
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
        private void FrmMian_Load(object sender, EventArgs e)
        {
            DB.Open();
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            Bitmap bmp= new Bitmap(Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName).ToBitmap(),new Size(PicIcon.Width,PicIcon.Height));
            PicIcon.Image = bmp;
            tsLabelHeadLines.Text = "الرئيـسيه";
        }

        public void btnShowEmpForm_Click(object sender, EventArgs e)
        {
        FrmEmployee frm = new FrmEmployee();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmEmployee)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "اداره الموظفين";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
            tsLabelHeadLines.Text = "اداره الموظفين";
        }

        public void btnShowDepartments_Click(object sender, EventArgs e)
        {
            FrmDepartment frmdept = new FrmDepartment();
            frmdept.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmDepartment)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "اداره الأقسام";
                    return;
                }
            }
            
            
            frmdept.Dock = DockStyle.Fill;
            DB.cmd.Parameters.Clear();
            frmdept.Show();
            tsLabelHeadLines.Text = "اداره الأقسام";
        }

        private void FrmMian_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void btnShowSubscription_Click(object sender, EventArgs e)
        {
            FrmSubscriptionManage frmSubsciption = new FrmSubscriptionManage();
            frmSubsciption.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmSubscriptionManage)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "اداره الاشتراكات";
                    return;
                }
            }


            frmSubsciption.Dock = DockStyle.Fill;
            DB.cmd.Parameters.Clear();
            frmSubsciption.Show();
            tsLabelHeadLines.Text = "اداره الاشتراكات";
        }

        private void btnShowTrainee_Click(object sender, EventArgs e)
        {
            FrmTrainee frm = new FrmTrainee();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmTrainee)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "اداره المشتركين";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            DB.cmd.Parameters.Clear();
            frm.Show();
            tsLabelHeadLines.Text = "اداره المشتركين";
        }

        private void btnShowTrainingMap_Click(object sender, EventArgs e)
        {
            FrmTrainingMap frm = new FrmTrainingMap();
            frm.MdiParent = this;
            foreach (Form f in System.Windows.Forms.Application.OpenForms)
            {
                if(f is FrmTrainingMap)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "الخطط التدريبيه";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            DB.cmd.Parameters.Clear();
            frm.Show();
            tsLabelHeadLines.Text = "الخطط التدريبيه";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmRegieme frm = new FrmRegieme();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmRegieme)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "النظام التدريبي";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
            tsLabelHeadLines.Text = "النظام التدريبي";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmMachine frm = new FrmMachine();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmMachine)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "اداره الأجهزه";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            DB.cmd.Parameters.Clear();
            frm.Show();
            tsLabelHeadLines.Text = "اداره الأجهزه";
        }

        private void tsShowEmployeePrAb_Click(object sender, EventArgs e)
        {
            FrmEmployeePrecenceAndAbscence frm = new FrmEmployeePrecenceAndAbscence();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmEmployeePrecenceAndAbscence)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "الحضور والاجازات";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            DB.cmd.Parameters.Clear();
            frm.Show();
            tsLabelHeadLines.Text = "الحضور والاجازات";
        }

        private void tsShowSupplimentsAndProducts_Click(object sender, EventArgs e)
        {
            FrmProductsAndSuppliments frm = new FrmProductsAndSuppliments();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmProductsAndSuppliments)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "المكملات الغذائيه"+Environment.NewLine+"والمنتجات الاخرى";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
            tsLabelHeadLines.Text = "المكملات الغذائيه" + Environment.NewLine + "والمنتجات الاخرى";
        }

        private void tsbtnEmployeeBorrow_Click(object sender, EventArgs e)
        {
            FrmEmoployeeBorrow frm = new FrmEmoployeeBorrow();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmEmoployeeBorrow)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "اداره السلف ";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
            tsLabelHeadLines.Text = "اداره السلف ";
        }

        private void tsbtnShowFrmCheife_Click(object sender, EventArgs e)
        {
            FrmGymCheife frm = new FrmGymCheife();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmGymCheife)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "رئيس مجلس الاداره";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
            tsLabelHeadLines.Text = "رئيس مجلس الاداره";
        }

        private void tsbtnShowNotify_Click(object sender, EventArgs e)
        {
            FrmAlertAndNotify frm = new FrmAlertAndNotify();
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmAlertAndNotify)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "اشعارات وانذارات";
                    return;
                }
            }
            frm.ShowDialog();
            tsLabelHeadLines.Text = "اشعارات وانذارات";
        }

        private void tsbtnShowFrmCalculateIncome_Click(object sender, EventArgs e)
        {
            FrmGetGymBuyings frm = new FrmGetGymBuyings();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmGetGymBuyings)
                {
                    f.Activate();
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsbtnShowNurtionSales_Click(object sender, EventArgs e)
        {
            FrmNurtionSales frm = new FrmNurtionSales();
            frm.MdiParent = this;
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmNurtionSales)
                {
                    f.Activate();
                    tsLabelHeadLines.Text = "مبيعات\r\nالمكملات الغذائيه";
                    return;
                }
            }
            frm.Dock = DockStyle.Fill;
            frm.Show();
            tsLabelHeadLines.Text = "مبيعات\r\nالمكملات الغذائيه";
        }
    }
}
