using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var str = new StringBuilder();
        char temp;

        foreach (var ch in text)
        {
            var ascii = (int)ch;

            if (64 < ascii && ascii < 91)
                temp = Convert.ToChar(((ascii - 65) + shiftKey) % 26 + 65);

            else if (96 < ascii && ascii < 123)
                temp = Convert.ToChar(((ascii - 97) + shiftKey) % 26 + 97);

            else
                temp = ch;

            str.Append(temp);
        }

        return str.ToString();
    }
}