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
    public partial class ListClient : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListClient()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewClients.EnableHeadersVisualStyles = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {var select = "SELECT * FROM Operations.viewClients";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewClients.ReadOnly = true;
            dataGridViewClients.DataSource = ds.Tables[0];
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            buttonClicked = "edit";
            AddClient addClient = new AddClient();
            addClient.Show();
        }
    }
}
