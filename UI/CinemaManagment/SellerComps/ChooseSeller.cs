using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagment.Entities;
using CinemaManagment.sgbd;

namespace CinemaManagment
{
    public partial class ChooseSeller : Form
    {
        public int result { get; set; }
        private int chosenIdx = 0;
        private List<Employee> lst;
        public ChooseSeller()
        {
            InitializeComponent();
            Load += new EventHandler(this.ChooseSeller_Load);
        }


        private void ChooseSeller_Load(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            lst = Management.loadSellers();

            foreach (var c in lst)
            {
                listBox1.Items.Add(c.ToSimpleString());
            }
            

        }

        //click handlers
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                chosenIdx = listBox1.SelectedIndex;
                
            }
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            this.result = lst[chosenIdx].id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
