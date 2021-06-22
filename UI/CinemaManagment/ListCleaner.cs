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
    public partial class ListCleaner : Form
    {
        public ListCleaner()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            dataGridViewCleaners.EnableHeadersVisualStyles = false;
            dataGridViewCleaners.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            buttonClicked = "edit";
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }
    }
}
