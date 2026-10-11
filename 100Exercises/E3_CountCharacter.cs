using System;
using System.Net;


namespace _100Exercises;

public class CountCharacter
{
    public static Dictionary<char, int> CountCharacterFrequency(string input)
    {
        var result = new Dictionary<char, int>();
        foreach(char letter in input)
        {
            if (result.ContainsKey(letter))
            {
                result[letter]++;
            }
            else
            {
                result[letter] = 1;
            }
        }
            return result;
            
    }
}