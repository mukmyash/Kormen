using System;
using System.Collections.Generic;
using Sorting;

namespace Sorting
{
    public class MergeSortingOptimized : ISorting
    {
        public void Sort<T>(IList<T> collection)
            where T : IComparable
        {
            mergeSort(collection, 0, collection.Count - 1);
        }

        private void mergeSort<T>(IList<T> collection, int lo, int hi)
            where T : IComparable
        {
            if (hi <= lo) return;

            int mid = lo + (hi - lo) / 2;
            mergeSort(collection, lo, mid);
            mergeSort(collection, mid + 1, hi);
            merge(collection, lo, mid, hi);
        }

        private void merge<T>(IList<T> collection, int lo, int mid, int hi)
            where T : IComparable
        {

            T[] buf = new T[hi - lo];
            for (int k = lo; k <= hi; k++)
                buf[k] = collection[k];

            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
                if (i > mid)
                { collection[k] = buf[j]; j++; }
                else if (j > hi)
                { collection[k] = buf[i]; i++; }
                else if (buf[j].CompareTo(buf[i]) < 0)
                { collection[k] = buf[j]; j++; }
                else
                { collection[k] = buf[i]; i++; }
        }
    }
}