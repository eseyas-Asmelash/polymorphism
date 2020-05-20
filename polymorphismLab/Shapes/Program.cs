using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(12.5);
            Rectangle rect = new Rectangle(3.5, 4.7);

            Console.WriteLine($"Circle\'s perimeter is {circle.CalculatePerimeter()}.\n");
            Console.WriteLine($"Circle\'s Area is {circle.CalculateArea()}.\n");
            Console.WriteLine($"Rectangle\'s perimeter is {rect.CalculatePerimeter()}.\n");
            Console.WriteLine($"Rectangle\'s Area is {rect.CalculateArea()}.\n");
            Console.ReadKey();

        }
    }
}
