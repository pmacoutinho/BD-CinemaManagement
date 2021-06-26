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
    public partial class AddSession : Form
    {
        public AddSession()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            ListSession listSession = new ListSession();
            if (listSession.getButtonClicked() == "edit")
                labelAddSession.Text = "Edit Session";
            else
                labelAddSession.Text = "Add Session";
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Session s = new Session();

            s.cinema = 0;
            s.filmId = Convert.ToInt32(numericUpDownFilmdImdb.Value);
            s.startDay = monthCalendarPremiere.SelectionRange.Start.Date; ;
            s.noWeeks = Convert.ToInt32(numericUpDownNoWeeks.Value);

            var res = Data.newSession(s);
            Debug.WriteLine(res);

            this.Close();
        }
    }
}
