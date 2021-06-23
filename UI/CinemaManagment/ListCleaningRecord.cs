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
    public partial class ListCleaningRecord : Form
    {
        public ListCleaningRecord()
        {
            InitializeComponent();
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            AddCleaningRecord addCleaningRecord = new AddCleaningRecord();
            addCleaningRecord.Show();
        }
    }
}
