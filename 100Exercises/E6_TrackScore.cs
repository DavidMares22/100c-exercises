namespace _100Exercises;

public class TrackScore
{
    public static void UpdateHighestScore(Player? player, int newScore)
    {
       if(player?.Statistics is null)
        {
            return;
        }
        // if highscore is null it will assign the value of the newscore
        player.Statistics.HighestScore ??= newScore;
        if(player.Statistics.HighestScore < newScore)
        {
            player.Statistics.HighestScore = newScore;
        }
        
    }

    public class Player
    {
        public Statistics? Statistics { get; set; }
    }

    public class Statistics
    {
        public int? HighestScore { get; set; }
    }
}