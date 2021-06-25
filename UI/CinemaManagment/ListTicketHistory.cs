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
            var select = "SELECT Operations.Ticket.id AS 'ID',  Operations.Ticket.price AS 'Price', Operations.Client.name AS 'Client' " +
                "FROM Operations.Ticket " +
                "JOIN Operations.Reservation ON Operations.Ticket.id=Operations.Reservation.id " +
                "JOIN Operations.Client ON Operations.Reservation ON Operations.Reservation=Operations.Client.id";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewTicket.ReadOnly = true;
            dataGridViewTicket.DataSource = ds.Tables[0];
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket();
            addTicket.Show();
        }
    }
}
