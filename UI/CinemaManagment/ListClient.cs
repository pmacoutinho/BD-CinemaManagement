using CinemaManagment.Entities;
using CinemaManagment.sgbd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        private int selectedClient;
        private List<Client> clientList;

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

            var empList = ds.Tables[0].AsEnumerable()
                .Select(dataRow => new Client
                {
                    id = dataRow.Field<int>("Id"),
                    name = dataRow.Field<string>("Name"),
                    email = dataRow.Field<string>("Email"),
                    birthday = dataRow.Field<DateTime>("Date of Birth")

                }).ToList();
            this.clientList = empList;
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
            AddClient addClient = new AddClient(clientList[selectedClient]);
            addClient.Show();
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridView dgv = sender as DataGridView;
            /*
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                selectedClient = dgv.CurrentRow.Index;
                Debug.WriteLine(selectedClient);
            }*/
            selectedClient = dgv.SelectedRows[0].Index;
            Debug.WriteLine(selectedClient);

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void rbtn_delete_Click(object sender, EventArgs e)
        {
           
            Operations.deleteClient(clientList[selectedClient].id);
            loadTable();
        }
    }
}
