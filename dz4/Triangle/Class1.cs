using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;

        public double angle_1;
        public double angle_2;
        public double angle_3;

        public double perimeter;

        public Triangle(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;

            angle_1 = Math.Round((Math.Acos((a1 * a1 + b1 * b1 - c1 * c1) / (2 * a1 * b1)) * (180 / Math.PI)));
            angle_2 = Math.Round((Math.Acos((c1 * c1 + b1 * b1 - a1 * a1) / (2 * b1 * c1)) * (180 / Math.PI)));
            angle_3 = Math.Round((Math.Acos((a1 * a1 + c1 * c1 - b1 * b1) / (2 * a1 * c1)) * (180 / Math.PI)));

            perimeter = (a1 + b1 + c1);
        }

        public void ChangeSides(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }   
    }

    class EquilTriangle : Triangle
    {
        public double area;
        public EquilTriangle(double a2) : base(a2, a2, a2)
        {
            area = ((Math.Sqrt(3) / 4) * (a2 * a2));
        }

    }

    

}
