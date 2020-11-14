using System;

namespace zadanie1
{
    public class QuadraticEquationRoots
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public QuadraticEquationRoots(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        private double Delta()
        {
            return Math.Pow(_b, 2) - 4*_a*_c;
        }

        public Tuple<double?, double?> Calculate()
        {
            var delta = Delta();
            double? x1 = null;
            double? x2 = null;
            if (delta > 0.0)
            {
                x1 = (-_b - Math.Sqrt(delta))/(2 * _a);
                x2 = (-_b + Math.Sqrt(delta))/(2 * _a);
            }
            else if (delta == 0.0)
            {
                x1 = -_b / (2 * _a);
            }
            return Tuple.Create(x1, x2);
        }

        public static string FormatResult(Tuple<double?, double?> result)
        {
            return $"x1: {result.Item1}, x2: {result.Item2}";
        }
    }
}
