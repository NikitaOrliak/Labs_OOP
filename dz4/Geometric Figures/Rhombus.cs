using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Geometric_Figures
{
    public partial class Rhombus : Form
    {
        public Rhombus()
        {
            InitializeComponent();
        }

        private void Rhombus_Load(object sender, EventArgs e)
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
                double h = Convert.ToDouble(textBox2.Text);

                Rhombus_1 rhombus = new Rhombus_1(a, h);

                if (a <= 0)
                {
                    MessageBox.Show("Side must be positive");
                }

                else
                {
                    if (h <= 0)
                    {
                        MessageBox.Show("Hight must be positive");
                    }
                    else
                    {
                        if (h >= a)
                        {
                            MessageBox.Show("Side must be longer then hight");
                        }
                        else
                        {
                            MessageBox.Show("The Perimeter is: " + rhombus.Perimeter, "Result");
                        }
                    }
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "")
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
                double h = Convert.ToDouble(textBox2.Text);

                Rhombus_1 rhombus = new Rhombus_1(a, h);

                if (a <= 0)
                {
                    MessageBox.Show("Side must be positive");
                }

                else
                {
                    if (h <= 0)
                    {
                        MessageBox.Show("Hight must be positive");
                    }
                    else
                    {
                        if (h >= a)
                        {
                            MessageBox.Show("Side must be longer then hight");
                        }
                        else
                        {
                            MessageBox.Show("The Area is: " + rhombus.Area, "Result");
                        }
                    }
                }
            }

            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "")
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
