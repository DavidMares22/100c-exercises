using Xunit;

namespace _100Exercises.Tests;

public class TrackScoreTests
{
    [Fact]
    public void ShouldKeepHighestScore_WhenUpdatedWithScores()
    {
        var player = new TrackScore.Player
        {
            Statistics = new TrackScore.Statistics { HighestScore = null }
        };

        TrackScore.UpdateHighestScore(player, 100);
        TrackScore.UpdateHighestScore(player, 90);
        TrackScore.UpdateHighestScore(player, 150);

        Assert.Equal(150, player.Statistics!.HighestScore);
    }

    [Fact]
    public void ShouldNotThrow_WhenPlayerOrStatisticsMissing()
    {
        Assert.Null(Record.Exception(() => TrackScore.UpdateHighestScore(null, 10)));
        Assert.Null(Record.Exception(() => TrackScore.UpdateHighestScore(new TrackScore.Player(), 10)));
    }
}
