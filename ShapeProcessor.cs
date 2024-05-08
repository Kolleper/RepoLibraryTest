using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public class ShapeProcessor
    {
        public double CalculateArea(Shape shape)
        {
            return shape.GetArea();
        }

        public bool IsTriangleRightAngled(Shape shape)
        {
            if (shape is Triangle triangle)
            {
                return triangle.IsRightAngled();
            }
            throw new InvalidOperationException("Эта форма не является треугольником.");
        }
    }
}
