
namespace Figures.figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius should be grater then 0");
            Radius = radius;
        }

        public double GetArea()
            => Math.PI * Math.Pow(Radius, 2);
    }
}
