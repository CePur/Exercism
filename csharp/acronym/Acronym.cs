using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var chars = new char[] { ' ', '-', '_' };

        var words = phrase.Split(chars);

        string abb = "";

        foreach (var i in words)
        {
            if (!string.IsNullOrWhiteSpace(i))
                abb += i[0];
        }

        return abb.ToUpper();
    }
}