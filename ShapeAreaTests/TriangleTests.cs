using Figures;
using Figures.figures;
using FluentAssertions;

namespace ShapeAreaTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(6, 6, 6)]
        [InlineData(7, 8, 9)]
        public void Triangle_AreaCalculation_Correct(double sideA, double sideB, double sideC)
        {
            // Arrange
            IFigure triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = triangle.GetArea();

            // Assert
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double res = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            area.Should().Be(res); 
        }

        [Theory]
        [InlineData(1, 1, 10)]
        [InlineData(1, -1, 1)]
        [InlineData(-1, 1, 1)]
        [InlineData(1, 1, -1)]
        public void Triangle_InvalidSides_ThrowsException(double sideA, double sideB, double sideC)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 5, true)]  
        [InlineData(5, 5, 8, false)] 
        [InlineData(6, 8, 10, true)] 
        [InlineData(7, 24, 25, true)]
        public void Triangle_IsRightTriangle_Correct(double sideA, double sideB, double sideC, bool expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var isRight = triangle.IsRightTriangle();

            // Assert
            isRight.Should().Be(expected);
        }
    }
}
