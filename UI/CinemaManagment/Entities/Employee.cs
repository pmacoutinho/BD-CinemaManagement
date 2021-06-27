 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email{ get; set; }
        public int cinema{ get; set; }
        public int shift{ get; set; }
        public int type{ get; set; }

        public string ToSimpleString()
        {
            return "" + id + ":  " + name;
        }

    }
}
