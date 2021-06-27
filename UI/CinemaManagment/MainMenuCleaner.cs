using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class MainMenuCleaner : Form
    {
        #region startUp
        public MainMenuCleaner()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
        }
        #endregion startUp

        #region hide/show subMenu
        private void hideSubMenu()
        {
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion hide/show subMenu

        #region cleaningRecordMenu
        private void buttonCleaningRecords_Click(object sender, EventArgs e)
        {
            openChildForm(new ListCleaningRecord());
        }
        #endregion cleaningRecordMenu

        #region roomsMenu
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListRoom());
        }
        #endregion roomsMenu

        #region logout
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        #endregion logout

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
