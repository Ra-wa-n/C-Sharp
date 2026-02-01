using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Triangle:Shape
    {
         double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        
        public override double CalcArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override double CalcPerimeter()
        {
            return A + B + C;
        }
    }
}
