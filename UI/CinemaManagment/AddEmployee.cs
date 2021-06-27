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
    public partial class AddEmployee : Form
    {
        private SqlConnection cn = SGBDCon.getCN();
        private Employee e;
        private bool update = false;
        private int cinema;
        public AddEmployee(int cinema)
        {
            cinema = cinema;
            InitializeComponent();
            customizeDesign();
        }
        
        public AddEmployee(Employee e)
        {
            InitializeComponent();
            update = true;
            this.e = e;
            
            customizeDesign();
        }

        private void customizeDesign()
        {
            comboBoxFunction.Items.Add("Manager");
            comboBoxFunction.Items.Add("Deputy Manager");
            comboBoxFunction.Items.Add("Sales");
            comboBoxFunction.Items.Add("Cleaner");
            
            if (update)
            {
                labelAddEmployee.Text = "Edit Employee";
                roundedButtonAdd.Text = "Update";
                
                //fill in details
                textBoxName.Text = e.name;
                textBoxEmail.Text = e.email;
                numericUpDownShift.Value = e.shift;
                comboBoxFunction.SelectedIndex = e.type;
            }
            else
            {
                labelAddEmployee.Text = "Add Employee";
                roundedButtonAdd.Text = "Add";

            }
            

            /*comboBoxShift.Items.Add("9-12");
            comboBoxShift.Items.Add("12-15");
            comboBoxShift.Items.Add("15-18");
            comboBoxShift.Items.Add("18-21");
            comboBoxShift.Items.Add("21-00");*/

            
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Employee em = getEmp();

            try
            {
                if (update)
                {
                    Management.updateEMployee(em);
                }
                else
                {
                    var res = Management.newEmployee(em);
                    Debug.WriteLine(res);
                }
            }
            catch (Exception exception)
            {
                Common.ExceptionDialog.ExDialog(exception);
            }
            
            
            //Debug.WriteLine(c.birthday.ToString("yyyyMMdd"));

            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private Employee getEmp()
        {
            Employee em = new Employee();
            em.id = (update) ? e.id : -1;
            em.name = textBoxName.Text;
            em.email = textBoxEmail.Text;
            em.cinema = (update) ? e.cinema : this.cinema;
            em.shift = Convert.ToInt32(numericUpDownShift.Value);

            if (comboBoxFunction.Text == "Cleaner")
                em.type = 3;
            else if (comboBoxFunction.Text == "Sales")
                em.type = 2;
            else if (comboBoxFunction.Text == "Deputy Manager")
                em.type = 1;
            else if (comboBoxFunction.Text == "Manager")
                em.type = 0;
            return em;
        }
    }
}
