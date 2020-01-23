using Geometry.Extensions;
using System;
using System.Linq;

namespace Geometry.Shapes
{
    public class Triangle : IShape
    {
        private readonly double[] _sides;

        internal Triangle(params double[] sides)
            => _sides = sides
                .OrderByDescending(side => side)
                .ToArray();

        public double Square => CalcSquareByHeron(_sides.Sum() / 2);
        public bool IsRightAngled
            => Math.Abs(_sides[0].Square() - _sides[1].Square() - _sides[2].Square()) < Double.Epsilon;

        private double CalcSquareByHeron(double p)
            => Math.Sqrt(p * _sides.Aggregate(1D, (x, y) => x * (p - y)));

        public T Accept<T>(IShapeVisitor<T> shapeVisitor)
            => shapeVisitor.Visit(this);
    }
}