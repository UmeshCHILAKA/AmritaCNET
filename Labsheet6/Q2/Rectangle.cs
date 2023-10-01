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
        protected double height;

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
            this.height = height;
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
            this.height = height;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        public override double getArea()
        {
            return width * height;
        }

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public override double getPerimeter()
        {
            return 2*(height + width);
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"Rectangle [{base.ToString()}, width = {width}, height = {height}]";
        }
    }
}
