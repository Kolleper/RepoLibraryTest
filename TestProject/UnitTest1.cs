using LibraryTest;

namespace TestProject
{
    public class Tests
    {
        // Тест для вычисления площади окружности
        [Test]
        public void TestCircleArea()
        {
            Shape shape = new Circle(5);
            double area = shape.GetArea();//Вычисление площади фигуры без знания типа фигуры в compile-time
            Assert.That(area, Is.EqualTo(Math.PI * 25).Within(0.001));
        }
        [Test]
        public void TestSquareArea()
        {
            Shape shape = new Square(3);
            double area = shape.GetArea();//Вычисление площади фигуры без знания типа фигуры в compile-time
            Assert.That(area, Is.EqualTo(9));
        }
        [Test]
        public void TestTriangleArea()
        {
            Shape shape = new Triangle(3, 4, 5);
            double area = shape.GetArea();//Вычисление площади фигуры без знания типа фигуры в compile-time
            Assert.That(area, Is.EqualTo(6));
        }
        [Test]
        public void TriangleIsRightAngled()
        {
            Shape shape = new Triangle(3, 4, 5);
            Assert.IsTrue(shape.IsSpecial());//Проверка на прямоугольность треугольника, без знания типа фигуры в compile-time
        }
    }
}
