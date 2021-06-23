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
    public partial class MainMenu : Form
    {
        #region startUp
        public MainMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelEmployeesSubmenu.Visible = false;
            panelRoomsSubmenu.Visible = false;
        }
        #endregion startUp

        #region hide/show subMenu
        private void hideSubMenu()
        {
            if (panelEmployeesSubmenu.Visible == true)
                panelEmployeesSubmenu.Visible = false;

            if (panelRoomsSubmenu.Visible == true)
                panelRoomsSubmenu.Visible = false;
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

        #region clientsMenu
        private void buttonClients_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListClient());
        }
        #endregion clientsMenu

        #region cleaningRecordMenu
        private void buttonCleaningRecords_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ListCleaningRecord());
        }
        #endregion cleaningRecordMenu

        #region employeesMenu
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmployeesSubmenu);
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            openChildForm(new ListWorker());
        }

        private void buttonManagers_Click(object sender, EventArgs e)
        {
            openChildForm(new ListManager());
        }

        #endregion employeesMenu

        #region moviesMenu
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListMovie());
        }
        #endregion moviesMenu

        #region roomsMenu
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoomsSubmenu);
        }

        private void buttonRoomList_Click(object sender, EventArgs e)
        {
            openChildForm(new ListRoom());
        }

        private void buttonSessionList_Click(object sender, EventArgs e)
        {
            openChildForm(new ListSession());
        }
        #endregion roomsMenu

        #region ticketsMenu
        private void buttonTickets_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ListTicketHistory());
        }
        #endregion ticketsMenu

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
