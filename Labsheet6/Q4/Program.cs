
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point2D firstPoint = new Point2D();

            Console.WriteLine($"Creating new instance of 2D point without parameters");
            Console.WriteLine($"2D point using toString method {firstPoint}");
            var xy = firstPoint.getXY();
            Console.WriteLine($"2D point using getX & getY method {firstPoint.getX()} {firstPoint.getY()}");
            Console.WriteLine($"2D point using getXY method {xy[0]} {xy[1]}\r\n");

            Console.WriteLine($"setting x=6 & y=7 through setXY");
            firstPoint.setXY(6, 7);
            Console.WriteLine($"2D point using toString method {firstPoint}");
            xy = firstPoint.getXY();
            Console.WriteLine($"2D point using getX & getY method {firstPoint.getX()} {firstPoint.getY()}");
            Console.WriteLine($"2D point using getXY method {xy[0]} {xy[1]}\r\n");

            Console.WriteLine($"Creating new instance with x=9.9867 & y=30.539 through setXY");
            firstPoint = new Point2D(9.9867f, 30.539f);
            Console.WriteLine($"2D point using toString method {firstPoint}");
            xy = firstPoint.getXY();
            Console.WriteLine($"2D point using getX & getY method {firstPoint.getX()} {firstPoint.getY()}");
            Console.WriteLine($"2D point using getXY method {xy[0]} {xy[1]}\r\n");

            Console.WriteLine($"---------------3D point example---------------");

            Point3D secondPoint = new Point3D();

            Console.WriteLine($"Creating new instance of 3D point without parameters");
            Console.WriteLine($"3D point using toString method {secondPoint}");
            var xyz = secondPoint.getXYZ();
            Console.WriteLine($"3D point using getX, getY & getZ method {secondPoint.getX()} {secondPoint.getY()} {secondPoint.getZ()}");
            Console.WriteLine($"3D point using getXY method {xyz[0]} {xyz[1]} {xyz[2]}\r\n");

            Console.WriteLine($"setting x=76 & y=19 through setXY (not z)");
            secondPoint.setXY(76, 19);
            Console.WriteLine($"3D point using toString method {secondPoint}");
            xyz = secondPoint.getXYZ();
            Console.WriteLine($"3D point using getX, getY & getZ method {secondPoint.getX()} {secondPoint.getY()} {secondPoint.getZ()}");
            Console.WriteLine($"3D point using getXY method {xyz[0]} {xyz[1]} {xyz[2]}\r\n");


            Console.WriteLine($"setting z=43 through setZ (to same object)");
            secondPoint.setZ(43);
            Console.WriteLine($"3D point using toString method {secondPoint}");
            xyz = secondPoint.getXYZ();
            Console.WriteLine($"3D point using getX, getY & getZ method {secondPoint.getX()} {secondPoint.getY()} {secondPoint.getZ()}");
            Console.WriteLine($"3D point using getXY method {xyz[0]} {xyz[1]} {xyz[2]}\r\n");

            Console.WriteLine($"Creating new instance with x=98.6 , y=68.9 & z=32.37 through setXY");
            secondPoint = new Point3D(98.6f, 68.9f , 32.37f);
            Console.WriteLine($"3D point using toString method {secondPoint}");
            xyz = secondPoint.getXYZ();
            Console.WriteLine($"3D point using getX, getY & getZ method {secondPoint.getX()} {secondPoint.getY()} {secondPoint.getZ()}");
            Console.WriteLine($"3D point using getXY method {xyz[0]} {xyz[1]} {xyz[2]}\r\n");



            Console.ReadKey();
        }
    }
}
