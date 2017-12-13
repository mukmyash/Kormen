using System;
using System.Collections.Generic;
using Sorting;
using Sorting.Extension;

namespace Sorting
{
    public class QuickSorting : ISorting
    {
        public void Sort<T>(IList<T> collection)
            where T : IComparable
        {
            quicksort(collection, 0, collection.Count - 1);
        }

        private void quicksort<T>(IList<T> collection, int lo, int hi)
            where T : IComparable
        {
            if (lo < hi)
            {
                var q = partition(collection, lo, hi);
                quicksort(collection, lo, q - 1);
                quicksort(collection, q + 1, hi);
            }
        }

        private int partition<T>(IList<T> collection, int lo, int hi)
            where T : IComparable
        {
            var x = collection[hi];
            int i = lo - 1;
            for (int j = lo; j < hi; j++)
                if (collection[j].CompareTo(x) <= 0)
                {
                    i++;
                    collection.Swap(i, j);
                }
            collection.Swap(i + 1, hi);

            return i + 1;
        }

    }
}