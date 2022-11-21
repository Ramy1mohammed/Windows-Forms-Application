using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFoods
{
    internal class Vars
    {
        public static List<Tuple<int, string>> categories = new List<Tuple<int, string>>();
        public static DataTable tblAll = new DataTable();
    }
}
