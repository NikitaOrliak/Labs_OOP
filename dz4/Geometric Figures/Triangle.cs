using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Geometric_Figures
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox4.Text);

                Triangle_1 triangle = new Triangle_1(a, b, c);          

                if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
                {
                    MessageBox.Show("Two sides must be longer in result than the third");
                }

                else
                {
                    MessageBox.Show("The Perimeter is: " + triangle.Perimeter, "Result");
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
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
                double c = Convert.ToDouble(textBox4.Text);

                Triangle_1 triangle = new Triangle_1(a, b, c);

                if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
                {
                    MessageBox.Show("Two sides must be longer in result than the third");
                }

                else
                {
                    MessageBox.Show("The Area is: " + triangle.Area, "Result");
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
