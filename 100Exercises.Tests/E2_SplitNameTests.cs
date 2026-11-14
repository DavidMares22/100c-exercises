using Xunit;

namespace _100Exercises.Tests;

public class SplitNameTests
{
    [Fact]
    public void ShouldSplitFirstAndLastName_WhenFullNameGiven()
    {
        var result = SplitName.SplitFullName("David Mares");

        Assert.Equal("David", result.firstName);
        Assert.Equal("Mares", result.lastName);
    }
}
