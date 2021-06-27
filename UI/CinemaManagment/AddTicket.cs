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
using CinemaManagment.Entities;
using CinemaManagment.sgbd;

namespace CinemaManagment
{
    public partial class AddTicket : Form
    {
        public int result { get; set; }
        private int chosenIdx = 0;
        private List<Employee> lst = Management.loadSellers();
        List<Client> cList = Operations.loadClients();
        private List<SessionInstance> sList;

        public AddTicket()
        {
            InitializeComponent();
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

            foreach (var c in lst)
            {
                comboBoxSeller.Items.Add(c.ToSimpleString());
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
            
        }
    }
}
