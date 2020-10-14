using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Geometric_Figures
{
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);

                Square_1 square = new Square_1(a);

                if (a <= 0)
                {
                    MessageBox.Show("Side must be positive");
                }

                else
                {
                    MessageBox.Show("The Perimeter is: " + square.Perimeter, "Result");
                }
            }

            catch
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You must enter the number");
                }

                else
                {
                    MessageBox.Show("You must enter the number");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);

                Square_1 square = new Square_1(a);

                if (a <= 0)
                {
                    MessageBox.Show("Side must be positive");
                }

                else
                {
                    MessageBox.Show("The Area is: " + square.Area, "Result");
                }
            }

            catch
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You must enter the number");
                }

                else
                {
                    MessageBox.Show("You must enter the number");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form_1 = new Form1();
            form_1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
