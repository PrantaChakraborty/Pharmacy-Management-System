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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            fill_combo();
            fill_comb();
            fill_com();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
        void fill_combo()
        {
            try
            {
                conn.Open();
                string query = "select * from add_type";
                MySqlCommand createCommand = new MySqlCommand(query, conn);
                MySqlDataReader dr = createCommand.ExecuteReader();
                while (dr.Read())
                {
                    string type_name = dr.GetString(1);
                    comboBox1.Items.Add(type_name);
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
            void fill_comb()
            {
                try
                {
                    conn.Open();
                    string query = "select * from add_manufacturer";
                    MySqlCommand createCommand = new MySqlCommand(query, conn);
                    MySqlDataReader dr = createCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        string name = dr.GetString(0);
                        comboBox4.Items.Add(name);
                    }

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        void fill_com()
        {
            try
            {
                conn.Open();
                string query = "select * from catagory";
                MySqlCommand createCommand = new MySqlCommand(query, conn);
                MySqlDataReader dr = createCommand.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    comboBox2.Items.Add(name);
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into new_medicine values ('" + textBox1.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + textBox4.Text + "','" + comboBox5.Text + "','" + textBox5.Text + "','"+ dateTimePicker1.Value.ToString() +"','" + dateTimePicker2.Value.ToString() +"','"+textBox2.Text+"','" + textBox6.Text + "','" + textBox7.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Type successfully added");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            string query = "insert into new_medicine values ('" + textBox1.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + textBox4.Text + "','" + comboBox5.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToString() +"','" + dateTimePicker2.Value.ToString() + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Type successfully added");


            Form8 s = new Form8();
            s.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
