using System;
using System.Collections.Generic;

public static class Extensions
    {
        public static int FindIndex<T>(this IList<T> source, Predicate<T> match)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (match(source[i]) == true)
                {
                    return i;
                }
            }
            return -1;
        }
    }