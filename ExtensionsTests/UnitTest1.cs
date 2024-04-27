using ConsoleApp2;
using Extensions;

namespace ExtensionsTests;

public class Tests
{
    [Test]
    public void RectangularTriangleTest()
    {
        var tr = new Triangle(3, 4, 5);
        Assert.That(tr.IsRectangular());
    }

    [Test]
    public void NonRectangularTriangleTest()
    {
        var tr = new Triangle(3, 4, 6);
        Assert.That(tr.IsRectangular(), Is.False);
    }

    [Test]
    public void RectangularTriangleDirectCallTest()
    {
        var tr = new Triangle(3, 4, 5);
        // ReSharper disable once InvokeAsExtensionMethod
        var isRect = TriangleExtensions.IsRectangular(tr);
        Assert.That(isRect);
    }
}