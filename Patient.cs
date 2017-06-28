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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SUNDAR\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into patient values('" + textBox1.Text + "','" + comboBox1.SelectedItem + "'," + textBox3.Text + ",'" + textBox4.Text + "','"+comboBox2.SelectedItem+ "')", con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Added Successfully");
        }
    }
}
