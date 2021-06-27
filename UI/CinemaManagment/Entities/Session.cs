using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    class Session
    {
        public int id; //necessary to load session list in 'add session instance'
        public int cinema;
        public int filmId;

        [DisplayName("Film Name")]
        public String filmName { get; set; }

        [DisplayName("Start Day")]
        public DateTime startDay { get; set; }

        [DisplayName("No Weeks")]
        public int noWeeks { get; set; }
    }
}
