using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    /// <summary>
    /// Represents a Cylinder class
    /// </summary>
    /// <seealso cref="Q1.Circle" />
    internal class Cylinder : Circle
    {
        private double height;

        public Cylinder():this(0) { }
        public Cylinder(double radius):this(radius,0)            {         }
        public Cylinder(double radius, double height) :this(radius, height, null)        {         }
        public Cylinder(double radius, double height, string Color):base(radius, Color) 
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }

        /// <summary>
        /// Sets the height.
        /// </summary>
        /// <param name="height">The height.</param>
        public void setHeight(double height) {
            this.height = height;
        }


        /// <summary>
        /// Gets the volume.
        /// </summary>
        public double getVolume()
        {
            return getArea() * height;
        }
    }
}
