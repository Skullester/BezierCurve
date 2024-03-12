using System.Drawing;

namespace ConsoleApp2;

public abstract class Animal
{
    public enum AnimalEatingType
    {
        Herbivores,//Травоядные
        Carnivores,//Хищники
        Omnivores//Всеядные
    }

    public string? BirthPlace { get; }
    public Color Color { get; }
    public string Name { get; }
    public AnimalEatingType EatingType { get; }

    public Animal(string name, Color color, AnimalEatingType type)
    {
        Name = name;
        Color = color;
        EatingType = type;
    }
    public Animal(string name, Color color, AnimalEatingType type, string birthPlace) : this(name, color, type)
    {
        BirthPlace = birthPlace;
    }

    public abstract void Move();
    public string Print()
    {
        return "Животное";
    }

    public override string ToString()
    {
        return $"Животное: {Name}";
    }
}