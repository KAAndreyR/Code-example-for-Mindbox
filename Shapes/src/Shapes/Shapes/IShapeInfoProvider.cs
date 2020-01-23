namespace Geometry.Shapes
{
    public interface IShapeInfoProvider<out T>
    {
        T GetInfo(IShape shape);
    }
}