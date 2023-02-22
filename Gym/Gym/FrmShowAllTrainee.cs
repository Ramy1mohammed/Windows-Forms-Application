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
    public partial class FrmShowAllTrainee : Form
    {
        public FrmShowAllTrainee()
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
                dgvShowTrainee.Height = 551;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                dgvShowTrainee.Height = this.Height - (pnlHead.Height + txtTrSearch.Height + 120);
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmShowAllTrainee_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            dgvShowTrainee.DataSource = Vars.tblShowAllTrainee;
        }

        private void txtTrSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(Vars.tblShowAllTrainee);
            string strFiltered = "";

            if (rdoTrName.Checked)
            {
                strFiltered = "trname like'%" + txtTrSearch.Text + "%'";
            }
            else if (rdoTrSsn.Checked)
            {
                strFiltered = "trssn like'%" + txtTrSearch.Text + "%'";
            }
            else if (rdoTrCoach.Checked)
            {
                strFiltered = "trcoach like'%" + txtTrSearch.Text + "%'";
            }
            else if (rdoTrSubsType.Checked)
            {
                strFiltered = "subscriptiontype like'%" + txtTrSearch.Text + "%'";
            }
            else if (rdoTrCode.Checked)
            {
                if (txtTrSearch.Text.Trim() == "")
                    strFiltered = "trname like'%%'";
                else
                    strFiltered = "trno=" + txtTrSearch.Text;
            }

            dv.RowFilter = strFiltered;
            dgvShowTrainee.DataSource = dv;
        }

        private void rdoTrCode_Click(object sender, EventArgs e)
        {
            txtTrSearch.Focus();
            txtTrSearch.Select();
        }
    }
}
