using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        if (collection is null)
            throw new ArgumentNullException(nameof(collection));

        if (func is null)
            throw new ArgumentNullException(nameof(func));

        foreach (T item in collection)
        {
            yield return func(item);
        }
    }
}