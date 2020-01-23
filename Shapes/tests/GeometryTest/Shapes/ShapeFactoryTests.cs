using FluentAssertions;
using Geometry.Shapes;
using System;
using Xunit;

namespace GeometryTest.Shapes
{
    public class ShapeFactoryTests
    {
        [Fact]
        public void CircleFromRadius_PositiveRadius_Success()
            => ShapeFactory.CircleFromRadius(1).Should().NotBeNull();

        [Fact]
        public void CircleFromRadius_ZeroRadius_Fail()
            => CreateCircleFromRadius(0).Should().Throw<ArgumentOutOfRangeException>();

        [Fact]
        public void CircleFromRadius_NegativeRadius_Fail()
            => CreateCircleFromRadius(-1).Should().Throw<ArgumentOutOfRangeException>();

        [Fact]
        public void CircleFromRadius_NaNRadius_Fail()
            => CreateCircleFromRadius(double.NaN).Should().Throw<ArgumentOutOfRangeException>();

        [Theory]
        [InlineData(3, 4, 5, false)]
        [InlineData(1, 1, 1, false)]
        [InlineData(3, 4, -1, true)]
        [InlineData(3, 4, 10, true)]
        [InlineData(3, 4, double.NaN, true)]
        public void TriangleFromSides(double firstSide, double secondSide, double thirdSide, bool shouldFail)
        {
            if (!shouldFail)
            {
                ShapeFactory.TriangleFromSides(firstSide, secondSide, thirdSide).Should().NotBeNull();
                ShapeFactory.TriangleFromSides(thirdSide, firstSide, secondSide).Should().NotBeNull();
                ShapeFactory.TriangleFromSides(secondSide, thirdSide, firstSide).Should().NotBeNull();
            }
            else
            {
                CreateTriangleFromSides(firstSide, secondSide, thirdSide).Should().Throw<ArgumentException>();
                CreateTriangleFromSides(thirdSide, firstSide, secondSide).Should().Throw<ArgumentException>();
                CreateTriangleFromSides(secondSide, thirdSide, firstSide).Should().Throw<ArgumentException>();
            }
        }

        private static Action CreateCircleFromRadius(double radius) => () => ShapeFactory.CircleFromRadius(radius);
        private static Action CreateTriangleFromSides(double firstSide, double secondSide, double thirdSide)
            => () => ShapeFactory.TriangleFromSides(firstSide, secondSide, thirdSide);
    }
}