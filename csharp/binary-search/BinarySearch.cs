using System;
using System.Linq;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int low = 0, high = input.Length - 1, mid;

        while (low <= high)
        {
            mid = (low + high) / 2;

            if (value < input[mid])
                high = mid - 1;

            else if (value > input[mid])
                low = mid + 1;
            else
                return mid;
        }

        return -1;
    }
}