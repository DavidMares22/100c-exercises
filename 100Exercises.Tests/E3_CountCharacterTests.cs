using Xunit;

namespace _100Exercises.Tests;

public class CountCharacterTests
{
    [Fact]
    public void ShouldCountEachCharacter_WhenUsingLoop()
    {
        var result = CountCharacter.CountCharacterFrequency("aab");

        Assert.Equal(2, result['a']);
        Assert.Equal(1, result['b']);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void ShouldCountEachCharacter_WhenUsingGroupBy()
    {
        var result = CountCharacter.CountCharacterFrequency2("aab");

        Assert.Equal(2, result['a']);
        Assert.Equal(1, result['b']);
        Assert.Equal(2, result.Count);
    }
}
