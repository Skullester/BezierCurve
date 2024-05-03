namespace Bezier._2;

public class Curve : IComparable<Curve>
{
    public Point Start { get; }
    public Point End { get; }

    public Curve(Point start, Point end)
    {
        Start = start;
        End = end;
        ThrowIfNull();
    }

    private void ThrowIfNull()
    {
        ArgumentNullException.ThrowIfNull(Start);
        ArgumentNullException.ThrowIfNull(End);
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
        return Equals((obj as Curve)!);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }

    public override string ToString() => $"{nameof(Start)}: {Start}, {nameof(End)}: {End}";

    public virtual int CompareTo(Curve? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var cond = Start.CompareTo(other.Start);
        return cond != 0 ? cond : End.CompareTo(other.End);
    }
}