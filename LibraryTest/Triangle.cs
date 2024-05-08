using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public class Triangle : IShape
    {
        public double _side1;
        public double _side2;
        public double _side3;

        internal Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        public double GetArea()
        {
            // Implement the area calculation for a triangle using Heron's formula
            double s = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }
        public bool IsRightAngled()
        {
            var sides = new List<double> { _side1, _side2, _side3 };
            sides.Sort();
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.001;
        }
        public static Triangle CreateTriangle(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3);
        }
    }
}
