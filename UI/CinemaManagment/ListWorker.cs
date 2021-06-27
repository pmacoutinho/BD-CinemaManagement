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
            List<Employee> lst = Management.loadNonManagers(User.getInstance().e.cinema);
            
            dataGridViewWorker.ReadOnly = true;
            dataGridViewWorker.DataSource = lst;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(User.getInstance().e.cinema);
            addEmployee.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee((Employee) dataGridViewWorker.CurrentRow.DataBoundItem);
            addEmployee.Show();
        }

        private void rBnt_Delete_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee) dataGridViewWorker.CurrentRow.DataBoundItem;
            Management.deleteEmployee(emp);
        }

        private void rBtn_refresh_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}
