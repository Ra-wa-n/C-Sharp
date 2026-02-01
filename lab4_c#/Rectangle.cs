using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Rectangle:Shape
    {
        double Width { get; set; }
        double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalcArea()
        {
            return Width * Height;
        }

        public override double CalcPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
