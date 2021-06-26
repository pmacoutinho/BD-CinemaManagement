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
    public partial class ListSession : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListSession()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewSession.EnableHeadersVisualStyles = false;
            dataGridViewSession.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {
            //var select = "SELECT * FROM Data.viewSessions WHERE Data.Session.cinema = 0";
            var select = "SELECT Data.Session.id AS 'ID', name AS 'Film', startDay AS 'Premiere', noWeeks AS 'No Weeks' " +
                "FROM Data.Session " +
                "JOIN Data.Film ON filmId = imdb " +
                "WHERE Data.Session.cinema = 0";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewSession.ReadOnly = true;
            dataGridViewSession.DataSource = ds.Tables[0];
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddSession addSession = new AddSession();
            addSession.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            buttonClicked = "edit";
            AddSession addSession = new AddSession();
            addSession.Show();
        }
    }
}
