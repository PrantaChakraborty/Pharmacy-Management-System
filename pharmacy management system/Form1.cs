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
using MySql.Data.MySqlClient;

namespace pharmacy_management_system
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit",
                "Pharmacy Management System",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(iExit==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
            string user = txtusername.Text;
            string pass = txtpassword.Text;
            string user_type = comboBox1.Text;
           
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from login where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'and user_type='"+ comboBox1.Text +"'", conn);
            DataTable dt =new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               
                MySqlDataAdapter sda1 = new MySqlDataAdapter("select user_type from login where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'and user_type='" + comboBox1.Text + "'", conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "Admin")
                {

                    
                        Form2 s = new Form2();
                        s.Show();
                        this.Hide();
                    
                }
                if (dt1.Rows[0][0].ToString() == "Manager")
                {


                    Form2 s = new Form2();
                    s.Show();
                    this.Hide();

                }
                if (dt1.Rows[0][0].ToString() == "Employee")
                {


                    Form11 s = new Form11();
                    s.Show();
                    this.Hide();
                    
                }
            }
            else
            {
                MessageBox.Show("Incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if(Show.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
