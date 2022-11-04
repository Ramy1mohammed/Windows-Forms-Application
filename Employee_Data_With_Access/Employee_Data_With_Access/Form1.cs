using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Data_With_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_DataDataSet1.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.employee_DataDataSet1.emp);

            this.reportViewer1.RefreshReport();
        }
    }
}
