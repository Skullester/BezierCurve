using System.Drawing;
using System.Threading.Channels;

namespace ConsoleApp2;

public class Bear : Animal
{

    public Bear(string name, Color color, AnimalEatingType type) : base(name, color, type)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Медведь двигается в сторону своей берлоги...");
    }
}