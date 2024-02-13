namespace Bezier._2;

public abstract class BezierCurve : Curve
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
    public IReadOnlyList<Point> Points => points;
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

    public override string ToString()
    {
        return $"{nameof(tParameter)}: {tParameter} " + base.ToString();
    }
}