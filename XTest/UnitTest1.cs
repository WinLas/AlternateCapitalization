using AlternateCapitalization;

namespace XTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void Capitalize_EmptyString_ShouldReturnEmpty()
    {
        var result = Kata.Capitalize("");
        Assert.True(result.Length == 0);
    }
}