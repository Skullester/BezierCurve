namespace Bezier._2;

public class CubicBezierCurve : QuadraticBezierCurve
{
    public Point AfterMiddle { get; }
    public CubicBezierCurve(Point start, Point middle, Point afterMiddle, Point end, double t) : base(start, middle, end, t)
    {
        dimensions = 3;
        points = [start, middle, afterMiddle, end];
        AfterMiddle = afterMiddle;
    }

    public CubicBezierCurve(Point start, Point middle, Point afterMiddle, Point end) : this(start, middle, afterMiddle, end, 0)
    {

    }
}