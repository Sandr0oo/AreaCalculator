using System;

namespace ShapeLib
{
    public class Triangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new Exception("Сторона тругольника не может быть меньше нуля.");

            bool isTringleExist = a + b > c && b + c > a && a + c > b;
            if (!isTringleExist)
                throw new Exception("Такой треугольник не существует");

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            double halfPerimetr = (_a + _b + _c) / 2;
            double area = halfPerimetr * (halfPerimetr - _a) * (halfPerimetr - _b) * (halfPerimetr - _c);
            return Math.Sqrt(area);
        }

        public bool IsRightTriangle()
        {
            double[] sidesOfTringle = new double[] { _a, _b, _c };
            Array.Sort(sidesOfTringle);
            return Math.Pow(sidesOfTringle[0], 2) == Math.Pow(sidesOfTringle[1], 2) + Math.Pow(sidesOfTringle[2], 2);
        }
    }
}
