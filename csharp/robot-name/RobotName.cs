using System;
using System.Collections.Generic;

public class Robot
{

    private string _name = NameGenerator();
    private static HashSet<string> nameList = new HashSet<string>();
    public string Name { get => _name; }

    public void Reset()
    {
        nameList.Remove(Name);
        _name = NameGenerator();
    }

    private static string NameGenerator()
    {
        var stringChars = new char[5];
        var random = new Random();

        for (int i = 0; i < 2; i++)
        {
            stringChars[i] = (char)random.Next(65, 90);
        }
        for (int i = 2; i < 5; i++)
        {
            stringChars[i] = char.Parse(random.Next(10).ToString());
        }

        var finalString = new String(stringChars);

        if (!nameList.Add(finalString))
            return NameGenerator();

        return finalString;
    }
}