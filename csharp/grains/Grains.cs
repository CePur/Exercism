using System;

public static class Grains
{
    private const int totalSquares = 64;
    public static ulong Square(int n) => (n < 1 || n > 64) ? throw new ArgumentOutOfRangeException() : (ulong)Math.Pow(2, n - 1);

    public static ulong Total()
    {
        ulong total = 0;

        for (int i = 1; i <= totalSquares; i++)
        {
            total += Square(i);
        }

        return total;
    }
}