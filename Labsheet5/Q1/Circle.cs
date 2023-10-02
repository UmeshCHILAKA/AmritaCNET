using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Circle
    {
        private double Radius;
        private string Color;

        public Circle() : this(2, "green") { }

        public Circle(double radius) : this(radius, "green") { }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public double getRadius()
        {
            return Radius;
        }

        public string getColor()
        {
            return Color;
        }

        public void setRadius(double radius)
        {
            Radius = radius;
        }

        public void setColor(string color)
        {
            Color = color;
        }
    }
}
