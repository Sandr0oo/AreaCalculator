using System;

namespace ShapeLib
{
    public class Triangle : IShape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Сторона тругольника не может быть равна нулю или быть меньше нуля.");

            bool isTringleExist = a + b > c && b + c > a && a + c > b;
            if (!isTringleExist)
                throw new Exception("Такой треугольник не существует");

            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            double halfPerimetr = (A + B + C) / 2;
            double area = halfPerimetr * (halfPerimetr - A) * (halfPerimetr - B) * (halfPerimetr - C);
            return Math.Sqrt(area);
        }

        public bool IsRightTriangle()
        {
            double[] sidesOfTringle = new double[] { A, B, C };
            Array.Sort(sidesOfTringle);
            return Math.Pow(sidesOfTringle[2], 2) == Math.Pow(sidesOfTringle[1], 2) + Math.Pow(sidesOfTringle[0], 2);
        }
    }
}
