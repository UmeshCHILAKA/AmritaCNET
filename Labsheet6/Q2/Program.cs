using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();

            Console.WriteLine($"Default instance of Circle");
            Console.WriteLine($"Circle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();

            shape = new Circle(5);
            Console.WriteLine($"Circle instance with radius of 5");
            Console.WriteLine($"Circle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();

            shape = new Circle(10, "green", false);
            Console.WriteLine($"Circle instance with radius of 10 with color green and not filled");
            Console.WriteLine($"Circle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();

            shape = new Circle(1, "Yellow", true);
            Console.WriteLine($"Circle instance with radius of 1 with color Yellow and filled");
            Console.WriteLine($"Circle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();

            Console.WriteLine("----------------------Rectangle----------------------");

            shape = new Rectangle();

            Console.WriteLine($"Default instance of Rectangle");
            Console.WriteLine($"Rectangle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();

            shape = new Rectangle(2, 3);
            Console.WriteLine($"Rectangle instance with width of 2 and lenght of 3");
            Console.WriteLine($"Rectangle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();

            shape = new Rectangle(1, 5, "green", false);
            Console.WriteLine($"Rectangle instance with with width of 1 and lenght of 5, with color green and not filled");
            Console.WriteLine($"Rectangle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();

            shape = new Rectangle(4, 6, "Yellow", true);
            Console.WriteLine($"Rectangle instance with with width of 4 and lenght of 6, with color Yellow and filled");
            Console.WriteLine($"Rectangle details = {shape},\r\narea = {shape.getArea()} and perimeter = {shape.getPerimeter()}");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
