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

        private void quicksort<T>(IList<T> collection, int p, int r)
            where T : IComparable
        {
            if (p < r)
            {
                var q = partition(collection, p, r);
                quicksort(collection, p, q - 1);
                quicksort(collection, q + 1, r);
            }
        }

        private int partition<T>(IList<T> collection, int p, int r)
            where T : IComparable
        {
            var x = collection[r];
            int i = p - 1;
            for (int j = p; j < r; j++)
            {
                if (collection[j].CompareTo(x) <= 0)
                {
                    i++;
                    collection.Swap(i, j);
                }
            }
            collection.Swap(i + 1, r);

            return i + 1;
        }

    }
}