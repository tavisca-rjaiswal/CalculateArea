using System;
using Xunit;
using CalculateAreaApp;

namespace CalculateAreaTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircle()
        {
            //Arrange
            Circle circle;

            //Act
            circle = new Circle(5);

            //Assert
            Assert.Equal(78.5, Math.Round(circle.CalculateArea(), 1));
        }
        [Fact]
        public void TestRectangle()
        {
            //Arrange
            Rectangle rectangle;

            //Act
            rectangle = new Rectangle(2, 4);

            //Assert
            Assert.Equal(8, rectangle.CalculateArea());
        }

        [Fact]
        public void TestSquare()
        {
            //Arrange
            Square square;

            //Act
            square = new Square(6);

            //Assert
            Assert.Equal(36, square.CalculateArea());
        }
        [Fact]
        public void TestTriangle()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = new Triangle(7, 8);

            //Assert
            Assert.Equal(28, triangle.CalculateArea());
        }
    }
}
