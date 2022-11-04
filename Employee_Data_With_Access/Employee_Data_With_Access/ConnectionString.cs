using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Employee_Data_With_Access
{
    interface ConnectionString
    {
         OleDbConnection conn { get;}
    }
}
