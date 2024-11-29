using Figures;
using Figures.figures;
using FluentAssertions;

namespace ShapeAreaTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void Circle_AreaCalculation_Correct(double radius)
        {
            // Arrange
            IFigure circle = new Circle(radius);

            // Act
            var area = circle.GetArea();

            // Assert
            double res = Math.PI * Math.Pow(radius, 2);
            area.Should().Be(res);
        }

        [Fact]
        public void Circle_NegativeRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

    }
}
