using System;
using System.Collections.Generic;
using System.Globalization;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var transformed = new Dictionary<string, int>();

        foreach (var item in old)
        {
            foreach (var arrayItem in item.Value)
            {
                transformed.Add(arrayItem.ToLower(new CultureInfo("en-US", false)), item.Key);
            }
        }

        return transformed;
    }
}