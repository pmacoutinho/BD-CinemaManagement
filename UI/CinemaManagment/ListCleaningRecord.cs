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
            try
            {
                var crLst = Operations.getCleaningRecords();

                dataGridViewCleaningRecords.ReadOnly = true;
                dataGridViewCleaningRecords.DataSource = crLst;


            }
            catch (Exception exception)
            {
                Common.ExceptionDialog.ExDialog(exception);
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                cn.Close();
            }
            
        }
    }
}
