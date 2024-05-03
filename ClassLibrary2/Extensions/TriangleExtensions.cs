using ConsoleApp2;

namespace Extensions;

public static class TriangleExtensions
{
    public static bool IsRectangular(this Triangle triangle)
    {
        var a = triangle.A;
        var b = triangle.B;
        var c = triangle.C;
        Func<double, double, double> squaresSum = (x, y) => Math.Sqrt(x * x + y * y);
        return c.IsApproximatelyEqualTo(squaresSum(a, b)) || b.IsApproximatelyEqualTo(squaresSum(a, c)) || a.IsApproximatelyEqualTo(squaresSum(b, c));
    }
}