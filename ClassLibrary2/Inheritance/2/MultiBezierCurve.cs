namespace Bezier._2;

public class MultiBezierCurve : BezierCurve
{
    public MultiBezierCurve(IEnumerable<Point> points, double t) : base(points.First(), points.Last(), t)
    {
        dimensions = points.Count() - 1;
        this.points = points.ToArray();
    }
    public MultiBezierCurve(IEnumerable<Point> points) : this(points, 0d)
    {

    }
    public MultiBezierCurve(params Point[] points) : this(points, 0d)
    {

    }
}