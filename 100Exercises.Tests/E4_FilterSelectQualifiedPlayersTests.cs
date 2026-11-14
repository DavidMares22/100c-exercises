using Xunit;

namespace _100Exercises.Tests;

public class FilterSelectQualifiedPlayersTests
{
    private static Dictionary<string, int> Players() => new()
    {
        { "Anna", 45 },
        { "Ben", 80 },
        { "Uki", 70 },
        { "Cara", 100 },
        { "Derek", 90 }
    };

    [Fact]
    public void ShouldReturnQualifiedPlayers_WhenUsingLoop()
    {
        var result = FilterSelectQualifiedPlayers.GetQualifiedPlayers(Players());

        Assert.Equal(new[] { "Ben", "Uki" }, result);
    }

    [Fact]
    public void ShouldReturnQualifiedPlayers_WhenUsingLinq()
    {
        var result = FilterSelectQualifiedPlayers.GetQualifiedPlayers2(Players());

        Assert.Equal(new[] { "Ben", "Uki" }, result);
    }
}
