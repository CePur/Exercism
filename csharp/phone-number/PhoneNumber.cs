using System;
using System.Collections.Generic;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var numbers = new List<int>();

        numbers = Cleaner(phoneNumber);

        if (isValid(numbers))
            return string.Join("", numbers);
        else
            throw new ArgumentException("Invalid area code");
    }

    private static List<int> Cleaner(string phoneNumber)
    {
        var numbers = new List<int>();

        foreach (var ch in phoneNumber)
        {
            if (int.TryParse(ch.ToString(), out int result))
                numbers.Add(result);
        }

        var count = numbers.Count;

        if (count == 11)
        {
            if (numbers[0] == 1)
                numbers.RemoveAt(0);
            else
                throw new ArgumentException("Invalid country code.");
        }
        else if (count != 10)
        {
            throw new ArgumentException("Not a phone number");
        }

        return numbers;
    }


    private static bool isValid(List<int> numbers)
    {
        return (numbers[0] > 1 && numbers[3] > 1);
    }

}