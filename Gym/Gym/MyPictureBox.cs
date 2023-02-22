using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Gym
{
    class MyPictureBox : PictureBox
    {

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, Width - 5, Height - 5);
            this.Region = new Region(gp);
        }
    }
}
