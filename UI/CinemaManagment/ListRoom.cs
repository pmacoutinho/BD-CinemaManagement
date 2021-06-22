using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class ListRoom : Form
    {
        public ListRoom()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            dataGridViewRooms.EnableHeadersVisualStyles = false;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        public String buttonClicked = "";

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
