using pharmacy_management_system.Properties;
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
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pharmacy management");
        private bool isCollapsed;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer4.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer6.Start();


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            timer5.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form19 s = new Form19();
            s.Show();
            this.Hide();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (isCollapsed)
            {
               
                button6.Image = Resources.down__2_;


                panel17.Height += 10;
                if (panel17.Size == panel17.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                
                button6.Image = Resources.up;
                panel17.Height -= 10;
                if(panel17.Size== panel17.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                 }
            }
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
           
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {

                button3.Image = Resources.down__2_;


                panel19.Height += 10;
                if (panel19.Size == panel19.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
              
               button3.Image = Resources.up;
                panel19.Height -= 10;
                if (panel19.Size == panel19.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {

                button11.Image = Resources.down__2_;


                panel16.Height += 10;
                if (panel16.Size == panel16.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                
                button11.Image = Resources.up;
                panel16.Height -= 10;
                if (panel16.Size == panel16.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Form17 s = new Form17();
            s.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form18 s = new Form18();
            s.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 s = new Form8();
            s.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form10 s = new Form10();
            s.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.Show();
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form20 s = new Form20();
            s.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form15 s = new Form15();
            s.Show();
            this.Hide();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {

                button2.Image = Resources.down__2_;


                panel15.Height += 10;
                if (panel15.Size == panel15.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                button2.Image = Resources.up;
                panel15.Height -= 10;
                if (panel15.Size == panel15.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {

                button7.Image = Resources.down__2_;


                panel18.Height += 10;
                if (panel18.Size == panel18.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                button7.Image = Resources.up;
                panel18.Height -= 10;
                if (panel18.Size == panel18.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {

               button5.Image = Resources.down__2_;


                panel20.Height += 10;
                if (panel20.Size == panel20.MaximumSize)
                {
                    timer6.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                button5.Image = Resources.up;
                panel20.Height -= 10;
                if (panel20.Size == panel20.MinimumSize)
                {
                    timer6.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.Show();
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form21 s = new Form21();
            s.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form22 s = new Form22();
            s.Show();
            this.Hide();
        }
    }
}
