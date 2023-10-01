using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    /// <summary>
    /// 2D point class
    /// </summary>
    internal class Point2D
    {
        float x = 0;
        float y = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class.
        /// </summary>
        public Point2D()
        {
            x = 0;
            y = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <returns></returns>
        public float getX()
        {
            return x;
        }

        /// <summary>
        /// Sets the x.
        /// </summary>
        /// <param name="x">The x.</param>
        public void setX(float x)
        {
            this.x = x;
        }
        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <returns></returns>
        public float getY()
        {
            return y;
        }

        /// <summary>
        /// Sets the y.
        /// </summary>
        /// <param name="y">The y.</param>
        public void setY(float y)
        {
            this.y = y;
        }

        /// <summary>
        /// Gets the xy.
        /// </summary>
        /// <returns></returns>
        public float[] getXY()
        {
            return new float[] { x, y };

        }

        /// <summary>
        /// Sets the xy.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void setXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
}