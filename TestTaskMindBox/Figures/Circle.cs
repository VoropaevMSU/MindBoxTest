using System;

namespace TestMindBox.Figures
{
    public class Circle : IFigure
    {
        private const double Pi = Math.PI;
        public double Radius { get; }

        private Circle(double radius)
        {
            Radius = radius;
        }

        public static Circle Create(double radius)
        {
            // Validation
            if (radius > 0)
            {
                return new Circle(radius);
            }
            throw new ArgumentException($"Radius value is invalid: {radius}");
        }

        public double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Pi;
        }
    }
}