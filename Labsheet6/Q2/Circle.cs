using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Circle : Shape
    {
        private double _radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle() : this(1) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public Circle(double radius) : base()
        {
            _radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        /// <param name="color">The color.</param>
        /// <param name="filled">if set to <c>true</c> [filled].</param>
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            _radius = radius;
        }

        /// <summary>
        /// Gets the radius.
        /// </summary>
        public double getRadius()
        {
            return _radius;
        }

        /// <summary>
        /// Sets the radius.
        /// </summary>
        public void setRadius(double d)
        {
            _radius = d;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        public override double getArea()
        {
            return Math.PI * _radius * _radius;
        }

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public override double getPerimeter()
        {
            return Math.PI * _radius * 2;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"circle [{base.ToString()}, radius = {_radius}]";
        }
    }
}
