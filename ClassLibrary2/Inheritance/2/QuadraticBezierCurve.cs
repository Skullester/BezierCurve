namespace Bezier._2;

public class QuadraticBezierCurve : BezierCurve
{
    public Point Middle { get; }
    public QuadraticBezierCurve(Point start, Point middle, Point end, double t = 0) : base(start, end, t)
    {
        dimensions = 2;
        points = [start, middle, end];
        Middle = middle;
    }
}