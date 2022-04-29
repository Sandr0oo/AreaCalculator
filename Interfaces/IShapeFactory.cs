namespace ShapeLib
{
    interface IShapeFactory
    {
        public IShape CreateTriangle(double a, double b, double c);
        public IShape CreateCircle(double radius);
    }
}
