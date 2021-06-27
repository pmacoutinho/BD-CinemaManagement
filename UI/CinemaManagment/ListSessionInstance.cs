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
            Login login = new Login();
            int cinema = login.getCinema();

            var select = "SELECT Operations.Session_instance.id AS 'ID', Data.Film.name AS 'Film', " +
                "Operations.Session_instance.time AS 'Start Time', Operations.Session_instance.sNum AS 'Room' " +
                "FROM Operations.Session_instance " +
                "JOIN Data.Session ON Operations.Session_instance.session=Data.Session.id " +
                "JOIN Data.Film ON filmId=imdb " +
                "WHERE Operations.Session_instance.sCinema=" + cinema;
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewSessionInstance.ReadOnly = true;
            dataGridViewSessionInstance.DataSource = ds.Tables[0];
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
