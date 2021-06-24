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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_seller_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
