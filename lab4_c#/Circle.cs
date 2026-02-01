using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_c_
{
    internal class Circle:Shape
    {
        int Radius {  get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double CalcArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
        public override double CalcPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
