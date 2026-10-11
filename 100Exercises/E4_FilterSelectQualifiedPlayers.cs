
namespace _100Exercises;

public class FilterSelectQualifiedPlayers
{
    public static List<string> GetQualifiedPlayers(Dictionary<string, int> playerScores)
    {
        const int MinimumScore = 50;
        const int CheatingScore = 100;

        var results = new List<string>();

        foreach (var playerScore in playerScores)
        {
            if(playerScore.Value < MinimumScore)
            {
                continue;
            }

            if(playerScore.Value >= CheatingScore)
            {
                break;
            }
            results.Add(playerScore.Key);

        }

        return results;
    }

    public static List<string> GetQualifiedPlayers2(Dictionary<string, int> playerScores)
    {
        const int MinimumScore = 50;
        const int CheatingScore = 100;


        return playerScores.TakeWhile(playerScore => playerScore.Value < CheatingScore)
                           .Where(playerScore => playerScore.Value >= MinimumScore)
                           .Select(playerScore => playerScore.Key)
                           .ToList();

    }
}