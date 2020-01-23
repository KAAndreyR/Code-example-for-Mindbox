using FluentAssertions;
using Geometry.Extensions;
using Xunit;

namespace GeometryTest.Extensions
{
    public class NumericExtensionTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 1)]
        [InlineData(1, 1)]
        [InlineData(3, 9)]
        public void Square(double number, double result)
            => number.Square().Should().Be(result);
    }
}