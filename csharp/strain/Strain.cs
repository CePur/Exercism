using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        if (collection == null || predicate == null) throw new ArgumentNullException();

        foreach (var element in collection)
        {
            if (predicate(element)) yield return element;
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.Keep(element => !predicate(element));
    }
}