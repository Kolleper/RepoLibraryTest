using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public double CalculateArea(Shape shape)
        {
            return shape.GetArea();
        }
    }

}
