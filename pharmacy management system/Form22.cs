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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from sells";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "delete from sells where bill_no='" + textBox6.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record Deleted");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
             
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }
    }
}
