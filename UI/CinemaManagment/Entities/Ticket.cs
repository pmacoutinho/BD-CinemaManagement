using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.Entities
{
    class Ticket
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Price")]
        public float price { get; set; }

        [DisplayName("Client")]
        public String clientName { get; set; }

        [DisplayName("Seller")]
        public String sellerName { get; set; }

        public int client;
        public int seller;
        public int session;
        public int seatnumber;
    }
}
