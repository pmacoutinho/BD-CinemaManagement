using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class ListMovie : Form
    {
        public ListMovie()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            dataGridViewMovies.EnableHeadersVisualStyles = false;
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        public String buttonClicked = "";

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddMovie addMovie = new AddMovie();
            addMovie.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            buttonClicked = "edit";
            AddMovie addMovie = new AddMovie();
            addMovie.Show();
        }
    }
}
