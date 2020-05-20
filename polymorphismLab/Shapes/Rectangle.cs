using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2*(Height + Width), 2);
        }
        public override double CalculateArea()
        {
            return Math.Round(Height * Width, 2);
        }

        public override string Draw()
        {
            return $"The rectangle area is: {CalculateArea()} and the Perimeter is: {CalculatePerimeter()}";
        }
    }
}
