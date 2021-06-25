using CinemaManagment.Entities;
using CinemaManagment.sgbd;
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
            dataGridViewRooms.EnableHeadersVisualStyles = false;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }
        private void loadTable()
        {
            var select = "SELECT num AS 'Num', nSeats AS 'Capacity' " +
                "FROM Management.Room WHERE cinema=1";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewRooms.ReadOnly = true;
            dataGridViewRooms.DataSource = ds.Tables[0];
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
            buttonClicked = "edit";
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
        }
    }
}
