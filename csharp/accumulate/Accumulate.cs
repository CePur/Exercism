using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        if (collection == null || func == null) throw new ArgumentNullException();

        foreach (var element in collection)
        {
            yield return func(element);
        }
    }
}