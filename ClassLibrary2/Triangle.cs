using Extensions;
using System;
using System.Drawing;
using System.Numerics;

namespace ConsoleApp2;

public class Triangle
{
    public readonly struct Location(Point aPoint, Point bPoint, Point cPoint)
    {
        public Point APoint { get; } = aPoint;
        public Point BPoint { get; } = bPoint;
        public Point CPoint { get; } = cPoint;

        public override string ToString() => $"({APoint.X},{APoint.Y});({BPoint.X},{BPoint.Y});({CPoint.X},{CPoint.Y})";
    }

    public bool IsRectangular { get; private set; }
    public Location Coordinates { get; private set; }
    private double a;
    private double b;
    private double c;
    public Triangle(Point a, Point b, Point c)
    {
        Initialize(a, b, c);
    }

    /// <summary>
    /// Определяет треугольник со сторонами a,b,c в координатах (0,0);(b;0);(0,c)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        ValidateSides();
        Coordinates = new(new Point(0, 0), new Point((int)b, 0), new Point(0, (int)c));
    }

    private void Initialize(Point pointA, Point pointB, Point pointC)
    {
        this.a = GetLength(GetVector(pointA, pointB));
        this.b = GetLength(GetVector(pointB, pointC));
        this.c = GetLength(GetVector(pointC, pointA));
        ValidateSides();
        Coordinates = new(pointA, pointB, pointC);
    }

    private void ValidateSides()
    {
        if (b + a <= c || a + c <= b || c + b <= a)
            throw new ArgumentException("Некорректно построенный треугольник!");
        IsRectangular = IsRectangularMethod();
    }

    private Vector2 GetVector(Point a, Point b)
    {
        var x = b.X - a.X;
        var y = b.Y - a.Y;
        return new Vector2(x, y);
    }

    private double GetLength(Vector2 vector)
    {
        var x = vector.X;
        var y = vector.Y;
        return Math.Sqrt(x * x + y * y);
    }

    private bool IsRectangularMethod()
    {
        Func<double, double, double> squaresSum = (x, y) => Math.Sqrt(x * x + y * y);
        return c.IsApproximately(squaresSum(a, b)) || b.IsApproximately(squaresSum(a, c)) || a.IsApproximately(squaresSum(b, c));
    }

    public string GetDescription() => this.ToString();

    public override string ToString()
    {
        var message = "Непрямоугольный";
        if (IsRectangular)
            message = "Прямоугольный";
        return $"Координаты: {Coordinates}\n" + $"Стороны:{a},{b},{c}\n{message} треугольник";
    }

}