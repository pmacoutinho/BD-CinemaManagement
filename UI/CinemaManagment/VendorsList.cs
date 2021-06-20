using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class FormVendorList : Form
    {
        public FormVendorList()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            dataGridViewVendors.EnableHeadersVisualStyles = false;
            dataGridViewVendors.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            dataGridViewVendors.Rows.Add(
                new object[]
                {
                    1111,
                    "William Regal",
                    "9-12",
                    "John Samuel"
                }
                );

            dataGridViewVendors.Rows.Add(
                new object[]
                {
                    2222,
                    "Michael Garrison",
                    "13-17",
                    "Paula Andrews"
                }
                );

            dataGridViewVendors.Rows.Add(
                new object[]
                {
                    2222,
                    "Michael Garrison",
                    "13-17",
                    "Paula Andrews"
                }
                );

            dataGridViewVendors.Rows.Add(
                new object[]
                {
                    2222,
                    "Michael Garrison",
                    "13-17",
                    "Paula Andrews"
                }
                );
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            MainMenu form1 = new MainMenu();
            form1.openChildForm(addEmployee);
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }


    }
}
