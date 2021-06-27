using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagment.Common;
using CinemaManagment.Entities;
using CinemaManagment.sgbd;

namespace CinemaManagment
{
    public partial class AddTicket : Form
    {
        private Employee e;
        
        public int result { get; set; }
        private int chosenIdx = 0;
        private List<Employee> eLst;
        private List<Client> cList;
        private List<SessionInstance> sList;
        private List<int> seatList;

        private int selectedSession = 0;
        

        public AddTicket()
        {
            InitializeComponent();

            e = User.getEmployee();
            
            eLst = Management.loadSellers();
            cList = Operations.loadClients();
            sList = Operations.loadSessionInstances(e.cinema);
            seatList = new List<int>();
            
            customizeDesign();
        }

        private void customizeDesign()
        {
            loadSeller();
            loadClient();
            loadSession();
        }

        private void loadSeller()
        {
            comboBoxSeller.Items.Clear();

            int count = 0;
            foreach (var c in eLst)
            {
                comboBoxSeller.Items.Add(c.ToSimpleString());
                
                if (c.id == e.id)
                {
                    comboBoxSeller.SelectedIndex = count;
                }

                count++;
            }

            
        }

        private void loadClient()
        {
            comboBoxClient.Items.Clear();

            foreach (var elem in cList)
            {
                comboBoxClient.Items.Add(elem.ToSimpleString());
            }
        }

        private void loadSession()
        {
            comboBoxSession.Items.Clear();

            foreach (var elem in sList)
            {
                comboBoxSession.Items.Add(elem.ToSimpleString());
            }
        }

        private void loadSeat()
        {
            comboBoxSeat.Items.Clear();

            int sessionId = sList[selectedSession].id;

            Reservation r = Operations.getSeats(sessionId);

            var numberList = Enumerable.Range(1, r.nSeats).ToList();

            foreach (var elem in r.lst)
            {
                numberList.Remove(elem);
            }

            foreach (var elem in numberList)
            {
                comboBoxSeat.Items.Add(elem.ToString());
            }

            seatList = numberList;
        }

        private void comboBoxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSession = comboBoxSession.SelectedIndex;
            loadSeat();
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();

            t.seller = eLst[comboBoxSeller.SelectedIndex].id;
            
            t.client = cList[comboBoxClient.SelectedIndex].id;
            t.session = sList[comboBoxSession.SelectedIndex].id;
            t.seatnumber = seatList[comboBoxSeat.SelectedIndex];

            t.price = 10;
            Operations.newTicket(t);
            this.Close();
        }
    }
}
