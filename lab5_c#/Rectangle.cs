using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_c_
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; } = "White";
        public string Unit { get; set; } = "cm";
        public int Id { get; }
        public Rectangle(double width,double height,string color,string unit,int id) {
            Width = width;
            Height = height;
            Color = color;
            Unit = unit;
            Id = id;
        }
        public double Area =>  Width * Height;

        
    }
}
