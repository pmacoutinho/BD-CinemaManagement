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
        public MainMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelEmployeesSubmenu.Visible = false;
        }

        #region hide/show subMenu
        private void hideSubMenu()
        {
            if (panelEmployeesSubmenu.Visible == true)
                panelEmployeesSubmenu.Visible = false;
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

        #region employeesMenu
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmployeesSubmenu);
        }

        private void buttonVendors_Click(object sender, EventArgs e)
        {
            openChildForm(new ListVendor());
        }

        private void buttonCleaners_Click(object sender, EventArgs e)
        {
            openChildForm(new ListCleaner());
        }

        #endregion employeesMenu

        #region roomsMenu
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListRoom());
        }
        #endregion roomsMenu

        #region moviesMenu
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListMovie());
        }
        #endregion moviesMenu

        #region clientsMenu
        private void buttonClients_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListClient());
        }
        #endregion clientsMenu

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
