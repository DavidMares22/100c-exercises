using System;
using System.Collections.Concurrent;

public class CheckPalindrome
{

    public static bool IsPalindrome3(string input)
    {
        return input.SequenceEqual(input.Reverse());
    }

    public static bool IsPalindrome2(string input)
    {
        var half = input.Length / 2;
        var left = 'a';
        var right = 'z';
        for(int i = 0; i < half ; ++i)
        {
             left = input[i];
             right = input[^(i+1)];
            if (left != right)
            {
             return false;   
            }
        }
            return true;
    }
    public static bool IsPalindrome(string input)
    {
        string original = input;
        string reversed = new String(input.Reverse().ToArray());

        var result = original == reversed? true : false;


        return result;

    }
}