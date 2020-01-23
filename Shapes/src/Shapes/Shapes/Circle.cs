using System;

namespace Geometry.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }

        internal Circle(double radius)
        {
            Radius = radius;
        }

        public double Square => Math.PI * Radius * Radius;

        public T Accept<T>(IShapeVisitor<T> shapeVisitor)
            => shapeVisitor.Visit(this);
    }
}