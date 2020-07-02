using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("Date of Join cannot be less than or equal to Date of Birth");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Today;
            MessageBox.Show(dt1.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work from Laptop MSI");
        }
    }
}
