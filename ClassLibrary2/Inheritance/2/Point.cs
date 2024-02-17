using System.Drawing;

namespace Bezier._2;

public class Point
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
    { }
    /// <summary>
    /// Создает точку с координатами (0;0)
    /// </summary>
    public Point()
    {
    }
    private bool Equals(Point? other)
    {
        return X.Equals(other?.X) && Y.Equals(other.Y);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals(obj as Point);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public static Point Subtract(Point a, Point b)
    {
        return a - b;
    }

    public static Point Add(Point a, Point b)
    {
        return a + b;
    }
    public static Point Multiply(Point a, double value)
    {
        return a * value;
    }

    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y);
    }

    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    public static Point operator *(Point a, double value)
    {
        return new Point(a.X * value, a.Y * value);
    }

    public override string ToString() => $"{X};{Y}";
}