using Xunit;

namespace _100Exercises.Tests;

public class CheckPalindromeTests
{
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("dog", false)]
    [InlineData("a", true)]
    [InlineData("ab", false)]
    [InlineData("", true)]
    public void ShouldMatchExpected_ForAllImplementations(string input, bool expected)
    {
        Assert.Equal(expected, CheckPalindrome.IsPalindrome(input));
        Assert.Equal(expected, CheckPalindrome.IsPalindrome2(input));
        Assert.Equal(expected, CheckPalindrome.IsPalindrome3(input));
    }
}
