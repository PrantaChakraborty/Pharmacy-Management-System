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
    public partial class Form9 : Form

    {
        public Form9()
        {
            InitializeComponent();
        }
        //int Id=0;

        double price, quantity, amount;
        double final=0;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
                price = Convert.ToDouble(textBox2.Text);
                quantity = Convert.ToDouble(textBox3.Text);
                amount = price * quantity;
                lblAmount.Text = amount.ToString();
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                final = final + amount;
            
            lblto.Text = final.ToString();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, price, quantity, amount);
        }
    }
}

