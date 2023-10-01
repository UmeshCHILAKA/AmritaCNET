using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    /// <summary>
    /// Represents a circle class
    /// </summary>
    internal class Circle
    {
        private double _radius;
        private string _color;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle() : this(0, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public Circle(double radius) : this(radius, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        /// <param name="color">The color.</param>
        public Circle(double radius, string color)
        {
            _color = color;
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
        /// Gets the color.
        /// </summary>
        public string getColor()
        {
            return _color;
        }

        /// <summary>
        /// Sets the radius.
        /// </summary>
        public void setRadius(double d)
        {
            _radius = d;
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        public void setColor(String c)
        {
            _color=c;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        public double getArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}