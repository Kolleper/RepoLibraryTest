using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public class Triangle : Shape
    {
        public double _Side1 { get; private set; }
        public double _Side2 { get; private set; }
        public double _Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Стороны должны быть больше нуля.");
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                throw new ArgumentException("Сумма длин любых двух сторон должна быть больше длины третьей стороны.");

            _Side1 = side1;
            _Side2 = side2;
            _Side3 = side3;
        }
        public override double GetArea()
        {
            double s = (_Side1 + _Side2 + _Side3) / 2;
            return Math.Sqrt(s * (s - _Side1) * (s - _Side2) * (s - _Side3));
        }
        public override bool IsSpecial()
        {
            var sides = new List<double> { _Side1, _Side2, _Side3 };
            sides.Sort();
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1E-10;
        }
    }
}
