using System;

namespace _100Exercises;

// Your WeekSchedule is a candy machine with 7 buttons, one per day.

// The DayOfWeek indexer is pressing a button directly. You know exactly which one — Monday is button 1, Tuesday is button 2, etc.
// The string indexer is saying "I want the Monday candy" out loud. A little helper inside the machine listens, figures out which button you mean, and presses it for you. It never touches the candy shelf itself — it just translates and hands off to the button.
// Without the indexers, there are no buttons at all. You'd have to walk up and say the full sentence every time: "Give me the Monday candy" or "Put gym into the Monday slot." That's the GetPlan() / SetPlan() method version.
// So the indexers are the buttons. They make it so you just point (or say a word) instead of saying the whole sentence. Same machine, same candy, just a cleaner way to grab it.
public class WeekSchedule
{
    private readonly Dictionary<DayOfWeek, string?> _plans = new();

    //this is an indexer that uses the DayOfWeek type as key
    
    public string? this[DayOfWeek day]
    {
        get => _plans.ContainsKey(day) ? _plans[day] : null;
        set => _plans[day] = value;


    }

    // this indexer takes a string like "monday"
    // turns the string into a DayOfWeek
    // then uses the other indexer to get or set the value of the key
    public string? this[string dayString]
    {
        get => this[ParseDay(dayString)];
        set => this[ParseDay(dayString)] = value;


    }

    private DayOfWeek ParseDay(string input)
    {
        if (!Enum.TryParse<DayOfWeek>(input, ignoreCase: true, out var result))
        {
            throw new ArgumentException($" {input} is not a valid day name.");
        }

        return result;
    }
}