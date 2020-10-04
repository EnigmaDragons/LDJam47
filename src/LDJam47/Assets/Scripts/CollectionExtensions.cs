using System;
using System.Collections.Generic;

public static class CollectionExtensions
{
    public static T VerboseIndex<T>(this List<T> items, int index, string collectionName)
    {
        if (index > items.Count - 1)
            throw new ArgumentException(
                $"{collectionName} only contains {items.Count} items, but {index} item was requested.");
        return items[index];
    }
    
    public static T VerboseIndex<T>(this T[] items, int index, string collectionName)
    {
        if (index > items.Length - 1)
            throw new ArgumentException(
                $"{collectionName} only contains {items.Length} items, but {index} item was requested.");
        return items[index];
    }
}
