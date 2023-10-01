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
            Cylinder cyl = new Cylinder();
            Console.WriteLine($"Default Cylinder class initiated");
            Console.WriteLine($"Volume of Cylinder is {cyl.getVolume()}");

            cyl = new Cylinder(10);
            Console.WriteLine($"Cylinder with radius={cyl.getRadius()} initiated");
            Console.WriteLine($"Volume of Cylinder is {cyl.getVolume()}");

            cyl = new Cylinder(10, 1);
            Console.WriteLine($"Cylinder with radius={cyl.getRadius()} and height={cyl.getVolume()} initiated");
            Console.WriteLine($"Volume of Cylinder is {cyl.getVolume()}");

            cyl = new Cylinder(10, 0.1, "Green");
            Console.WriteLine($"Cylinder with radius={cyl.getRadius()} and height={cyl.getVolume()} of {cyl.getColor()} color initiated");
            Console.WriteLine($"Volume of Cylinder is {cyl.getVolume()}");

            Console.ReadKey();
        }
    }
}
