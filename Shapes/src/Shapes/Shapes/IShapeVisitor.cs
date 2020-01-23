namespace Geometry.Shapes
{
    public interface IShapeVisitor<out T>
    {
        T Visit(Circle circle);
        T Visit(Triangle triangle);
    }
}