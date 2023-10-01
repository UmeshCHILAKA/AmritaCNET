using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal abstract class Shape
    {
        protected string _color;
        protected bool _filled;
        protected Shape() : this("Red", true)
        { }
        protected Shape(string color, bool filled)
        {
            _color = color;
            _filled = filled;
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        public string getColor()
        {
            return _color;
        }

        /// <summary>
        /// Determines whether this instance is filled.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this shape is filled; otherwise, <c>false</c>.
        /// </returns>
        public bool isFilled()
        {
            return _filled;
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="color">The color.</param>
        public void setColor(string color)
        {
            _color = color;
        }

        /// <summary>
        /// Sets the filled.
        /// </summary>
        /// <param name="filled">if set to <c>true</c> [filled].</param>
        public void setFilled(bool filled)
        {
            _filled = filled;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        public abstract double getArea();

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public abstract double getPerimeter();

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"Shape [color = {_color}, filled = {_filled}]";
        }
    }
}