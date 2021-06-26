using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    public class Client
    {
        public int id = -1;
        public String name;
        public String email;
        public DateTime birthday;

        public string ToSimpleString()
        {
            return "" + id + ":  " + name;
        }
    }
}
