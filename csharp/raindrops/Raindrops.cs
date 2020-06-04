using System;
using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var str = new StringBuilder();


        if (number % 3 == 0) str.Append("Pling");

        if (number % 5 == 0) str.Append("Plang");

        if (number % 7 == 0) str.Append("Plong");


        return str.Length == 0 ? number.ToString() : str.ToString();
    }
}