using AlternateCapitalization;

namespace NTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void Capitalize_EmptyString_ShouldReturnEmptyString()
    {
        var result = Kata.Capitalize("");
        Assert.AreEqual(result, "");
    }
}