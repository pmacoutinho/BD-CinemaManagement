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
    public partial class ListTicketHistory : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListTicketHistory()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewTicket.EnableHeadersVisualStyles = false;
            dataGridViewTicket.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {
            var select = "SELECT Operations.Ticket.id AS 'ID', price AS 'Price', Operations.Client.name AS 'Client'" +
                "FROM Operations.Ticket " +
                "JOIN Operations.Client ON Operations.Ticket.client=Operations.Client.id " +
                "JOIN Operations.Reservation ON Operations.Ticket.reservation=Operations.Reservation.id";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewTicket.ReadOnly = true;
            dataGridViewTicket.DataSource = ds.Tables[0];
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            int employeeId = -1;
            using (var form = new ChooseSeller())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    employeeId = form.result;
                }
            }

            Seller seller = new Seller(employeeId);
            seller.Show();
        }
    }
}
