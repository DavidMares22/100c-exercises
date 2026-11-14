using _100Exercises;

// Exercise 1

// var result = NegativeNumbers.ContainsNegative([1,2,3,4,5]);
// System.Console.WriteLine(result);

// Exercise 2

// var result = SplitName.SplitFullName("David Mares");
// System.Console.WriteLine("firstName " + result.firstName + " lastName " + result.lastName );

// Exercise 3

// var result = CountCharacter.CountCharacterFrequency("Hola amigos como estan");
// System.Console.WriteLine(string.Join(", ", result ));

// var result = CountCharacter.CountCharacterFrequency2("Hola amigos como estan");
// System.Console.WriteLine(string.Join(", ", result));

// Exercise 4

// var players = new Dictionary<string, int>
// {
//     { "Anna", 45 },
//     { "Ben", 80 },
//     { "Uki", 70 },
//     { "Cara", 100 }, 
//     { "Derek", 90 },
//     { "Ella", 70 }
// };

// var result = FilterSelectQualifiedPlayers.GetQualifiedPlayers2(players);
// System.Console.WriteLine(string.Join(", ", result));

// Exercise 5

// var breaks = new List<(DateTime, DateTime)>
// {
//     (new DateTime(2023, 4, 1, 9, 0, 0), new DateTime(2023, 4, 1, 9, 15, 0)),
//     (new DateTime(2023, 4, 1, 12, 30, 0), new DateTime(2023, 4, 1, 13, 0, 0)),
//     (new DateTime(2023, 4, 1, 15, 45, 0), new DateTime(2023, 4, 1, 16, 0, 0))
// };

// var result = CalculateTotal.CalculateTotalBreakTime(breaks);
// System.Console.WriteLine(result);

// Exercise 6

// var player = new TrackScore.Player
// {
//     Statistics = new TrackScore.Statistics { HighestScore = null }
// };
 
// TrackScore.UpdateHighestScore(player, 100);
// TrackScore.UpdateHighestScore(player, 90);
// TrackScore.UpdateHighestScore(player, 150);

// System.Console.WriteLine(player.Statistics.HighestScore);

// Exercise 7
// var result = CalculateCost.CalculateShippingCost(30, false); // => 10
// var result = CalculateCost.CalculateShippingCost(30, true);  // => 5
// var result = CalculateCost.CalculateShippingCost2(60, false); // => 5
// var result = CalculateShippingCost(60, true);  // => 0

// System.Console.WriteLine(result);

// Exercise 8

// bool result = TryExtract.TryExtractDateComponents(
//     dateInput: "2024-12-15",
//     year: out var y,
//     month: out var m,
//     day: out var d
// );
// System.Console.WriteLine($"result {result} | yeaar {y} | month {m} | day {d}");
// result == true, y == 2024, m == 12, d == 15

// Exercise 9

// bool result = CheckPalindrome.IsPalindrome("dog");
// System.Console.WriteLine(result);


// Exercise 10

// var schedule = new WeekSchedule();
// schedule[DayOfWeek.Monday] = "Gym";
// schedule["Friday"] = "Dinner with friends";
 
// var mondayNote = schedule["monday"];   // => "Gym" (case-insensitive)
// var fridayNote = schedule[DayOfWeek.Friday]; // => "Dinner with friends"
// var tuesdayNote = schedule["Tuesday"]; // => null

// System.Console.WriteLine($"{mondayNote} -> for monday");
// System.Console.WriteLine($"{tuesdayNote} -> for tuesday");
// System.Console.WriteLine($"{fridayNote} -> for friday");

// Exercise 11

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