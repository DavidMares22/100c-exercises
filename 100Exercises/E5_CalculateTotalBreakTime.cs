namespace _100Exercises;

public class CalculateTotal
{
    // it takes a list of tuples called breaks
    public static TimeSpan CalculateTotalBreakTime
                    (List<(DateTime Start, DateTime End)> breaks)
    {
        var result = TimeSpan.Zero;
        foreach(var time in breaks)
        {
            result += time.End - time.Start;
        }
        return result;
    }
}