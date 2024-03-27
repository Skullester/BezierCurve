using Bezier._2;

namespace Interfaces;

public class Tests
{
    private static readonly List2 sortedList = new List2
    {
        new LinearBezierCurve(new Point(0, 0), new Point(1, 5)),
        new QuadraticBezierCurve(new Point(0, 4), new Point(0, 15), new Point(2, 14)),
        new LinearBezierCurve(new Point(0, 4), new Point(4, 7)),
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
            new QuadraticBezierCurve(new Point(0, 4), new Point(0, 15), new Point(2,14)),
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

}