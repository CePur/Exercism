using System;
using System.Globalization;
using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int total = 0;

        foreach (var ch in input.ToUpper(new CultureInfo("en-US", false)))
        {
            switch (ch)
            {
                case var s when new[] { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' }.Contains(s):
                    total += 1;
                    break;
                case var s when new[] { 'D', 'G' }.Contains(s):
                    total += 2;
                    break;
                case var s when new[] { 'B', 'C', 'M', 'P' }.Contains(s):
                    total += 3;
                    break;
                case var s when new[] { 'F', 'H', 'V', 'W', 'Y' }.Contains(s):
                    total += 4;
                    break;
                case var s when new[] { 'K' }.Contains(s):
                    total += 5;
                    break;
                case var s when new[] { 'J', 'X' }.Contains(s):
                    total += 8;
                    break;
                case var s when new[] { 'Q', 'Z' }.Contains(s):
                    total += 10;
                    break;
            }
        }

        return total;
    }
}