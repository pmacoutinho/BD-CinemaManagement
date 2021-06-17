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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelEmployeesSubmenu.Visible = false;
            panelRoomsSubmenu.Visible = false;
            panelMoviesSubmenu.Visible = false;
            panelClientsSubmenu.Visible = false;
        }

        #region hide/show subMenu
        private void hideSubMenu()
        {
            if (panelEmployeesSubmenu.Visible == true)
                panelEmployeesSubmenu.Visible = false;

            if (panelRoomsSubmenu.Visible == true)
                panelRoomsSubmenu.Visible = false;

            if (panelMoviesSubmenu.Visible == true)
                panelMoviesSubmenu.Visible = false;

            if (panelClientsSubmenu.Visible == true)
                panelClientsSubmenu.Visible = false;
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
            openChildForm(new Form2());
        }

        #endregion employeesMenu

        #region roomsMenu
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoomsSubmenu);
        }
        #endregion roomsMenu

        #region moviesMenu
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMoviesSubmenu);
        }
        #endregion moviesMenu

        #region clientsMenu
        private void buttonClients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientsSubmenu);
        }
        #endregion clientsMenu

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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
