namespace Bezier._2;

public abstract class BezierCurve : Curve, IComparable<BezierCurve>
{
    private double t;
    protected int dimensions;

    public double tParameter
    {
        get => t;
        set
        {
            if (value < 0 || value > 1)
                throw new ArgumentException("Неверное значение параметра! t = [0;1]");
            t = value;
        }
    }

    protected Point[]? points;
    public IReadOnlyList<Point> Points => points.AsReadOnly();


    public BezierCurve(Point start, Point end, double t) : base(start, end)
    {
        tParameter = t;
    }

    public Point GetValue()
    {
        var xSum = Math.Pow(1 - tParameter, dimensions) * Start.X;
        var ySum = Math.Pow(1 - tParameter, dimensions) * Start.Y;
        for (var i = 1; i < dimensions; i++)
        {
            var point = points![i];
            xSum += dimensions * Math.Pow(tParameter, i) * Math.Pow(1 - tParameter, dimensions - i) * point.X;
            ySum += dimensions * Math.Pow(tParameter, i) * Math.Pow(1 - tParameter, dimensions - i) * point.Y;
        }

        xSum += Math.Pow(t, dimensions) * points[^1].X;
        ySum += Math.Pow(t, dimensions) * points[^1].Y;
        return new Point(xSum, ySum);
    }

    public int CompareTo(BezierCurve? other)
    {
        var compLength = points.Length.CompareTo(other.points.Length);
        if (compLength != 0) return compLength;
        var comp = base.CompareTo(other);
        if (comp == 0)
        {
            for (var i = 1; i < points.Length - 1; i++)
            {
                var comp2 = points[i].CompareTo(other.points[i]);
                if (comp2 != 0)
                    return comp2;
            }
        }

        return comp;
    }

    public override string ToString()
    {
        return $"{nameof(tParameter)}: {tParameter}; " + string.Join(" ", points as IEnumerable<Point>);
    }
}