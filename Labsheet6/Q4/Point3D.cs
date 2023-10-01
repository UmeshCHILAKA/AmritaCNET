using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    /// <summary>
    /// 3D point class
    /// </summary>
    /// <seealso cref="Q4.Point2D" />
    internal class Point3D : Point2D
    {
        private float z = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class.
        /// </summary>
        public Point3D() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        public Point3D(float x, float y, float z) :
            base(x, y)
        {
            this.z = z;
        }

        /// <summary>
        /// Gets the z.
        /// </summary>
        /// <returns></returns>
        public float getZ()
        { return z; }

        /// <summary>
        /// Sets the z.
        /// </summary>
        /// <param name="z">The z.</param>
        public void setZ(float z)
        {
            this.z = z;
        }

        /// <summary>
        /// Gets the xyz.
        /// </summary>
        /// <returns></returns>
        public float[] getXYZ()
        {
            var xy = getXY();
            return new float[] { xy[0], xy[1], z };
        }

        /// <summary>
        /// Sets the xyz.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        public void setXYZ(float x, float y, float z)
        {
            setXY(x, y);
            this.z = z;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var xy = getXY();
            return $"{xy[0]} {xy[1]} {z}";
        }
    }
}