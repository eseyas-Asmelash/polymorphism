using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public override string Draw()
        {
            return $"The circle area is: {CalculateArea()} and the Perimeter is: {CalculatePerimeter()}";
        }
    }
}
