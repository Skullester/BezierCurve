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
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }
    public Triangle(Point a, Point b, Point c)
    {
        Initialize(a, b, c);
    }

    /// <summary>
    /// Определяет треугольник со сторонами a,b,c в координатах (0,0);(b,0);(0,c)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    public Triangle(double a, double b, double c)
    {
        this.A = a;
        this.B = b;
        this.C = c;
        ValidateSides();
        Coordinates = new(new Point(0, 0), new Point((int)b, 0), new Point(0, (int)c));
    }

    private void Initialize(Point pointA, Point pointB, Point pointC)
    {
        this.A = GetLength(GetVector(pointA, pointB));
        this.B = GetLength(GetVector(pointB, pointC));
        this.C = GetLength(GetVector(pointC, pointA));
        Coordinates = new(pointA, pointB, pointC);
        IsRectangular = this.IsRectangular();
    }

    private void ValidateSides()
    {
        if (B + A <= C || A + C <= B || C + B <= A)
            throw new ArgumentException("Некорректно построенный треугольник!");
        IsRectangular = this.IsRectangular();
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

    public string GetDescription() => this.ToString();

    public override string ToString()
    {
        var message = "Непрямоугольный";
        if (IsRectangular)
            message = "Прямоугольный";
        return $"{Coordinates}\n" + $"Стороны:{A},{B},{C}\n{message} треугольник";
    }

}