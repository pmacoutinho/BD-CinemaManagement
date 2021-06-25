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
    public partial class AddFilm : Form
    {
        public AddFilm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            ListFilm listMovie = new ListFilm();
            if (listMovie.getButtonClicked() == "edit")
                labelAddFilm.Text = "Edit Movie";
            else
                labelAddFilm.Text = "Add Movie";
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Film c = new Film();
            c.imdb = int.Parse(textBoxImdb.Text);
            c.name = textBoxTitle.Text;
            c.director = textBoxDirector.Text;
            c.tmpMinutes = int.Parse(textBoxRuntime.Text);
            var res = Data.newFilm(c);
            Debug.WriteLine(res);

            this.Close();
        }
    }
}
