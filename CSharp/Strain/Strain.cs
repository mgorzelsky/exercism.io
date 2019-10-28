using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> collectionKeep = new List<T>();
        foreach (var item in collection)
        {
            if (predicate(item))
                collectionKeep.Add(item);
        }
        return collectionKeep;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> collectionDiscard = new List<T>();
        foreach (var item in collection)
        {
            if (!predicate(item))
                collectionDiscard.Add(item);
        }
        return collectionDiscard;
    }
}