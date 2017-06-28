using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital
{
    public partial class Assign : Form
    {
        public Assign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        MessageBox.Show("Patient " +textBox1.Text+ "is assigned to" +textBox2.Text);    
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
