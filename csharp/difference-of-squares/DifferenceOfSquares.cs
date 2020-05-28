using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int total = 0;
        for (int i = max; i > 0; i--)
        {
            total += i;
        }

        return (int)Math.Pow(total, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int total = 0;

        for (int i = max; i > 0; i--)
        {
            total += (int)Math.Pow(i, 2);
        }

        return total;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}