using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    /// <summary>
    /// Represents a Square class
    /// </summary>
    /// <seealso cref="Q2.Rectangle" />
    internal class Square : Rectangle
    {

        public Square() { }
        public Square(double side) : base(side, side) { }
        public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

        /// <summary>
        /// Gets the radius.
        /// </summary>
        public double getSide()
        {
            return base.getLength();
        }

        /// <summary>
        /// Sets the radius.
        /// </summary>
        public void setSide(double d)
        {
            base.setWidth(d);
            base.setLength(d);
        }

        /// <summary>
        /// Sets the length.
        /// </summary>
        public new void setLength(double l)
        {
            base.setLength(l);
        }

        /// <summary>
        /// Sets the width.
        /// </summary>
        public new void setWidth(double w)
        {
            base.setWidth(w);
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Square [{base.ToString()}]";
        }
    }
}
