using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle( 7 );
            Console.WriteLine($"Area of the circle with radius {circle.Radius} is {circle.getArea()}");
            Console.WriteLine($"Perimeter of the circle with radius {circle.Radius} is {circle.getPerimeter()}");

            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine($"Area of the rectangle with Length {rectangle.Length} and width {rectangle.Width} is {rectangle.getArea()}");
            Console.WriteLine($"Perimeter of the rectangle with Length {rectangle.Length} and width {rectangle.Width} is {rectangle.getPerimeter()}");
        }
    }

    internal class Circle : IGeometricObject
    {
        /// <summary>
        /// Gets the radius.
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        public double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public double getPerimeter()
        {
            return 2 * Math.PI * Radius * Radius;
        }
    }
    internal class Rectangle : IGeometricObject
    {
        /// <summary>
        /// Gets the length.
        /// </summary>
        public double Length { get; private set; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        public double Width { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="width">The width.</param>
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        public double getArea()
        {
            return Length * Width;
        }

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public double getPerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
