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
        private Employee e;
        private bool seeAll = false;

        public ListCleaningRecord()
        {
            InitializeComponent();
            this.e = User.getInstance().e;
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            if (e.type == 0)
            {
                seeAll = true;
                rBtn_seeAll.Visible=false;
            }
            
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
                var crLst = Operations.getCleaningRecords(seeAll);

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

        private void rBtn_seeAll_Click(object sender, EventArgs e)
        {
            seeAll = !seeAll;
            if (seeAll)
            {
                rBtn_seeAll.Text = "See Mine";
            }
            else
            {
                rBtn_seeAll.Text = "See All";

            }
            loadTable();
        }
    }
}
