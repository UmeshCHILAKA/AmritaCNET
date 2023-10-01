using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Rectangle : Shape
    {
        protected double width;
        protected double length;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle() : this(1, 1) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Rectangle(double width, double height) : base()
        {
            this.width = width;
            this.length = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="color">The color.</param>
        /// <param name="filled">if set to <c>true</c> [filled].</param>
        public Rectangle(double width, double height, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = height;
        }

        /// <summary>
        /// Sets the length.
        /// </summary>
        public void setLength(double l)
        {
            this.length = l;
        }

        /// <summary>
        /// Sets the width.
        /// </summary>
        public void setWidth(double w)
        {
            this.width = w;
        }

        /// <summary>
        /// Gets the width.
        /// </summary>
        public double getWidth()
        {
            return this.width;
        }
        /// <summary>
        /// Gets the length.
        /// </summary>
        public double getLength()
        {
            return this.length;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        public override double getArea()
        {
            return width * length;
        }

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public override double getPerimeter()
        {
            return 2 * (length + width);
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"Rectangle [{base.ToString()}, width = {width}, height = {length}]";
        }
    }
}
