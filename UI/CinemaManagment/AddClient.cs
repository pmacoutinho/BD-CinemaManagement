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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            ListClient listClient = new ListClient();
            if (listClient.getButtonClicked() == "edit")
                labelAddClient.Text = "Edit Client";
            else
                labelAddClient.Text = "Add Client";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
