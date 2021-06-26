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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class AddClient : Form
    {
        private SqlConnection cn = SGBDCon.getCN();
        private bool update = false;
        private Client c;

        public AddClient()
        {
            InitializeComponent();
            customizeDesign();
        }

        public AddClient(Client c)
        {
            InitializeComponent();
            this.c = c;
            update = true;
            customizeDesign();
            loadEmployee();
        }

        private void customizeDesign()
        {
            if (update)
            {
                labelAddClient.Text = "Edit Client";
                btn_update.Visible = true;
                roundedButtonAdd.Visible = false;
            }
            else
            {
                labelAddClient.Text = "Add Client";
                btn_update.Visible = false;
                roundedButtonAdd.Visible = true;
            }

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

        private void loadEmployee()
        {
            textBoxName.Text = c.name;
            clt_textBoxEmail.Text = c.email;
            add_client_date_picker.SetDate(c.birthday);
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            c.name = textBoxName.Text;
            c.email = clt_textBoxEmail.Text;
            c.birthday = add_client_date_picker.SelectionRange.Start.Date;

            Operations.updateClient(c);
            this.Close();
        }
    }
}
