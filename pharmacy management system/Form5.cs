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
    public partial class Form5 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from new_medicine where Medicine_name like'" + textBox1.Text + "%'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from new_medicine";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable    dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update new_medicine set  Medicine_shelf='" + textBox3.Text + "',Medicine_type='" + comboBox1.Text + "',Catagory='" + comboBox2.Text + "',Manufacturer='" + comboBox4.Text + "',Generic='" + textBox4.Text + "',Unit='" + comboBox5.Text + "',Details='" + textBox5.Text + "',mfg_date='" + dateTimePicker1.Value.ToString() + "',exp_date='" + dateTimePicker2.Value.ToString() + "',u_price='" + textBox2.Text + "',Sales_price='" + textBox6.Text + "',M_price='" + textBox7.Text + "'   where Medicine_name='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updation successfull");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "delete from new_medicine where Medicine_name='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record Deleted");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
