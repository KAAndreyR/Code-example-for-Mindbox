using Geometry.Shapes;
using GeometryConsoleExample.ShapeTextInfo;
using System;

namespace GeometryConsoleExample
{
    class Program
    {
        public static IShapeDescriptionProvider DescriptionProvider { get; } = new ShapeInfoProvider(new ShapeAdditionalInfoProvider());

        static void Main(string[] args)
        {
            string? input = null;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1.Circle");
                    Console.WriteLine("2.Triangle");
                    input = Console.ReadLine();
                    Console.WriteLine();
                    switch (input)
                    {
                        case "1":
                            Output(ReadCircle());
                            break;
                        case "2":
                            Output(ReadTriangle());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occured:{ex.Message}");
                }
                Console.WriteLine();
                Console.WriteLine("Press key to continue...");
                Console.ReadKey();
            } while (input == null || !input.Contains('q', StringComparison.InvariantCultureIgnoreCase));
        }

        private static void Output(IShape? shape)
            => Console.WriteLine(shape == null ? "Shape not provided" : DescriptionProvider.GetInfo(shape));

        private static Circle? ReadCircle()
            => TryReadDouble("Radius:", out var radius)
                ? ShapeFactory.CircleFromRadius(radius)
                : null;

        private static Triangle? ReadTriangle()
            => TryReadDouble("First side:", out var firstSide)
                    && TryReadDouble("Second side:", out var secondSide)
                    && TryReadDouble("Third side:", out var thirdSide)
                ? ShapeFactory.TriangleFromSides(firstSide, secondSide, thirdSide)
                : null;

        private static bool TryReadDouble(string prompt, out double value)
        {
            Console.WriteLine(prompt);
            var stringValue = Console.ReadLine();
            if (Double.TryParse(stringValue, out value))
                return true;
            Console.WriteLine("Wrong number");
            return false;
        }
    }
}
