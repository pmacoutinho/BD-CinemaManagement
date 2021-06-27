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
        private Film f;
        private bool update = false;
        
        public AddFilm()
        {
            InitializeComponent();
            customizeDesign();
            this.f = new Film();
        }
        
        public AddFilm(Film f)
        {
            InitializeComponent();
            
            this.f = f;
            update = true;
            customizeDesign();
        }

        private void customizeDesign()
        {
            if (update)
            {
                labelAddFilm.Text = "Edit Movie";
                rBtn_update.Visible = true;
                roundedButtonAdd.Visible = false;
                
                // fill information
                numericUpDownImdb.Text = f.imdb.ToString();
                textBoxTitle.Text = f.name;
                textBoxDirector.Text = f.director;
                numericUpDownRuntime.Text = f.tmpMinutes.ToString();
            }
            else
            {
                labelAddFilm.Text = "Add Movie";
                rBtn_update.Visible = false;
                roundedButtonAdd.Visible = true;

            }
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            
            f.imdb = int.Parse(numericUpDownImdb.Text);
            f.name = textBoxTitle.Text;
            f.director = textBoxDirector.Text;
            f.tmpMinutes = int.Parse(numericUpDownRuntime.Text);
            try
            {
                var res = Data.newFilm(f);
            }
            catch (Exception exception)
            {
                Common.ExceptionDialog.ExDialog(exception);
            }
            
            //Debug.WriteLine(res);
            this.Close();
        }

        private void rBtn_update_Click(object sender, EventArgs e)
        {
            f.imdb = int.Parse(numericUpDownImdb.Text);
            f.name = textBoxTitle.Text;
            f.director = textBoxDirector.Text;
            f.tmpMinutes = int.Parse(numericUpDownRuntime.Text);

            try
            {
                Data.updateFilm(f);
            }
            catch (Exception exception)
            {
                Common.ExceptionDialog.ExDialog(exception);
            }
            this.Close();
        }
    }
}
