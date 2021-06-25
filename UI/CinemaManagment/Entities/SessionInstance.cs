using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    class SessionInstance
    {
        public bool fullLoaded = false;

        public int sessionId;
        public Cinema cinema;
        public Film film;
        public int CinemaId =-1;
        public int filmId = -1;
        public DateTime startDay;
        public int noWeeks;

        //instance
        public int id;
        public DateTime time;
        public int roomNumber;


        public string ToSimpleString()
        {
            return "" + film.name + " : " + time.ToString("hh:mm") + " : " + roomNumber;
        }
    }
}
