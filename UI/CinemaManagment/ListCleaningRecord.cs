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
    public partial class ListCleaningRecord : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListCleaningRecord()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewCleaningRecords.EnableHeadersVisualStyles = false;
            dataGridViewCleaningRecords.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            AddCleaningRecord addCleaningRecord = new AddCleaningRecord();
            addCleaningRecord.Show();
        }

        private void loadTable()
        {
            var select = "SELECT tm AS 'Timestamp', sNum AS 'Room Number', name AS 'Cleaner' " +
                "FROM Operations.Cleaning_Record JOIN Management.Employee ON func=id";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewCleaningRecords.ReadOnly = true;
            dataGridViewCleaningRecords.DataSource = ds.Tables[0];
        }
    }
}
