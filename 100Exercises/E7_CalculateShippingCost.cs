namespace _100Exercises;

public class CalculateCost
{
    public static decimal CalculateShippingCost2(decimal orderTotal, bool isPremiumCustomer)
    {
        return orderTotal switch
        {
            < 50 when !isPremiumCustomer => 10,
            < 50 when isPremiumCustomer => 5,
            >= 50 when !isPremiumCustomer => 5,
            >= 50 when isPremiumCustomer => 0,
        };
    }
    public static decimal CalculateShippingCost(
        decimal orderTotal,
        bool isPremiumCustomer)
    {
        if(orderTotal >= 50)
        {       
            if(!isPremiumCustomer)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            if (!isPremiumCustomer)
            {
                return 10;
            }
        }
        return 5;
    }
}