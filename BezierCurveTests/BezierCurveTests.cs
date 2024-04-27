using Bezier._2;
using Point = Bezier._2.Point;
namespace BezierCurveTests;

public class Tests
{
    [TestCase(1, 2)]
    [TestCase(4, 6)]
    public void CreatingPoint_Test(double x, double y)
    {
        var point = new Point(x, y);
        Assert.Multiple(() =>
        {
            Assert.That(point.X, Is.EqualTo(x));
            Assert.That(point.Y, Is.EqualTo(y));
        });
    }

    [TestCase(0, 0)]
    public void CreatingPoint_With_DefaultConstructor(double x, double y)
    {
        var point = new Point();
        Assert.Multiple(() =>
        {
            Assert.That(point.X, Is.EqualTo(x));
            Assert.That(point.Y, Is.EqualTo(y));
        });
    }

    [TestCase(1, 2, 3, 4)]
    [TestCase(7, 8, 12, 1)]
    public void CreatingCurve_Test(double x0, double y0, double x1, double y1)
    {
        var curve = new Curve(new Point(x0, y0), new Point(x1, y1));
        Assert.Multiple(() =>
        {
            Assert.That(curve.Start.X, Is.EqualTo(x0));
            Assert.That(curve.Start.Y, Is.EqualTo(y0));
            Assert.That(curve.End.X, Is.EqualTo(x1));
            Assert.That(curve.End.Y, Is.EqualTo(y1));
        });
    }

    [TestCase(1, 2, 3, 4)]
    [TestCase(7, 8, 12, 1)]
    public void DifferentObjects_But_IdenticalCurve_Test(double x0, double y0, double x1, double y1)
    {
        var curve = new Curve(new Point(x0, y0), new Point(x1, y1));
        var curve2 = new Curve(new Point(x0, y0), new Point(x1, y1));
        Assert.That(curve, Is.EqualTo(curve2));
    }

    [TestCase("tParameter: 0; 1;2 1;3 2;6")]
    public void ToString_BezierCurve_Test(string example)
    {
        var curve = new QuadraticBezierCurve(new Point(1, 2), new Point(1, 3), new Point(2, 6));
        var str = curve.ToString();
        Assert.That(str, Is.EqualTo(example));
    }

    [Test]
    public void LinearBezierCurve_Is_Derived_From_Curve_Test()
    {
        var condition = typeof(LinearBezierCurve).IsSubclassOf(typeof(Curve));
        Assert.That(condition, Is.True);
    }

    [TestCase(1, 2, 3, 4, 1)]
    [TestCase(7, 8, 12, 1, 1)]
    public void LinearBezierCurveFunction_With_Max_t_ReturnValue_Equals_EndPointOfCurve(double x0, double y0, double x1, double y1, double t)
    {
        var linearBezierCurve = new LinearBezierCurve(new Point(x0, y0), new Point(x1, y1), t);
        var value = linearBezierCurve.GetValue();
        Assert.That(value, Is.EqualTo(linearBezierCurve.End));
    }

    [TestCase(1, 2, 3, 4, 0)]
    [TestCase(7, 8, 12, 1, 0)]
    public void LinearBezierCurveFunction_With_Min_t_ReturnValue_Equals_StartPointOfCurve(double x0, double y0, double x1, double y1, double t)
    {
        var linearBezierCurve = new LinearBezierCurve(new Point(x0, y0), new Point(x1, y1), t);
        var value = linearBezierCurve.GetValue();
        Assert.That(value, Is.EqualTo(linearBezierCurve.Start));
    }

    [TestCase(1, 2, 3, 4, 7, 6, 1)]
    [TestCase(7, 8, 12, 1, 8, 10, 1)]
    public void QuadraticBezierCurveFunction_With_Max_t_ReturnValue_Equals_EndPointOfCurve(double x0, double y0, double x1, double y1, double x2, double y2, double t)
    {
        var quadraticBezierCurve = new QuadraticBezierCurve(new Point(x0, y0), new Point(x1, y1), new Point(x2, y2), t);
        var value = quadraticBezierCurve.GetValue();
        Assert.That(value, Is.EqualTo(quadraticBezierCurve.End));
    }

    [TestCase(1, 2, 3, 4, 7, 6, 0)]
    [TestCase(7, 8, 12, 1, 8, 10, 0)]
    public void QuadraticBezierCurveFunction_With_Min_t_ReturnValue_Equals_StartPointOfCurve(double x0, double y0, double x1, double y1, double x2, double y2, double t)
    {
        var quadraticBezierCurve = new QuadraticBezierCurve(new Point(x0, y0), new Point(x1, y1), new Point(x2, y2), t);
        var value = quadraticBezierCurve.GetValue();
        Assert.That(value, Is.EqualTo(quadraticBezierCurve.Start));
    }

    [TestCase(1, 2, 3, 4, 7, 6, 0.5, 3.5, 4)]
    [TestCase(7, 8, 12, 1, 8, 10, 0.5, 9.75, 5)]
    public void QuadraticBezierCurveFunctionTest(double x0, double y0, double x1, double y1, double x2, double y2, double t, double expPointX, double expPointY)
    {
        var expPoint = new Point(expPointX, expPointY);
        var quadraticBezierCurve = new QuadraticBezierCurve(new Point(x0, y0), new Point(x1, y1), new Point(x2, y2), t);
        var value = quadraticBezierCurve.GetValue();
        Assert.That(value, Is.EqualTo(expPoint));
    }

    [TestCase(1, 2, 3, 4, 52)]
    [TestCase(7, 8, 12, 1, -12)]
    public void ThrowException_If_Parameter_Is_Incorrect(double x0, double y0, double x1, double y1, double t)
    {
        Assert.Throws<ArgumentException>(() => new LinearBezierCurve(new Point(x0, y0), new Point(x1, y1), t));
    }

    [TestCase(1, 2, 3, 4)]
    [TestCase(7, 8, 12, 1)]
    public void AddingSameObjects_In_HashMap(double x0, double y0, double x1, double y1)
    {
        var map = new HashSet<Curve>();
        var curve = new Curve(new Point(x0, y0), new Point(x1, y1));
        map.Add(curve);
        var curve2 = new Curve(new Point(x0, y0), new Point(x1, y1));
        map.Add(curve2);
        Assert.That(map, Has.Count.EqualTo(1));
    }

    [TestCase(1, 2, 3, 4)]
    [TestCase(7, 8, 12, 1)]
    public void DifferentObjects_But_TheSameKeyInDictionary_ThrowsException(double x0, double y0, double x1, double y1)
    {
        var map = new Dictionary<Curve, int>();
        var curve = new Curve(new Point(x0, y0), new Point(x1, y1));
        map.Add(curve, 1);
        var curve2 = new Curve(new Point(x0, y0), new Point(x1, y1));
        Assert.That(() => map.Add(curve2, 2), Throws.Exception);
    }
}
