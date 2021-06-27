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
    public partial class AddSessionInstance : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public AddSessionInstance()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            ListSessionInstance listSessionInstance = new ListSessionInstance();
            if (listSessionInstance.getButtonClicked() == "edit")
                labelAddSessionInstance.Text = "Edit Session Instance";
            else
                labelAddSessionInstance.Text = "Add Session Instance";

            loadSessions();
            loadRooms();
        }

        #region loadValues
        private void loadSessions()
        {
            cn.Open();
            comboBoxSessionId.Items.Clear();

            List<Session> lst = new List<Session>();
            User u = User.getInstance();

            SqlCommand cmd = new SqlCommand("SELECT id FROM Data.Session " +
                                            "WHERE cinema=" + u.e.cinema, cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Session s = new Session();
                s.id = Int32.Parse(reader["id"].ToString());

                lst.Add(s);
            }

            cn.Close();

            foreach (var s in lst)
            {
                comboBoxSessionId.Items.Add(s.id);
            }
        }

        private void loadRooms()
        {
            cn.Open();
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
        #endregion loadValues

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            SessionInstance si = new SessionInstance();

            si.sessionId = Convert.ToInt32(comboBoxSessionId.SelectedItem);
            si.roomNumber = Convert.ToInt32(comboBoxRoom.SelectedItem);

            var src = DateTime.Now;
            var hm = new DateTime(src.Year, src.Month, src.Day, 
                Convert.ToInt32(numericUpDownHour.Value), Convert.ToInt32(numericUpDownMinutes.Value), 0);
            si.time = hm;

            var res = Operations.newSessionInstance(si);
            Debug.WriteLine(res);

            this.Close();
        }
    }
}
