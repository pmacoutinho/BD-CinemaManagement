using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    public class Room
    {
        [DisplayName("Number")]
        public int num {get; set;}

        /* [DisplayName("Cinema")]
         public int cinema {get; set;}*/
        public int cinema;

         [DisplayName("Seats")]
        public int nSeats {get; set;}
    }
}
