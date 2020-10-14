using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Geometric_Figures
{
    abstract class Figure
    {
        public double a;
        public double b;
        public double c;
        public double Perimeter;
        public double Area;
        public double R;
        public double h;

    }
    class Triangle_1 : Figure
    {
        public Triangle_1(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;

            Perimeter = Math.Round((a1 + b1 + c1), 2);
            double p = Perimeter / 2;
            Area = Math.Round(Math.Sqrt(p * ((p - a1) * (p - b1) * (p - c1))), 2);
        }
    }

    class Circle_1 : Figure
    {
        public Circle_1(double R1)
        {
            R = R1;

            Perimeter = Math.Round((2 * R1 * Math.PI), 2);
            Area = Math.Round((R1 * R1 * Math.PI), 2);
        }
    }

    class Rectangle_1 : Figure
    {
        public Rectangle_1(double a1, double b1)
        {
            a = a1;
            b = b1;

            Perimeter = Math.Round((2 * (a1 + b1)), 2);
            Area = Math.Round((a1 * b1), 2);
        }
    }

    class Square_1 : Figure
    {
        public Square_1(double a1)
        {
            a = a1;

            Perimeter = Math.Round((4 * a1), 2);
            Area = Math.Round((a1 * a1), 2);
        }
    }

    class Rhombus_1 : Figure
    {
        public Rhombus_1(double a1, double h1)
        {
            a = a1;
            h = h1;

            Perimeter = Math.Round((4 * a1), 2);
            Area = Math.Round((a1 * h1), 2);
        }
    }

}
