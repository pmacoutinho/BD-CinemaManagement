using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class ListWorker : Form
    {
        public ListWorker()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            dataGridViewWorker.EnableHeadersVisualStyles = false;
            dataGridViewWorker.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            dataGridViewWorker.Rows.Add(
                new object[]
                {
                    1111,
                    "William Regal",
                    "9-12",
                    "John Samuel"
                }
                );

            dataGridViewWorker.Rows.Add(
                new object[]
                {
                    2222,
                    "Michael Garrison",
                    "13-17",
                    "Paula Andrews"
                }
                );

            dataGridViewWorker.Rows.Add(
                new object[]
                {
                    2222,
                    "Michael Garrison",
                    "13-17",
                    "Paula Andrews"
                }
                );

            dataGridViewWorker.Rows.Add(
                new object[]
                {
                    2222,
                    "Michael Garrison",
                    "13-17",
                    "Paula Andrews"
                }
                );
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        public static String employeeType = "";
        public String getEmployeeType()
        {
            return employeeType;
        }
        public void setEmployeeType(String type)
        {
            employeeType = type;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            setEmployeeType("worker");
            buttonClicked = "add";
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            setEmployeeType("worker");
            buttonClicked = "edit";
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }
    }
}
