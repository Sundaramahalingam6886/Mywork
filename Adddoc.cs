using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Hospital
{
    public partial class Adddoc : Form
    {
        public Adddoc()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=SUNDAR\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into doctor values('"+textBox1.Text+"','"+comboBox1.SelectedItem+"',"+textBox3.Text+",'"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')", con);
                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Added Successfully");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
