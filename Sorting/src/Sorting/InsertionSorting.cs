using System;
using System.Collections.Generic;
using Sorting.Extension;

namespace Sorting
{
    public class InsertionSorting : ISorting
    {
        public void Sort<T>(IList<T> collection) where T : IComparable
        {
            for (int i = 1; i < collection.Count; i++)
            {
                for (int j = i; j > 0 && collection[j - 1].CompareTo(collection[j]) > 0; j--)
                {
                    collection.Swap(j, j - 1);
                }
            }
        }
    }
}
