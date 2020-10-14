using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
                {
                    MessageBox.Show("Two sides must be larger in result than the third");
                }

                else
                {
                    MessageBox.Show("The Perimeter is: " + (a + b + c).ToString(), "Result");
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
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
            {
                try
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = Convert.ToDouble(textBox3.Text);

                    if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
                    {
                        MessageBox.Show("Two sides must be larger in result than the third");
                    }

                    else
                    {
                        MessageBox.Show("Angle between a and b: " + Math.Round((Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI))).ToString() + "\n" +
                                        "Angle between b and c: " + Math.Round((Math.Acos((c * c + b * b - a * a) / (2 * b * c)) * (180 / Math.PI))).ToString() + "\n" +
                                        "Angle between a and c: " + Math.Round((Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI))).ToString(), "Angles");
                    }
                }

                catch
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("You must enter all numbers");
                    }

                    else
                    {
                        MessageBox.Show("You must enter the number");
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                if (a == b && b == c)
                {
                    MessageBox.Show("The Area is: " + Math.Round(((Math.Sqrt(3) / 4) * (a * a)), 2));
                }

                else
                {
                    MessageBox.Show("Sides must be equality");
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("You must enter all numbers");
                }

                else
                {
                    MessageBox.Show("You must enter the number");
                }
            }
        }
    }
}
