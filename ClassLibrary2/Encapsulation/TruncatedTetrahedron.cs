namespace Encapsulation;
public class TruncatedTetrahedron
{
    public double A { get; private set; }
    public TruncatedTetrahedron(double a)
    {
        SetA(a);
    }

    public TruncatedTetrahedron() : this(1)
    {

    }

    private void SetA(double a)
    {
        if (a < 0)
            throw new ArgumentException();
        this.A = a;
    }

    public double GetSquare() => 7 * Math.Sqrt(3) * A * A;

    public double GetVolume() => 23 / 12d * Math.Sqrt(2) * A * A * A;
}