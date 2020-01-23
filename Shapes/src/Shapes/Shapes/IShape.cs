namespace Geometry.Shapes
{
    public interface IShape
    {
        double Square { get; }
        T Accept<T>(IShapeVisitor<T> shapeVisitor);
    }
}
