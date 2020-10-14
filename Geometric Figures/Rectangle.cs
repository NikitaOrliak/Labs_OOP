using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Geometric_Figures
{
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                Rectangle_1 rectangle = new Rectangle_1(a, b);

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Sides must be positive");
                }

                else
                {
                    MessageBox.Show("The Perimeter is: " + rectangle.Perimeter, "Result");
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("You must enter all numbers");
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
                double b = Convert.ToDouble(textBox2.Text);

                Rectangle_1 rectangle = new Rectangle_1(a, b);

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Sides must be positive");
                }

                else
                {
                    MessageBox.Show("The Area is: " + rectangle.Area, "Result");
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("You must enter all numbers");
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
    }
}
