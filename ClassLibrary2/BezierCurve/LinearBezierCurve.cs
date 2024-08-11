namespace Bezier._2;

public class LinearBezierCurve : BezierCurve
{
    public LinearBezierCurve(Point start, Point end, double t = 0d) : base(start, end, t)
    {
        dimensions = 1;
        points = [start, end];
    }
}