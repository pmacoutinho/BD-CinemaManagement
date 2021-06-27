using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities 
{
    class CleaningRecord
    {
        public DateTime tm { get; set; }
        public int sCinema { get; set; }
        public int sNum{ get; set; }
        public int func{ get; set; }
    }
}
