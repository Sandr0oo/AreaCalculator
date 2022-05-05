using System;

namespace ShapeLib
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new Exception("Радиус не может быть меньше нуля");
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
