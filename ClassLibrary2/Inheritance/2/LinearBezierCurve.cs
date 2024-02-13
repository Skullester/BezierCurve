namespace Bezier._2;

public class LinearBezierCurve : BezierCurve
{
    public LinearBezierCurve(Point start, Point end, double t) : base(start, end, t)
    {
        dimensions = 1;
        points = [start, end];
    }

    public LinearBezierCurve(Point start, Point end) : this(start, end, 0d)
    {

    }
}