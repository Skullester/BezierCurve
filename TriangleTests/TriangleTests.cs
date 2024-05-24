using System.Drawing;
using ConsoleApp2;

namespace TestProject2;

public class Tests
{
    private static PointF[][] TestCasesRectangular()
    {
        return new PointF[][]
        {
            [
                new PointF(0, 0), new PointF(0, 3), new PointF(4, 0)
            ],
            [
                new PointF(0, 0), new PointF(0, 6), new PointF(8, 0)
            ],
            [
                new PointF(0, 0), new PointF(0, 9), new PointF(12, 0)
            ],
            [
                new PointF(0, 0), new PointF(0, 12), new PointF(16, 0)
            ],
        };
    }

    private static PointF[][] TestCasesSwappedRectangular() =>
        new PointF[][]
        {
            [
                new PointF(0, 0), new PointF(0, 3), new PointF(4, 0)
            ],
            [
                new PointF(0, 3), new PointF(0, 0), new PointF(4, 0)
            ],
            [
                new PointF(4, 0), new PointF(0, 0), new PointF(0, 3)
            ],
            [
                new PointF(12, 0), new PointF(0, 9), new PointF(0, 0)
            ],
            [
                new PointF(0, 0), new PointF(0, 9), new PointF(12, 0)
            ],
            [
                new PointF(0, 0), new PointF(0, 12), new PointF(16, 0)
            ],
            [
                new PointF(0, 12), new PointF(0, 0), new PointF(16, 0)
            ],
            [
                new PointF(0, 12), new PointF(16, 0), new PointF(0, 0)
            ],
        };

    private static double[][] TestCasesSidesIncorrect() =>
        new double[][]
        {
            [
                9, 4, 4
            ],
            [
                2, 2, 5
            ],
            [
                1, 1, 2
            ],
        };

    private static PointF[][] TestCasesNonRectangular() =>
        new PointF[][]
        {
            [
                new PointF(3, 0), new PointF(0, 0), new PointF(2, 1)
            ],
            [
                new PointF(0, 0), new PointF(3, 0), new PointF(2, 1)
            ],
            [
                new PointF(0, 4), new PointF(0, 0), new PointF(6, 3)
            ],
        };

    [TestCaseSource(nameof(TestCasesRectangular))]
    public void CoordinatesAreCorrect(PointF a, PointF b, PointF c)
    {
        var triangle = new Triangle(a, b, c);
        var coordinates = triangle.Coordinates;
        Assert.Multiple(() =>
        {
            Assert.That(coordinates.APoint, Is.EqualTo(a));
            Assert.That(coordinates.BPoint, Is.EqualTo(b));
            Assert.That(coordinates.CPoint, Is.EqualTo(c));
        });
    }

    [TestCaseSource(nameof(TestCasesSwappedRectangular))]
    public void TriangleCorrectSidesTest(PointF a, PointF b, PointF c)
    {
        var triangle = new Triangle(a, b, c);
        var coordinates = triangle.Coordinates;
        Assert.Multiple(() =>
        {
            Assert.That(coordinates.APoint, Is.EqualTo(a));
            Assert.That(coordinates.BPoint, Is.EqualTo(b));
            Assert.That(coordinates.CPoint, Is.EqualTo(c));
        });
    }

    [TestCaseSource(nameof(TestCasesSidesIncorrect))]
    public void TriangleInCorrectSidesTest(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [TestCaseSource(nameof(TestCasesRectangular))]
    public void Triangle_RectangularTest(PointF a, PointF b, PointF c)
    {
        var triangle = new Triangle(a, b, c);
        var isRectangular = triangle.IsRectangular;
        Assert.That(isRectangular, Is.True);
    }

    [TestCaseSource(nameof(TestCasesNonRectangular))]
    public void Triangle_Not_RectangularTest(PointF a, PointF b, PointF c)
    {
        var triangle = new Triangle(a, b, c);
        var isRectangular = triangle.IsRectangular;
        Assert.That(isRectangular, Is.False);
    }

    [TestCaseSource(nameof(TestCasesSwappedRectangular))]
    public void TriangleRectangular_ButCoordinatesAreSwappedTest(PointF a, PointF b, PointF c)
    {
        var triangle = new Triangle(a, b, c);
        var isRectangular = triangle.IsRectangular;
        Assert.That(isRectangular, Is.True);
    }
}