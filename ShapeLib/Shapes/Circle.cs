using System;

namespace ShapeLib
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Радиус должен быть больше нуля");
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
