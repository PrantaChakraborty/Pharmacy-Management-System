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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 s=new Form2 ();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into sells (bill_no,name,date,product,price,quantity,total)values('" + textBox6.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            Form21 s = new Form21();
            s.Show();
            this.Hide();
            conn.Close();
            count_a();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

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

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from new_medicine where Medicine_name='"+ textBox2.Text+"'";
          
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox3.Text = (dr["u_price"].ToString());
            }
            conn.Close();
     


        }
        public void count_a()
        {
            conn.Open();
            string query = "select bill_no from sells order by bill_no";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox6.Text = dr["bill_no"].ToString();
            }
            int i = int.Parse(textBox6.Text);
            i = i + 1;
            textBox6.Text = i.ToString();
            conn.Close();
            
          



        }

        private void Form21_Load(object sender, EventArgs e)
        {
            count_a();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            totalPrice();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            totalPrice();
        }

        private void totalPrice()
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                double total = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox4.Text);
                textBox5.Text = total.ToString();
            }
            else
            {
                textBox5.Text = "0";

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(" Pharma Care", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 50));
            e.Graphics.DrawString(" Link Rd, Dhaka 1205", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 80));
            e.Graphics.DrawString(" Phone: 01819-951126", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 120));
            e.Graphics.DrawString(" ---------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 150));
            e.Graphics.DrawString(" Bill No :"+ textBox6.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            e.Graphics.DrawString(" Name :"+textBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString(" Date :"+dateTimePicker1, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString(" ---------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 230));
            e.Graphics.DrawString(" Product Name", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString(" Quantity", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(500, 360));
            e.Graphics.DrawString(" Price", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(700, 360));
            // e.Graphics.DrawString(" ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(700, 300));
            e.Graphics.DrawString(" ----------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 390));
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 420));
            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(530, 420));
            e.Graphics.DrawString(textBox4.Text+" Tk", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, 420));
            e.Graphics.DrawString("Total = "+textBox5.Text+" Tk", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(300, 480));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(" Pharma Care", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 50));
            e.Graphics.DrawString(" Link Rd, Dhaka 1205", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 80));
            e.Graphics.DrawString(" Phone: 01819-951126", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 120));
            e.Graphics.DrawString(" ---------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 150));
            e.Graphics.DrawString(" Bill No :" + textBox6.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 200));
            e.Graphics.DrawString(" Name :" + textBox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 230));
            e.Graphics.DrawString(" Date :" + DateTime.Now, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 260));
            e.Graphics.DrawString(" ---------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 290));
            e.Graphics.DrawString(" Product Name", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString(" Quantity", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(500, 360));
            e.Graphics.DrawString(" Price", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(700, 360));
            // e.Graphics.DrawString(" ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(700, 300));
            e.Graphics.DrawString(" ----------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 390));
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 420));
            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(530, 420));
            e.Graphics.DrawString(textBox4.Text + " Tk", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, 420));
            e.Graphics.DrawString("Total = " + textBox5.Text + " Tk", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(300, 480));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(textBox6.Text,textBox1.Text,dateTimePicker1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text);
            bool Found = false;
            if(dataGridView1.Rows.Count>0)
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(Convert.ToString(row.Cells[0].Value)==textBox6.Text && Convert.ToString(row.Cells[1].Value)==textBox1.Text && Convert.ToString(row.Cells[1].Value) == dateTimePicker1.Text && Convert.ToString(row.Cells[1].Value) == textBox2.Text && Convert.ToString(row.Cells[1].Value) == textBox3.Text && Convert.ToString(row.Cells[1].Value) == textBox4.Text && Convert.ToString(row.Cells[1].Value) == textBox5.Text)
                    {
                        row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        Found = true;
                    }
                    if(!Found)
                    {
                        dataGridView1.Rows.Add(textBox6.Text, textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, 1);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(textBox6.Text, textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, 1);
                    }

                }
            }

        }
    }
}
