using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2)
            throw new ArgumentOutOfRangeException();

        var primes = new List<int>();
        var notPrimes = new HashSet<int>();


        for (int i = 2; i <= limit; i++)
        {
            if (!notPrimes.Contains(i))
            {
                primes.Add(i);

                int x = 2;
                int y = 2;

                while (x < limit)
                {
                    x = i * (y);
                    notPrimes.Add(x);
                    y++;
                }
            }
        }

        return primes.ToArray();
    }

}
