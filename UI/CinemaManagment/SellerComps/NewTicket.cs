using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagment.Entities;
using CinemaManagment.sgbd;

namespace CinemaManagment.SellerComps
{
    public partial class NewTicket : Form
    {
        private Employee e;
        private int selectedClientIdx, selectedSessionIdx;
        List<Client> cList = Operations.loadClients();
        private List<SessionInstance> sList;
        private List<int> seatList;
        public NewTicket()
        {
            InitializeComponent();
            LOAD();
        }

        public NewTicket(int empId)
        {
            InitializeComponent();
            this.e = Management.getEmployee(empId);
            sList = PublicAccess.getOpenSessionsCinema(DateTime.Today, e.cinema);
            LOAD();
        }

        private void LOAD()
        {
            fillClientList();
            fillSessionList();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fillClientList()
        {
            lst_box_client.Items.Clear();


            foreach (var elem in cList)
            {
                lst_box_client.Items.Add(elem.ToSimpleString());
            }
        }

        private void lst_box_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_box_client.SelectedIndex >= 0)
            {
                selectedClientIdx = lst_box_client.SelectedIndex;

            }
        }

        private void lstBox_sessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_box_client.SelectedIndex >= 0)
            {
                selectedSessionIdx = lstBox_sessions.SelectedIndex;
                fillSeatList(sList[selectedSessionIdx].id);
            }
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();

            t.client = cList[selectedClientIdx].id;
            t.session = sList[selectedSessionIdx].id;
            t.price = 10;
            t.seller = this.e.id;
            t.seatnumber = 20;

            Operations.newTicket(t);
        }

        private void fillSessionList()
        {
            lstBox_sessions.Items.Clear();

            

            foreach (var elem in sList)
            {
                lstBox_sessions.Items.Add(elem.ToSimpleString());

            }
        }

        private void fillSeatList(int sessionId)
        {
            lst_box_seats.Items.Clear();

            Reservation r = Operations.getSeats(sessionId);

            var numberList = Enumerable.Range(1, r.nSeats).ToList();

            foreach (var elem in r.lst)
            {
                numberList.Remove(elem);
            }

            foreach (var elem in numberList)
            {
                lst_box_seats.Items.Add(elem.ToString());
            }
        }
    }
}
