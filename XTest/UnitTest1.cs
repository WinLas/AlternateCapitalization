using AlternateCapitalization;

namespace XTest;

public class UnitTest1
{
    [Fact]
    public void Capitalize_EmptyString_ShouldReturnEmpty()
    {
        var result = Kata.Capitalize("");
        Assert.True(result.Length == 0);
    }

     [Fact]
    public void Capitalize_SingleLetter_ShouldLowerAndUpperLetter()
    {
        var result = Kata.Capitalize("a");
        
        Assert.True(result[0] == "A");
        Assert.True(result[1] == "a");
    }
}