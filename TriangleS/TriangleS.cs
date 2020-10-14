using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TriangleS
{
    class TriangleS
    {
        public double a;
        public double b;
        public double c;
        public double angle;
        public double perimeter;
        public double area;

        public TriangleS(double a1, double b1, double angle1)
        {
            a = a1;
            b = b1;
            angle = (angle1 * (Math.PI / 180));

            c = Math.Sqrt((a * a) + (b * b) - (2 * a * b) * Math.Cos(angle));

            perimeter = Math.Round((a1 + b1 + c), 2);
            area = Math.Round(((a * b * Math.Sin(angle)) / 2), 2);
        }
    }

    class Equil_Triangle : TriangleS
    {
        public Equil_Triangle(double a2) : base(a2, a2, a2)
        {
            perimeter = Math.Round((a2 * 3), 2);
            area = Math.Round(((Math.Sqrt(3) / 4) * (a2 * a2)), 2);
        }
    }

    class Right_Triangle : TriangleS
    {
        public Right_Triangle(double a3, double b3, double angle3) : base(a3, b3, angle3)
        {
            c = Math.Sqrt((a * a) + (b * b) - (2 * a * b) * Math.Cos(angle));

            perimeter = Math.Round((a3 + b3 + c), 2);

            if (c > a3 && c > b3)
            {
                area = Math.Round(((a3 * b3) / 2), 2);
            }

            else
            {
                if (a3 > c && a3 > b3)
                {
                    area = Math.Round(((b3 * c) / 2), 2);
                }

                else
                {
                    if (b3 > a3 && b3 > c)
                    {
                        area = Math.Round(((a3 * c) / 2), 2);
                    }
                }
            }
        }
    }
}

