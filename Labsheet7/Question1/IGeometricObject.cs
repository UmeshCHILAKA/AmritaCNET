using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal interface IGeometricObject
    {
        /// <summary>
        /// Gets the area.
        /// </summary>
        double getArea();

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        double getPerimeter();

    }
}
