using LibraryTest;

namespace TestProject
{
    public class Tests
    {
        //проверка на вычисление площади окружности
        [Test]
        public void TestCircleArea()
        {
            var circle = Circle.CreateCircle(5);
            Assert.That(circle.GetArea(), Is.EqualTo(78.53981633974483));
        }
        //проверка на вычисление площади треугольника
        [Test]
        public void TestTriangleArea()
        {
            var triangle = Triangle.CreateTriangle(3,4,5);
            Assert.That(triangle.GetArea(), Is.EqualTo(6));
        }
        [Test]
        public void TestSquareArea()
        {
            var square = Square.CreateSquare(4);
            Assert.That(square.GetArea(), Is.EqualTo(16));
        }
        //проверка на прямоугольный треугольник
        [Test]
        public void TestRightAngledTriangle()
        {
            var triangle = Triangle.CreateTriangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }
    }
}