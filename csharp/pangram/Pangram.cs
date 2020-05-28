using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        input = input.ToLowerInvariant();

        foreach (var letter in alphabet)
	    {
           if(!input.Contains(letter))
           {
               return false;               
           }

	    }

        return true;

    }
}
