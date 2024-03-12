namespace Bezier._2;

public class CubicBezierCurve : BezierCurve
{
    public Point Middle { get; }
    public Point AfterMiddle { get; }
    public CubicBezierCurve(Point start, Point middle, Point afterMiddle, Point end, double t = 0) : base(start, end, t)
    {
        dimensions = 3;
        points = [start, middle, afterMiddle, end];
        Middle = middle;
        AfterMiddle = afterMiddle;
    }
}