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
    public partial class AddRoom : Form
    {
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
    }
}
