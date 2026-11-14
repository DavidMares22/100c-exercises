using Xunit;

namespace _100Exercises.Tests;

public class NegativeNumbersTests
{
    [Fact]
    public void ShouldReturnTrue_WhenContainsNegative()
    {
        Assert.True(NegativeNumbers.ContainsNegative(new[] { 1, -2, 3 }));
    }

    [Fact]
    public void ShouldReturnFalse_WhenNoNegatives()
    {
        Assert.False(NegativeNumbers.ContainsNegative(new[] { 0, 1, 2 }));
    }

    [Fact]
    public void ShouldReturnFalse_WhenEmpty()
    {
        Assert.False(NegativeNumbers.ContainsNegative(Array.Empty<int>()));
    }
}
