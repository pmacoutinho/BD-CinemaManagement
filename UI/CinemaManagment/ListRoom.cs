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
    public partial class ListRoom : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListRoom()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewRooms.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRooms.EnableHeadersVisualStyles = false;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }
        private void loadTable()
        {
            Login login = new Login();
            int cinema = login.getCinema();

            dataGridViewRooms.ReadOnly = true;
            dataGridViewRooms.DataSource = Management.loadRooms(cinema);
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {

            Debug.WriteLine(dataGridViewRooms.SelectedRows[0].DataBoundItem.ToString());
            Room r = (Room) dataGridViewRooms.SelectedRows[0].DataBoundItem;
            
            AddRoom addRoom = new AddRoom(r);
            addRoom.Show();
        }

        private void rBtn_refresh_Click_1(object sender, EventArgs e)
        {
            loadTable();
        }

        private void rBtn_delete_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
