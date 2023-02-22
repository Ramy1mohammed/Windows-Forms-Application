using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FrmShowAllEmps : Form
    {
        public FrmShowAllEmps()
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
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                dgvShowEmp.Height = 551;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                dgvShowEmp.Height = this.Height - (pnlHead.Height + txtEmpSearch.Height + 120);
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtEmpSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(Vars.tblShowAllEmps);
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

        private void FrmShowAllEmps_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            dgvShowEmp.DataSource = Vars.tblShowAllEmps;
        }

        private void rdoEmpName_Click(object sender, EventArgs e)
        {
            txtEmpSearch.Select();
            txtEmpSearch.Focus();
        }

        private void txtEmpSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdoEmpssn.Checked)
            {
               new FrmEmployee().txtEmpSsn_KeyPress(sender, e);
            }
            else if (rdoEmpName.Checked || rdoDept.Checked || rdoJobtype.Checked)
            {
                new FrmEmployee().txtEmpName_KeyPress(sender, e);
            }
        }
    }
}
