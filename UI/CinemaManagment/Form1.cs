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
            panelEmpregadosSubmenu.Visible = false;
            panelSalasSubmenu.Visible = false;
            panelFilmesSubmenu.Visible = false;
            panelClientesSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelEmpregadosSubmenu.Visible == true)
                panelEmpregadosSubmenu.Visible = false;

            if (panelSalasSubmenu.Visible == true)
                panelSalasSubmenu.Visible = false;

            if (panelFilmesSubmenu.Visible == true)
                panelFilmesSubmenu.Visible = false;

            if (panelClientesSubmenu.Visible == true)
                panelClientesSubmenu.Visible = false;
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

        #region empregadosMenu
        private void buttonEmpregados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpregadosSubmenu);
        }

        private void buttonVendedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }
        #endregion empregadosMenu

        #region salasMenu
        private void buttonSalas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSalasSubmenu);
        }
        #endregion salasMenu

        #region filmesMenu
        private void buttonFilmes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFilmesSubmenu);
        }
        #endregion filmesMenu

        #region clientesMenu
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientesSubmenu);
        }
        #endregion clientesMenu

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
