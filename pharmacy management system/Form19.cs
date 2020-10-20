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
    public partial class Form19 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
        public Form19()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into catagory values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Catagory successfully added");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update catagory set name='" + textBox2.Text + "'where id='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updation successfull");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "delete from catagory where id='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            conn.Open();
            string query = "select * from catagory";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into catagory values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Catagory successfully added");
            Form19 x = new Form19();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }
    }
}
