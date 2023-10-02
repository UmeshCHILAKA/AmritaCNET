using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
Circle circle = new Circle();
Console.WriteLine("Circle 1: Radius = " + circle.getRadius() + ", Color = " + circle.getColor());
circle = new Circle(4.0);
Console.WriteLine("Circle : Radius = " + circle.getRadius() + ", Color = " + circle.getColor());
circle = new Circle(6.0, "blue");
Console.WriteLine("Circle : Radius = " + circle.getRadius() + ", Color = " + circle.getColor());

circle.setRadius(3);
circle.setColor("Orange");

Console.WriteLine("update Circle : Radius = " + circle.getRadius() + ", Color = " + circle.getColor());
        }
    }
}
