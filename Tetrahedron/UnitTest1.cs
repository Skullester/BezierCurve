using Encapsulation;
namespace TruncatedTetrahedronTests;

public class TruncatedTetrahedronTests
{
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    public void TetrahedronCreatingTest(double a)
    {
        var tetr = new TruncatedTetrahedron(a);
        Assert.That(a, Is.EqualTo(tetr.A));
    }

    [TestCase(0)]
    [TestCase(-2)]
    [TestCase(-3)]
    [TestCase(-4)]
    public void TestException(double a) => Assert.Throws<ArgumentException>(() => new TruncatedTetrahedron(a));

    [TestCase(303.1088913245535, 5)]
    public void GetSquareTest(double value, double a)
    {
        var tetr = new TruncatedTetrahedron(a);
        var square = tetr.GetSquare();
        Assert.That(value, Is.EqualTo(square).Within(1E-04));
    }

    [TestCase(4683.875318579692, 12)]
    [TestCase(338.82199931855405, 5)]
    public void GetVolumeTest(double exp, double a)
    {
        var vol = new TruncatedTetrahedron(a).GetVolume();
        Assert.That(exp, Is.EqualTo(vol).Within(1E-04));
    }
}