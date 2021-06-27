using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    class SessionInstance
    {
        public bool fullLoaded = false;

        [DisplayName("Film")]
        public String filmName { get; set; }

        public Film film;
        public int sessionId;
        public Cinema cinema;
        public int CinemaId = -1;
        public int filmId = -1;
        public DateTime startDay;
        public int noWeeks;

        //instance
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Start Time")]
        public DateTime time { get; set; }

        [DisplayName("Room")]
        public int roomNumber { get; set; }


        public string ToSimpleString()
        {
            return "" + filmName + " : " + time.ToString("hh:mm") + " : " + roomNumber;
        }
    }
}
