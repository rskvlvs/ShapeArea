
namespace Figures.figures
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
                throw new ArgumentException("Sides should be grater then 0");

            (SideA, SideB, SideC) = (sideA, sideB, sideC);

            if (!IsValidTriangle())
                throw new ArgumentException("Triangle isn't valid"); 
        }

        public double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightTriangle()
        {
            var sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            //Проверка на выполнение теоремы Пифагора с учетом допустимой погрешности (из-за плавающей точки)
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
        }

        public bool IsValidTriangle()
        {
            return SideA + SideB > SideC
                && SideA + SideC > SideB
                && SideB + SideC > SideA;
        }
    }
}
