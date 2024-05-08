using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public class Square : IShape
    {
        private double Side;

        internal Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
        public static Square CreateSquare(double side) 
        {
            return new Square(side);
        }
    }
}
