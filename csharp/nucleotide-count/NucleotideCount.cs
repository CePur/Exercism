using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var answer = new Dictionary<char, int>()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (var i in sequence)
        {
            if (!answer.ContainsKey(i)) { throw new ArgumentException("Not DNA"); }

            answer[i]++;
        }

        return answer;
    }
}