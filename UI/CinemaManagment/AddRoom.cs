using CinemaManagment.Entities;
using CinemaManagment.sgbd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class AddRoom : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public AddRoom()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            ListRoom listRoom = new ListRoom();
            if (listRoom.getButtonClicked() == "edit")
                labelAddRoom.Text = "Edit Room";
            else
                labelAddRoom.Text = "Add Room";
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.num = Convert.ToInt32(numericUpDownNumber.Value);
            r.cinema = 1;
            r.nSeats = Convert.ToInt32(numericUpDownCapacity.Value);

            var res = Management.newRoom(r);
            Debug.WriteLine(res);

            this.Close();
        }
    }
}
