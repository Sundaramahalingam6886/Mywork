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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adddoc dc = new Adddoc();
            dc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SUNDAR\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd=new SqlCommand("select * from adm where uname='"+textBox1.Text+"' and pwd='"+textBox2.Text+"'",con);
            SqlDataReader dr=cmd.ExecuteReader();
            if(dr.Read())
            {
                Adminpage ap=new Adminpage();
                ap.Show();
            }
            else
            {
                MessageBox.Show("username & password wrong");
            }
             con.Close();
        }
        }
    }

