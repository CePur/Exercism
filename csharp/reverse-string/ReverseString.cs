using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if(!string.IsNullOrWhiteSpace(input))
            return new string(input.Reverse().ToArray());

        return input;
    }
}