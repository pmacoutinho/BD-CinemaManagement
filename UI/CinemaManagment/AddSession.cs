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
using CinemaManagment.Common;

namespace CinemaManagment
{
    public partial class AddSession : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

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

            loadFilms();
        }

        private void loadFilms()
        {
            cn.Open();
            comboBoxImdb.Items.Clear();

            List<Film> lst = new List<Film>();
            User u = User.getInstance();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Data.Film ", cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Film f = new Film();
                f.imdb = Int32.Parse(reader["imdb"].ToString());
                f.name = reader["name"].ToString();
                f.tmpMinutes = Int32.Parse(reader["timeMin"].ToString());
                f.director = reader["director"].ToString();

                lst.Add(f);
            }

            cn.Close();

            foreach (var f in lst)
            {
                comboBoxImdb.Items.Add(f.imdb);
            }
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Session s = new Session();

            s.cinema = 0;
            s.filmId = Convert.ToInt32(comboBoxImdb.SelectedItem);
            s.startDay = monthCalendarPremiere.SelectionRange.Start.Date; ;
            s.noWeeks = Convert.ToInt32(numericUpDownNoWeeks.Value);

            var res = Data.newSession(s);
            Debug.WriteLine(res);

            this.Close();
        }
    }
}
