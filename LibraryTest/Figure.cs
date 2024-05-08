namespace LibraryTest
{
    public class Figure
    {
        public class Circle : IShape
        {
            public double Radius { get; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double GetArea()
            {
                return Math.PI * Radius * Radius;
            }
        }
        public class Triangle : IShape
        {
            public double A { get; }
            public double B { get; }
            public double C { get; }

            public Triangle(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public double GetArea()
            {
                double s = (A + B + C) / 2;
                return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            }

            public bool IsRightAngled()
            {
                var sides = new List<double> { A, B, C };
                sides.Sort();
                return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.001;
            }
        }
    }
}
