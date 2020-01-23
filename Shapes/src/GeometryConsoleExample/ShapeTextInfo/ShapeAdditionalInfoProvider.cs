using Geometry.Shapes;
using System;

namespace GeometryConsoleExample.ShapeTextInfo
{
    public class ShapeAdditionalInfoProvider : IShapeAdditionalInfoProvider
    {
        public string Visit(Circle circle) => String.Empty;

        public string Visit(Triangle triangle)
            => triangle.IsRightAngled
                ? "Triangle is right"
                : "Triangle is NOT right";
    }
}