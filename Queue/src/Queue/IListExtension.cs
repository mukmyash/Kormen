using System.Collections.Generic;

namespace Queue
{
    internal static class IListExtension
    {
        public static void Swap<T>(this IList<T> collection, int i1, int i2)
        {
            var tmp = collection[i1];
            collection[i1] = collection[i2];
            collection[i2] = tmp;
        }

    }
}