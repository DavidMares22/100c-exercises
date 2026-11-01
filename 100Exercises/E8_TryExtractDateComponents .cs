using System.Globalization;

namespace _100Exercises;

public class TryExtract
{
    public static bool TryExtractDateComponents(string dateInput, out int year, out int month, out int day)
    {
        year = 0;
        month = 0;
        day = 0;
        bool success = DateTime.TryParse(
            dateInput, 
            CultureInfo.InvariantCulture,
            out DateTime date);
            
        if(success) {day = date.Day; month = date.Month; year = date.Year;}
        return success;
    }
}