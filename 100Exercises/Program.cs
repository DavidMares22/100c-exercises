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

var breaks = new List<(DateTime, DateTime)>
{
    (new DateTime(2023, 4, 1, 9, 0, 0), new DateTime(2023, 4, 1, 9, 15, 0)),
    (new DateTime(2023, 4, 1, 12, 30, 0), new DateTime(2023, 4, 1, 13, 0, 0)),
    (new DateTime(2023, 4, 1, 15, 45, 0), new DateTime(2023, 4, 1, 16, 0, 0))
};

var result = CalculateTotal.CalculateTotalBreakTime(breaks);
System.Console.WriteLine(result);