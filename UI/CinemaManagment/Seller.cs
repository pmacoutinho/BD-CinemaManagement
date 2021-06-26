using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagment.Entities;
using CinemaManagment.SellerComps;
using CinemaManagment.sgbd;

namespace CinemaManagment
{
    public partial class Seller : Form
    {
        private int employeeId;
        private Employee e;

        public Seller(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.e = Management.getEmployee(employeeId);
            label1.Text = e.ToSimpleString();
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_seller_Click(object sender, EventArgs e)
        {
            openChildForm(new NewTicket(employeeId));
        }
    }
}
