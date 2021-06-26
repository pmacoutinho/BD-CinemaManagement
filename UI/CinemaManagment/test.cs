using CinemaManagment.Entities;
using CinemaManagment.sgbd;
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

namespace CinemaManagment
{

    public partial class test : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public int result { get; set; }
        private int chosenIdx = 0;
        private List<Employee> lst;

        public test()
        {
            InitializeComponent();
            Load += new EventHandler(this.test_Load);
        }


        private void test_Load(object sender, System.EventArgs e)
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
    }
}
