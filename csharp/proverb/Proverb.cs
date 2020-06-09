using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var str = new List<string>();

        if (subjects.Length > 1)
        {
            for (int i = 0; i < subjects.Length - 1; i++)
            {
                str.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
            }
        }

        if (subjects.Length != 0)
        {
            str.Add($"And all for the want of a {subjects[0]}.");
        }

        return str.ToArray();
    }
}