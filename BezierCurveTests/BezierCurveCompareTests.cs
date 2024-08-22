using Bezier._2;
using NUnit.Framework.Legacy;

namespace BezierCurveTests;

public class BezierCurveCompareTests
{
    [Test]
    public void BezierCurve_Of_DifferentTypes_ComparingTest()
    {
        var linear = new LinearBezierCurve(new Point(1, 2), new Point(2, 3));
        var quadratic = new QuadraticBezierCurve(new Point(1, 2), new Point(2, 3), new Point(4, 3));
        var comp = linear.CompareTo(quadratic);
        Assert.That(comp, Is.EqualTo(-1));
    }

    [Test]
    public void BezierCurve_Of_SameType_ComparingTest1()
    {
        var quadratic1 = new QuadraticBezierCurve(new Point(1, 2), new Point(1, 3), new Point(4, 3));
        var quadratic2 = new QuadraticBezierCurve(new Point(1, 2), new Point(2, 3), new Point(4, 3));
        var comp = quadratic1.CompareTo(quadratic2);
        Assert.That(comp, Is.EqualTo(-1));
    }

    [Test]
    public void BezierCurve_Of_SameType_ComparingTest2()
    {
        var quadratic1 = new QuadraticBezierCurve(new Point(1, 2), new Point(1, 3), new Point(4, 3));
        var quadratic2 = new QuadraticBezierCurve(new Point(1, 2), new Point(1, 3), new Point(4, 3));
        var comp = quadratic1.CompareTo(quadratic2);
        Assert.That(comp, Is.EqualTo(0));
    }
}