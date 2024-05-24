using Bezier._2;

namespace Interfaces;

public class Tests
{
    private static readonly List2 sortedList = new List2
    {
        new LinearBezierCurve(new Point(0, 0), new Point(1, 5)),
        new LinearBezierCurve(new Point(0, 4), new Point(4, 7)),
        new QuadraticBezierCurve(new Point(0, 4), new Point(0, 15), new Point(2, 14)),
    };

    [Test]
    public void InheritanceTest()
    {
        var cond = typeof(List2).IsSubclassOf(typeof(List<BezierCurve>));
        Assert.That(cond, Is.True);
    }

    [Test]
    public void AddingElementsTest()
    {
        var list = CreateList();
        Assert.That(list, Has.Count.EqualTo(3));
    }

    private List2 CreateList() =>
        new()
        {
            new QuadraticBezierCurve(new Point(0, 4), new Point(0, 15), new Point(2, 14)),
            new LinearBezierCurve(new Point(0, 4), new Point(4, 7)),
            new LinearBezierCurve(new Point(0, 0), new Point(1, 5)),
        };

    [Test]
    public void SortingTest()
    {
        var list = CreateList();
        list.Sort();
        CollectionAssert.AreEqual(list, sortedList);
    }

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