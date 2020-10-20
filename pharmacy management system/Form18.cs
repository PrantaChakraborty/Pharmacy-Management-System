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
    public partial class Form18 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
        public Form18()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 s = new Form14();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from add_manufacturer where name like'" + textBox1.Text + "%'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from add_manufacturer";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "delete from add_manufacturer where name='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update add_manufacturer set  mobile='" + textBox2.Text + "',address='" + textBox3.Text + "',details='" + textBox4.Text + "'  where name='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updation successfull");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
