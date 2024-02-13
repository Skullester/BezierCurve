namespace Bezier._2;

public class Curve
{
    public Point Start { get; }
    public Point End { get; }

    public Curve(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    private bool Equals(Curve other)
    {
        return Start.Equals(other.Start) && End.Equals(other.End);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals(obj as Curve);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }

    public override string ToString() => $"Start: {Start}, End: {End}";

}

