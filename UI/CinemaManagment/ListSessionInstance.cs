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
    public partial class ListSessionInstance : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListSessionInstance()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewSessionInstance.EnableHeadersVisualStyles = false;
            dataGridViewSessionInstance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {
            User u = User.getInstance();

            dataGridViewSessionInstance.ReadOnly = true;
            dataGridViewSessionInstance.DataSource = Operations.loadSessionInstances(u.e.cinema);
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddSessionInstance addSessionInstance = new AddSessionInstance();
            addSessionInstance.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            buttonClicked = "edit";
            AddSessionInstance addSessionInstance = new AddSessionInstance();
            addSessionInstance.Show();
        }
    }
}
