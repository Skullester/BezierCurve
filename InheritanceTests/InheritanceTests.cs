using System.Drawing;
using ConsoleApp2;

namespace InheritanceTests;

public class Tests
{
    [TestCase("Животное", "Панда")]
    public void MethodHidesBaseMethod(string expResult1, string expResult2)
    {
        Animal animal = new GiantPanda("По", Color.AliceBlue, Animal.AnimalEatingType.Carnivores);
        var result = animal.Print();
        var panda = new GiantPanda("По", Color.AliceBlue, Animal.AnimalEatingType.Carnivores);
        var result2 = panda.Print();
        Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expResult1));
                Assert.That(result2, Is.EqualTo(expResult2));
            });
    }

    [TestCase("Панда: По")]
    public void PolymorphicCall(string expResult)
    {
        Animal animal = new GiantPanda("По", Color.AliceBlue, Animal.AnimalEatingType.Carnivores);
        var result = animal.ToString();
        Assert.That(result, Is.EqualTo(expResult));
    }

}