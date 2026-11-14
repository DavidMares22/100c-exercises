namespace _100Exercises;

public static class ExerciseDemos
{
    public static void Exercise1()
    {
        var result = NegativeNumbers.ContainsNegative([1, 2, 3, 4, 5]);
        Console.WriteLine(result);
    }

    public static void Exercise2()
    {
        var result = SplitName.SplitFullName("David Mares");
        Console.WriteLine("firstName " + result.firstName + " lastName " + result.lastName);
    }

    public static void Exercise3()
    {
        var result = CountCharacter.CountCharacterFrequency("Hola amigos como estan");
        Console.WriteLine(string.Join(", ", result));

        var result2 = CountCharacter.CountCharacterFrequency2("Hola amigos como estan");
        Console.WriteLine(string.Join(", ", result2));
    }

    public static void Exercise4()
    {
        var players = new Dictionary<string, int>
        {
            { "Anna", 45 },
            { "Ben", 80 },
            { "Uki", 70 },
            { "Cara", 100 },
            { "Derek", 90 },
            { "Ella", 70 }
        };

        var result = FilterSelectQualifiedPlayers.GetQualifiedPlayers2(players);
        Console.WriteLine(string.Join(", ", result));
    }

    public static void Exercise5()
    {
        var breaks = new List<(DateTime, DateTime)>
        {
            (new DateTime(2023, 4, 1, 9, 0, 0), new DateTime(2023, 4, 1, 9, 15, 0)),
            (new DateTime(2023, 4, 1, 12, 30, 0), new DateTime(2023, 4, 1, 13, 0, 0)),
            (new DateTime(2023, 4, 1, 15, 45, 0), new DateTime(2023, 4, 1, 16, 0, 0))
        };

        var result = CalculateTotal.CalculateTotalBreakTime(breaks);
        Console.WriteLine(result);
    }

    public static void Exercise6()
    {
        var player = new TrackScore.Player
        {
            Statistics = new TrackScore.Statistics { HighestScore = null }
        };

        TrackScore.UpdateHighestScore(player, 100);
        TrackScore.UpdateHighestScore(player, 90);
        TrackScore.UpdateHighestScore(player, 150);

        Console.WriteLine(player.Statistics!.HighestScore);
    }

    public static void Exercise7()
    {
        Console.WriteLine(CalculateCost.CalculateShippingCost(30, false));  // => 10
        Console.WriteLine(CalculateCost.CalculateShippingCost(30, true));   // => 5
        Console.WriteLine(CalculateCost.CalculateShippingCost2(60, false)); // => 5
        Console.WriteLine(CalculateCost.CalculateShippingCost(60, true));   // => 0
    }

    public static void Exercise8()
    {
        bool result = TryExtract.TryExtractDateComponents(
            dateInput: "2024-12-15",
            year: out var y,
            month: out var m,
            day: out var d
        );
        Console.WriteLine($"result {result} | year {y} | month {m} | day {d}");
    }

    public static void Exercise9()
    {
        bool result = CheckPalindrome.IsPalindrome("dog");
        Console.WriteLine(result);
    }

    public static void Exercise10()
    {
        var schedule = new WeekSchedule();
        schedule[DayOfWeek.Monday] = "Gym";
        schedule["Friday"] = "Dinner with friends";

        var mondayNote = schedule["monday"];          // => "Gym" (case-insensitive)
        var fridayNote = schedule[DayOfWeek.Friday];  // => "Dinner with friends"
        var tuesdayNote = schedule["Tuesday"];        // => null

        Console.WriteLine($"{mondayNote} -> for monday");
        Console.WriteLine($"{tuesdayNote} -> for tuesday");
        Console.WriteLine($"{fridayNote} -> for friday");
    }

    public static void Exercise11()
    {
        var fileSystem = new InMemoryFileSystem(
            new Dictionary<string, string>
            {
                { "readme.txt", "This is the readme file content." }
            }
        );
        var logger = new ConsoleLogger();

        var exercise = new ReadFile(fileSystem, logger);

        try
        {
            var content = exercise.TryReadFile("reame.txt");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was missing.");
        }
    }
}
