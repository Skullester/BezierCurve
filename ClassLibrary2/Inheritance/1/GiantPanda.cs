using System.Drawing;

namespace ConsoleApp2;

public class GiantPanda : Bear
{
    public GiantPanda(string name, Color color, AnimalEatingType type) : base(name, color, type)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Панда лениво передвигается по деревьям...");
    }
    public new string Print()
    {
        return "Панда";
    }
    public override string ToString()
    {
        return $"Панда: {Name}";
    }
}