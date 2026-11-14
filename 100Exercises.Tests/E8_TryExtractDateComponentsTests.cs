using Xunit;

namespace _100Exercises.Tests;

public class TryExtractDateComponentsTests
{
    [Fact]
    public void ShouldReturnDateComponents_WhenDateIsValid()
    {
        var result = TryExtract.TryExtractDateComponents("2024-12-15", out var year, out var month, out var day);

        Assert.True(result);
        Assert.Equal(2024, year);
        Assert.Equal(12, month);
        Assert.Equal(15, day);
    }

    [Fact]
    public void ShouldReturnFalseAndZeros_WhenDateIsInvalid()
    {
        var result = TryExtract.TryExtractDateComponents("not a date", out var year, out var month, out var day);

        Assert.False(result);
        Assert.Equal(0, year);
        Assert.Equal(0, month);
        Assert.Equal(0, day);
    }
}
