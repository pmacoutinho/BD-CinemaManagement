using CinemaManagment.Entities;
using CinemaManagment.sgbd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class ListWorker : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListWorker()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewWorker.EnableHeadersVisualStyles = false;
            dataGridViewWorker.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {
            var select = "SELECT * FROM Management.viewWorkers";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewWorker.ReadOnly = true;
            dataGridViewWorker.DataSource = ds.Tables[0];
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
