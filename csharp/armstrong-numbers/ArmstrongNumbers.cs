using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = number.ToString().Select(q => int.Parse(new string(q, 1))).ToArray();
        int length = digits.Length;

        double total = 0;
        if (number > 0)
        {
            foreach (var digit in digits)
            {
                total += Math.Pow(digit, length);
            }
        }
        System.Console.WriteLine(total);
        return total == number ? true : false;
    }
}