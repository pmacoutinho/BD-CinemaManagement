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
using CinemaManagment.Common;


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
           

            List<Employee> lst = Management.loadManagers();
            
            dataGridViewManager.ReadOnly = true;
            dataGridViewManager.DataSource = lst;
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        ListWorker listWorker = new ListWorker();
        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(User.getInstance().e.id);
            addEmployee.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            
            AddEmployee addEmployee = new AddEmployee((Employee) dataGridViewManager.CurrentRow.DataBoundItem);
            addEmployee.Show();
        }

        private void rBtn_refresh_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void rBtn_Delete_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee) dataGridViewManager.CurrentRow.DataBoundItem;
            Management.deleteEmployee(emp);
        }
    }
}
