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
        private bool update = false;
        private Room r;

        public AddRoom()
        {
            InitializeComponent();
            customizeDesign();
        }
        
        public AddRoom(Room r)
        {
            InitializeComponent();
            this.r = r;
            update = true;
            customizeDesign();
        }

        private void customizeDesign()
        {
            if (update)
            {
                labelAddRoom.Text = "Edit Room";
                rBtn_update.Visible = true;
                roundedButtonAdd.Visible = false;


                numericUpDownNumber.Value = r.num;
                num_cinema.Value = r.cinema;
                numericUpDownCapacity.Value = r.nSeats;
            } else
            {
                labelAddRoom.Text = "Add Room";
                rBtn_update.Visible = false;
                roundedButtonAdd.Visible = true;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void rBtn_update_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room();
            newRoom.num = Convert.ToInt32(numericUpDownNumber.Value);
            newRoom.cinema = Convert.ToInt32(num_cinema.Value);
            newRoom.nSeats = Convert.ToInt32(numericUpDownCapacity.Value);
            
            Management.deleteRoom(r);
            Management.newRoom(newRoom);
            
            this.Close();
        }
        
    }
}
