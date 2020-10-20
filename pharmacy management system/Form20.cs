using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pharmacy_management_system
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into login(username,password,user_type) values ('" + textBox1.Text + "','" + textBox2.Text + "','"+comboBox1.Text+"')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Type successfully added");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            conn.Open();
            string query = "insert into login(username,password) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Type successfully added");
            Form20 s = new Form20();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from login";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
