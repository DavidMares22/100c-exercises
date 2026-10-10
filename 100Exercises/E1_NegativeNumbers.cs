//Check if a collection contains any negative numbers

// Implement the ContainsNegative method that checks whether a sequence of integers contains at least one negative number.


using System;
namespace _100Exercises;

public class NegativeNumbers
{   
    public static bool ContainsNegative(IEnumerable<int> numbers)
    {
        return numbers.Any(n => n < 0);

    }
}