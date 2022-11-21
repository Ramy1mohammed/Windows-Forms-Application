using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFoods
{
    public partial class FrmConfirmDel : Form
    {
        public FrmConfirmDel()
        {
            InitializeComponent();
            btnYes.DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity >= 1) timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity <= 0) this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
    }
}
