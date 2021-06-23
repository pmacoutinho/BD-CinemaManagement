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
    public partial class AddClient : Form
    {
        private SqlConnection cn = SGBDCon.getCN();
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

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMovieTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.name = textBoxName.Text;
            c.email = clt_textBoxEmail.Text;
            c.birthday = add_client_date_picker.SelectionRange.Start.Date;

            var res = Operations.newClient(c);
            Debug.WriteLine(res);
            //Debug.WriteLine(c.birthday.ToString("yyyyMMdd"));

            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
