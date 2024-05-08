using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public class Circle : IShape
    {
        private double Radius;

        internal Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public static Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }
    }
}
