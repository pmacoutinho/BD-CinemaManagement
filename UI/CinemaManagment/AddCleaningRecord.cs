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
    public partial class AddCleaningRecord : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public AddCleaningRecord()
        {
            InitializeComponent();
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            CleaningRecord c = new CleaningRecord();
            c.tm = monthCalendarDate.SelectionRange.Start.Date;
            c.sCinema = 1;
            c.sNum = Convert.ToInt32(numericUpDownCleaner.Value);
            c.func = Convert.ToInt32(numericUpDownCleaner.Value);

            //var res = Operations.newCleaningRecord(c);
            //Debug.WriteLine(res);
            //Debug.WriteLine(c.birthday.ToString("yyyyMMdd"));

            this.Close();
        }
    }
}
