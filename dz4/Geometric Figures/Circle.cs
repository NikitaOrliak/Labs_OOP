using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Geometric_Figures
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void Circle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form_1 = new Form1();
            form_1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(textBox1.Text);

                Circle_1 circle = new Circle_1(R);

                if (R <= 0)
                {
                    MessageBox.Show("Radius must be positive");
                }

                else
                {
                    MessageBox.Show("Perimeter is: " + circle.Perimeter);
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
            try
            {
                double R = Convert.ToDouble(textBox1.Text);

                Circle_1 circle = new Circle_1(R);

                if (R <= 0)
                {
                    MessageBox.Show("Radius must be positive");
                }

                else
                {
                    MessageBox.Show("Area is: " + circle.Area);
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
    }
}
