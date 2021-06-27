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

        public AddCleaningRecord()
        {
            InitializeComponent();
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            CleaningRecord cr = new CleaningRecord();

            /*var year = monthCalendarDate.SelectionStart.Year;
            var month = monthCalendarDate.SelectionStart.Month;
            var day = monthCalendarDate.SelectionStart.Day;
            var dt = new DateTime(year, month, day,
                Convert.ToInt32(numericUpDownHour.Value), Convert.ToInt32(numericUpDownMinutes.Value), 0);
            cr.tm = dt;*/

            cr.tm = monthCalendarDate.SelectionRange.Start.Date;
            cr.sCinema = 1;
            cr.sNum = Convert.ToInt32(numericUpDownCleaner.Value);
            cr.func = Convert.ToInt32(numericUpDownCleaner.Value);

            var res = Operations.newCleaningRecord(cr);

            this.Close();
        }
    }
}
