using LibraryTest;

namespace TestProject
{
    public class Tests
    {
        private ShapeProcessor _processor;

        [SetUp]
        public void Setup()
        {
            _processor = new ShapeProcessor();
        }

        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            double area = _processor.CalculateArea(circle);
            Assert.That(area, Is.EqualTo(Math.PI * 25).Within(0.001));
        }
        [Test]
        public void TestSquareArea()
        {
            var square = new Square(3);
            double area = _processor.CalculateArea(square);
            Assert.That(area, Is.EqualTo(9));
        }

        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = _processor.CalculateArea(triangle);
            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void TriangleIsRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);
            bool isRight = _processor.IsTriangleRightAngled(triangle);
            Assert.IsTrue(isRight);
        }

        [Test]
        public void NotATriangleThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _processor.IsTriangleRightAngled(new Circle(5)));
        }

        [Test]
        public void TriangleWithInvalidSidesThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 4, 5));
        }
    }
}