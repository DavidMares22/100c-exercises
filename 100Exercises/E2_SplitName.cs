using System;

namespace _100Exercises;

public class SplitName
{
    public static (string firstName, string lastName) SplitFullName(string fullName)
    {
        string[] nameArray = fullName.Split(" ");
        // System.Console.WriteLine(nameArray[0]);

        return (firstName: nameArray[0], lastName: nameArray[1]);
    }

} 

