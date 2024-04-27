using System;
using System.Drawing;
using ConsoleApp2;

namespace TestProject2;

public class Tests
{
    private static Point[][] TestCasesRectangular()
    {
        return new Point[][]
        {
            [
                new Point(0, 0), new Point(0, 3), new Point(4, 0)
            ],
            [
                new Point(0,0), new Point(0,6), new Point(8,0)
            ],
            [
                new Point(0,0), new Point(0,9), new Point(12,0)
            ],
            [
                new Point(0,0), new Point(0,12), new Point(16,0)
            ],

        };
    }

    private static Point[][] TestCasesSwappedRectangular() =>
        new Point[][]
        {
            [
                new Point(0, 0), new Point(0, 3), new Point(4, 0)
            ],
            [
                new Point(0, 3), new Point(0, 0), new Point(4, 0)
            ],
            [
                new Point(4, 0), new Point(0, 0), new Point(0, 3)
            ],
            [
                new Point(12,0), new Point(0,9), new Point(0,0)
            ],
            [
                new Point(0,0), new Point(0,9), new Point(12,0)
            ],
            [
                new Point(0,0), new Point(0,12), new Point(16,0)
            ],
            [
                new Point(0,12), new Point(0,0), new Point(16,0)
            ],
            [
                new Point(0,12), new Point(16,0), new Point(0,0)
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

    private static Point[][] TestCasesNonRectangular() =>
        new Point[][]
        {
            [
                new Point(3,0), new Point(0,0), new Point(2,1)
            ],
            [
                new Point(0, 0), new Point(3, 0), new Point(2, 1)
            ],
            [
                new Point(0, 4), new Point(0, 0), new Point(6, 3)
            ],
        };

    [TestCaseSource(nameof(TestCasesRectangular))]
    public void CoordinatesAreCorrect(Point a, Point b, Point c)
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
    public void TriangleCorrectSidesTest(Point a, Point b, Point c)
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
    public void Triangle_RectangularTest(Point a, Point b, Point c)
    {
        var triangle = new Triangle(a, b, c);
        var isRectangular = triangle.IsRectangular;
        Assert.That(isRectangular, Is.True);
    }

    [TestCaseSource(nameof(TestCasesNonRectangular))]
    public void Triangle_Not_RectangularTest(Point a, Point b, Point c)
    {
        var triangle = new Triangle(a, b, c);
        var isRectangular = triangle.IsRectangular;
        Assert.That(isRectangular, Is.False);
    }

    [TestCaseSource(nameof(TestCasesSwappedRectangular))]
    public void TriangleRectangular_ButCoordinatesAreSwappedTest(Point a, Point b, Point c)
    {
        var triangle = new Triangle(a, b, c);
        var isRectangular = triangle.IsRectangular;
        Assert.That(isRectangular, Is.True);
    }
}