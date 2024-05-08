using LibraryTest;

namespace TestProject
{
    public class Tests
    {
        //�������� �� ���������� ������� ����������
        [Test]
        public void TestCircleArea()
        {
            var circle = Circle.CreateCircle(5);
            Assert.That(circle.GetArea(), Is.EqualTo(78.53981633974483));
        }
        //�������� �� ���������� ������� ������������
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
        //�������� �� ������������� �����������
        [Test]
        public void TestRightAngledTriangle()
        {
            var triangle = Triangle.CreateTriangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }
    }
}