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

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            /*Room c = new Client();
            c.name = textBoxName.Text;
            c.email = clt_textBoxEmail.Text;
            c.birthday = add_client_date_picker.SelectionRange.Start.Date;

            var res = Operations.newClient(c);
            Debug.WriteLine(res);
            //Debug.WriteLine(c.birthday.ToString("yyyyMMdd"));

            this.Close();*/
        }
    }
}
