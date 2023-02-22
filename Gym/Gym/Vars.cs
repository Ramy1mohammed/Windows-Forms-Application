using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Gym
{
    internal class Vars
    {
        public static List<Tuple<int, string>> elements = new List<Tuple<int, string>>();
        public static DataTable tblShowAllEmps = new DataTable();
        public static DataTable tblShowAllTrainee = new DataTable();
    }
}
