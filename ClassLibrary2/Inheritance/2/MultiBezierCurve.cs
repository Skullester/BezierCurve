namespace Bezier._2;

public class MultiBezierCurve : BezierCurve
{
    public MultiBezierCurve(IEnumerable<Point> points, double t = 0d) : base(points.First(), points.Last(), t)
    {
        Initialize(points);
    }
    public MultiBezierCurve(List<Point> points, double t = 0d) : base(points[0], points[^1], t)
    {
        Initialize(points);
    }

    private void Initialize(IEnumerable<Point> points)
    {
        this.points = points.ToArray();
        dimensions = this.points.Length - 1;
    }

    public MultiBezierCurve(params Point[] points) : this(points, 0d)
    {

    }
}