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
    public partial class AddCleaningRecord : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public AddCleaningRecord()
        {
            InitializeComponent();
            customizeDesign();
        }

        
        private void customizeDesign()
        {
            loadRooms();
            loadCleaners();
        }

        #region loadValues
        private void loadRooms()
        {
            comboBoxRoom.Items.Clear();

            List<Room> lst = new List<Room>();
            User u = User.getInstance();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Management.Room " +
                                            "WHERE cinema=" + u.e.cinema, cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Room r = new Room();
                r.num = Int32.Parse(reader["num"].ToString());
                r.cinema = Int32.Parse(reader["cinema"].ToString());
                r.nSeats = Int32.Parse(reader["nSeats"].ToString());

                lst.Add(r);
            }

            cn.Close();

            foreach (var r in lst)
            {
                comboBoxRoom.Items.Add(r.num);
            }
        }

        private void loadCleaners()
        {
            cn.Open();
            comboBoxCleaner.Items.Clear();

            List<Employee> lst = new List<Employee>();
            User u = User.getInstance();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Management.Employee " +
                                            "WHERE location=" + u.e.cinema + " AND eType=3", cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employee e = new Employee();
                e.id = Int32.Parse(reader["id"].ToString());
                e.name = reader["name"].ToString();
                e.email = reader["email"].ToString();
                e.cinema = Int32.Parse(reader["location"].ToString());
                e.shift = Int32.Parse(reader["eShift"].ToString());
                e.type = Int32.Parse(reader["eType"].ToString());

                lst.Add(e);
            }

            cn.Close();

            foreach (var r in lst)
            {
                comboBoxCleaner.Items.Add(r.id);
            }
        }
        #endregion loadValues

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Employee emp = User.getInstance().e;
            CleaningRecord cr = new CleaningRecord();

            /*var year = monthCalendarDate.SelectionStart.Year;
            var month = monthCalendarDate.SelectionStart.Month;
            var day = monthCalendarDate.SelectionStart.Day;
            var dt = new DateTime(year, month, day,
                Convert.ToInt32(numericUpDownHour.Value), Convert.ToInt32(numericUpDownMinutes.Value), 0);
            cr.tm = dt;*/

            cr.tm = monthCalendarDate.SelectionRange.Start.Date;
            cr.sCinema = emp.cinema;
            cr.sNum = Convert.ToInt32(comboBoxRoom.SelectedItem);
            cr.func = Convert.ToInt32(comboBoxCleaner.SelectedItem);

            var res = Operations.newCleaningRecord(cr);

            this.Close();
        }
    }
}
