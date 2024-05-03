using System.Drawing;

namespace Bezier._2;

public class Point : IComparable<Point>
{
    public static readonly Point Zero = new(0, 0);

    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Point(Point point) : this(point.X, point.Y)
    {
    }

    /// <summary>
    /// Создает точку с координатами (0;0)
    /// </summary>
    public Point()
    {
    }

    private bool Equals(Point? other) => X.Equals(other?.X) && Y.Equals(other.Y);

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals(obj as Point);
    }

    public int CompareTo(Point? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var cond = X.CompareTo(other.X);
        return cond != 0 ? cond : Y.CompareTo(other.Y);
    }

    public override int GetHashCode() => HashCode.Combine(X, Y);
    public override string ToString() => $"{X};{Y}";
    public static Point Subtract(Point a, Point b) => a - b;
    public static Point Add(Point a, Point b) => a + b;
    public static Point Multiply(Point a, double value) => a * value;
    public static Point operator -(Point a, Point b) => new(a.X - b.X, a.Y - b.Y);
    public static Point operator +(Point a, Point b) => new(a.X + b.X, a.Y + b.Y);
    public static Point operator *(Point a, double value) => new(a.X * value, a.Y * value);
    public static Point operator *(double value, Point a) => a * value;
}