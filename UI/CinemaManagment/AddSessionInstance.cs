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
    public partial class AddSessionInstance : Form
    {
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
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            SessionInstance si = new SessionInstance();

            si.sessionId = Convert.ToInt32(numericUpDownSessionId.Value);
            si.roomNumber = Convert.ToInt32(numericUpDownRoom.Value);

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
