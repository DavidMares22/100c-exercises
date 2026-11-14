using System;
using Xunit;

namespace _100Exercises.Tests;

public class WeekScheduleTests
{
    [Fact]
    public void ShouldStoreAndReturnPlan_WhenUsingDayOfWeekIndexer()
    {
        var schedule = new WeekSchedule();

        schedule[DayOfWeek.Monday] = "Gym";

        Assert.Equal("Gym", schedule[DayOfWeek.Monday]);
    }

    [Fact]
    public void ShouldStoreAndReturnPlan_WhenUsingCaseInsensitiveDayName()
    {
        var schedule = new WeekSchedule();

        schedule["Friday"] = "Dinner with friends";
        schedule[DayOfWeek.Monday] = "Gym";

        Assert.Equal("Dinner with friends", schedule[DayOfWeek.Friday]);
        Assert.Equal("Gym", schedule["monday"]);
    }

    [Fact]
    public void ShouldReturnNull_WhenDayHasNoPlan()
    {
        var schedule = new WeekSchedule();

        Assert.Null(schedule["Tuesday"]);
    }

    [Fact]
    public void ShouldThrowArgumentException_WhenDayNameIsInvalid()
    {
        var schedule = new WeekSchedule();

        Assert.Throws<ArgumentException>(() => schedule["Funday"]);
    }
}
