using System;

namespace TestMindBox.Figures
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        private Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public static Triangle Create(double a, double b, double c)
        {
            // Validation
            if (a > 0 && b > 0 && c > 0)
            {
                return new Triangle(a, b, c);
            }
            throw new ArgumentException($"Side value is invalid: a = {a}, b = {b}, c = {c} ");
        }

        public double CalculateArea()
        {
            var p = 0.5 * (A + B + C);
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); 
        }

        public bool IsRectangular()
        {
            return IsRectangular(A, B, C) || IsRectangular(B, A, C) || IsRectangular(C, A, B);
        }

        private static bool IsRectangular(double hypotenuse, double b, double c)
        {
            // Тут может быть проблема с точностью, можно решить ее, например сравнивая с определенной точностью
            return Math.Pow(hypotenuse, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
        }
        
    }
}