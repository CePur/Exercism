using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLowerInvariant();
        List<char> letters = new List<char> {};

        foreach (var l in word)
        {
            if(l==' ' || l == '-')
            {continue;}
            if(letters.Contains(l))
            {
                return false;
            }
            else
            {
                letters.Add(l);
            }
        }

        return true;
    }
}
