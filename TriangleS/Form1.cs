using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double angle = Convert.ToDouble(textBox3.Text);

                TriangleS triangles = new TriangleS(a, b, angle);
                Right_Triangle right_triangles = new Right_Triangle(a, b, angle);
                Equil_Triangle equil_triangles = new Equil_Triangle(a);

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Sides must be positive");
                }

                else
                {

                    if (angle >= 180 || angle <= 0)
                    {
                        MessageBox.Show("The angle can't be more than 179° or less than 1°");
                    }

                    else
                    {
                        if (angle == 90)
                        {
                            MessageBox.Show("It's a Right Triangle, his Perimeter: " + right_triangles.perimeter, "Result");
                        }

                        else
                        {
                            if (a == b && angle == 60)
                            {
                                MessageBox.Show("It's an Equil Triangle, his Perimeter: " + equil_triangles.perimeter, "Result");
                            }

                            else
                            {
                                MessageBox.Show("It's a Normal Triangle, his Perimeter: " + triangles.perimeter, "Result");
                            }
                        }
                    }
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
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double angle = Convert.ToDouble(textBox3.Text);

                TriangleS triangles = new TriangleS(a, b, angle);
                Right_Triangle right_triangles = new Right_Triangle(a, b, angle);
                Equil_Triangle equil_triangles = new Equil_Triangle(a);

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Sides must be positive");
                }

                else
                {
                    if (angle >= 180 || angle <= 0)
                    {
                        MessageBox.Show("The angle can't be more than 179° or less than 1°");
                    }

                    else
                    {
                        if (angle == 90)
                        {
                            MessageBox.Show("It's a Right Triangle, his Area: " + right_triangles.area, "Result");
                        }

                        else
                        {
                            if (a == b && angle == 60)
                            {
                                MessageBox.Show("It's an Equil Triangle, his Area: " + equil_triangles.area, "Result");
                            }

                            else
                            {
                                MessageBox.Show("It's a Normal Triangle, his Area: " + triangles.area, "Result");
                            }
                        }
                    }
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
