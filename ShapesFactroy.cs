using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class ShapesFactroy : IShapeFactory
    {
        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public Triangle CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a,  b, c);
        }
    }
}
