 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    class Employee
    {
        public int id;
        public string name;
        public string email;
        public int cinema;
        public int shift;
        public int type;

        public string ToSimpleString()
        {
            return "" + id + ":  " + name;
        }

    }
}
