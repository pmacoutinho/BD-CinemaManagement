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
    public partial class ListClient : Form
    {
        public ListClient()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            dataGridViewClients.EnableHeadersVisualStyles = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        public String buttonClicked = "";

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            buttonClicked = "edit";
            AddClient addClient = new AddClient();
            addClient.Show();
        }
    }
}
