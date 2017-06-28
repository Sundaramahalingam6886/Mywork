using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adddoc dc = new Adddoc();
            dc.Show();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Assign ass = new Assign();
            ass.Show();
        }

    }
}
