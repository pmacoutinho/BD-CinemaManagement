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

        public AddEmployee()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            ListWorker listWorker = new ListWorker();

            if (listWorker.getButtonClicked() == "edit")
                labelAddEmployee.Text = "Edit Employee";
            else
                labelAddEmployee.Text = "Add Employee";

            /*comboBoxShift.Items.Add("9-12");
            comboBoxShift.Items.Add("12-15");
            comboBoxShift.Items.Add("15-18");
            comboBoxShift.Items.Add("18-21");
            comboBoxShift.Items.Add("21-00");*/

            comboBoxFunction.Items.Add("Cleaner");
            comboBoxFunction.Items.Add("Sales");
            comboBoxFunction.Items.Add("Manager");
            comboBoxFunction.Items.Add("Deputy Manager");
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.id = Convert.ToInt32(numericUpDownNum.Value);
            em.name = textBoxName.Text;
            em.email = textBoxEmail.Text;
            em.cinema = 1;
            em.shift = Convert.ToInt32(numericUpDownShift.Value);

            if (comboBoxFunction.Text == "Cleaner")
                em.type = 3;
            else if (comboBoxFunction.Text == "Sales")
                em.type = 2;
            else if (comboBoxFunction.Text == "Deputy Manager")
                em.type = 1;
            else if (comboBoxFunction.Text == "Manager")
                em.type = 0;



            var res = Management.newEmployee(em);
            Debug.WriteLine(res);
            //Debug.WriteLine(c.birthday.ToString("yyyyMMdd"));

            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
