namespace ShapeLib
{
    public interface IShapeFactory
    {
        public Triangle CreateTriangle(double a, double b, double c);
        public Circle CreateCircle(double radius);
    }
}
