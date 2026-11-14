using _100Exercises;

var exercises = new Dictionary<int, Action>
{
    [1] = ExerciseDemos.Exercise1,
    [2] = ExerciseDemos.Exercise2,
    [3] = ExerciseDemos.Exercise3,
    [4] = ExerciseDemos.Exercise4,
    [5] = ExerciseDemos.Exercise5,
    [6] = ExerciseDemos.Exercise6,
    [7] = ExerciseDemos.Exercise7,
    [8] = ExerciseDemos.Exercise8,
    [9] = ExerciseDemos.Exercise9,
    [10] = ExerciseDemos.Exercise10,
    [11] = ExerciseDemos.Exercise11
};

// Pass the exercise number as an argument (dotnet run -- 4), or type it when asked
string? input;
if (args.Length > 0)
{
    input = args[0];
}
else
{
    Console.Write($"Exercise number (1-{exercises.Count}): ");
    input = Console.ReadLine();
}

if (int.TryParse(input, out var number) && exercises.TryGetValue(number, out var run))
{
    run();
}
else
{
    Console.WriteLine($"Pick a number from 1 to {exercises.Count}.");
}
