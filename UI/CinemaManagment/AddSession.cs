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
    }
}
