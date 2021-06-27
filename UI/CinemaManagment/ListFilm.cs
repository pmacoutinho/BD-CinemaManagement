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
    public partial class ListFilm : Form
    {
        private SqlConnection cn = SGBDCon.getCN();
        private int selectedPos = 0;
        private List<Film> lst = new List<Film>();

        public ListFilm()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewFilm.EnableHeadersVisualStyles = false;
            dataGridViewFilm.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {
            var select = "SELECT * FROM Data.viewFilms";
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewFilm.ReadOnly = true;
            dataGridViewFilm.DataSource = ds.Tables[0];
            
            lst = ds.Tables[0].AsEnumerable()
                .Select(dataRow => new Film
                {
                    imdb = dataRow.Field<int>("IMDb Key"),
                    name = dataRow.Field<string>("Title"),
                    tmpMinutes = dataRow.Field<int>("Runtime"),
                    director = dataRow.Field<string>("Director")
                }).ToList();
        }

        public static String buttonClicked = "";
        public String getButtonClicked()
        {
            return buttonClicked;
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            buttonClicked = "add";
            AddFilm addMovie = new AddFilm();
            addMovie.Show();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            buttonClicked = "edit";
            AddFilm addMovie = new AddFilm(lst[selectedPos]);
            addMovie.Show();
        }

        private void dataGridViewFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            selectedPos = dgv.SelectedRows[0].Index;
            Debug.WriteLine("ListFilm: selectedPos<int>: "+selectedPos);
        }

        private void rBtn_refresh_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void rBtn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Data.deleteFilm(lst[selectedPos].imdb);
            }
            catch (Exception exception)
            {
                Common.ExceptionDialog.ExDialog(exception);
            }
            
            loadTable();
        }
    }
}
