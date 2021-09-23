using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ashis\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;");
            string query = "Select * from tbl_Login where UserName = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "' and Proffession = '" + textBox3.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                if  (textBox3.Text == "Admin")
                {
                    Home ss = new Home();
                    ss.Show();
                }
                if (textBox3.Text == "Teacher")
                {
                    Home2 ss = new Home2();
                    ss.Show();
                }
                if (textBox3.Text == "Student")
                {
                    Home3 ss = new Home3();
                    ss.Show();
                }
            }
            else
            {
                  MessageBox.Show("Check your username and password");
            }
                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
            if (dr == DialogResult.Yes)
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
