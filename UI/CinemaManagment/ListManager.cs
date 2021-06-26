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
    public partial class ListManager : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListManager()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewManager.EnableHeadersVisualStyles = false;
            dataGridViewManager.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {
            var select = "SELECT * FROM Management.viewManagers";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewManager.ReadOnly = true;
            dataGridViewManager.DataSource = ds.Tables[0];
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        ListWorker listWorker = new ListWorker();
        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            listWorker.setEmployeeType("manager");
            buttonClicked = "add";
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            listWorker.setEmployeeType("manager");
            buttonClicked = "edit";
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }
    }
}
