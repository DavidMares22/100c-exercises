using Xunit;

namespace _100Exercises.Tests;

public class CalculateCostTests
{
    public static TheoryData<decimal, bool, decimal> ShippingCases => new()
    {
        { 30m, false, 10m },
        { 30m, true, 5m },
        { 50m, false, 5m },
        { 60m, false, 5m },
        { 60m, true, 0m }
    };

    [Theory]
    [MemberData(nameof(ShippingCases))]
    public void ShouldCalculateShippingCost_WhenUsingIfElse(decimal orderTotal, bool isPremiumCustomer, decimal expected)
    {
        Assert.Equal(expected, CalculateCost.CalculateShippingCost(orderTotal, isPremiumCustomer));
    }

    [Theory]
    [MemberData(nameof(ShippingCases))]
    public void ShouldCalculateShippingCost_WhenUsingSwitch(decimal orderTotal, bool isPremiumCustomer, decimal expected)
    {
        Assert.Equal(expected, CalculateCost.CalculateShippingCost2(orderTotal, isPremiumCustomer));
    }
}
