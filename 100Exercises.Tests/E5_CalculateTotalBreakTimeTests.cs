using Xunit;

namespace _100Exercises.Tests;

public class CalculateTotalBreakTimeTests
{
    [Fact]
    public void ShouldSumAllBreaks_WhenBreaksGiven()
    {
        var breaks = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2023, 4, 1, 9, 0, 0), new DateTime(2023, 4, 1, 9, 15, 0)),
            (new DateTime(2023, 4, 1, 12, 30, 0), new DateTime(2023, 4, 1, 13, 0, 0)),
            (new DateTime(2023, 4, 1, 15, 45, 0), new DateTime(2023, 4, 1, 16, 0, 0))
        };

        var result = CalculateTotal.CalculateTotalBreakTime(breaks);

        Assert.Equal(TimeSpan.FromMinutes(60), result);
    }

    [Fact]
    public void ShouldReturnZero_WhenNoBreaks()
    {
        var result = CalculateTotal.CalculateTotalBreakTime(new List<(DateTime Start, DateTime End)>());

        Assert.Equal(TimeSpan.Zero, result);
    }
}
