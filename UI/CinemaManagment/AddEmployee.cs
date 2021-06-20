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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            comboBoxShift.Items.Add("9-12");
            comboBoxShift.Items.Add("12-15");
            comboBoxShift.Items.Add("15-18");
            comboBoxShift.Items.Add("18-21");
            comboBoxShift.Items.Add("21-00");

            comboBoxRole.Items.Add("Vendor");
            comboBoxRole.Items.Add("Cleaner");
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
