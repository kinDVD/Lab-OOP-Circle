using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_Circle
{
    internal class Circle
    {
        private double Radius;
        public Circle(double _radius)
        {
            Radius = _radius;
        }
        public double calculateDiameter(double radius)
        {
            return radius * 2;
        }
        public double grow(double radius)
        {
            return radius *= 2;
        }
        public double getRadius(double radius)
        {
            return radius;
        }
        public double getCircumference(double radius)
        {
            return radius * 2 * Math.PI;
        }
        public double getArea(double radius)
        {
            return (radius *=2) * Math.PI;
        }
    }
}
