using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management_system
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into add_type(id,typename) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Type successfully added");
            Form7 x = new Form7();
            x.Show();
            this.Hide();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into add_type(id,typename) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Type successfully added");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from add_type";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update add_type set typename='" + textBox2.Text + "'where id='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updation successfull");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
           
            string query = "delete from add_type where id='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            
            conn.Close();
            
            MessageBox.Show("Record Deleted");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
