using System;
using System.Collections.Generic;
using Sorting;

namespace Sorting
{
    public class MergeSorting : ISorting
    {
        public void Sort<T>(IList<T> collection)
            where T : IComparable
        {
            mergeSort(collection, 0, collection.Count - 1);
        }

        private void mergeSort<T>(IList<T> collection, int lo, int hi)
            where T : IComparable
        {
            if (lo < hi)
            {
                int q = (hi + lo) / 2;
                mergeSort(collection, lo, q);
                mergeSort(collection, q + 1, hi);
                merge(collection, lo, q, hi);
            }
        }

        private void merge<T>(IList<T> collection, int lo, int mid, int hi)
            where T : IComparable
        {

            int lCount = mid - lo + 1;
            int rCount = hi - mid;
            T[] leftArray = new T[lCount];
            T[] rightArray = new T[rCount];

            for (int i = 0; i < lCount; i++)
                leftArray[i] = collection[lo + i];

            for (int i = 0; i < rCount; i++)
                rightArray[i] = collection[mid + i + 1];


            int lI = 0, rI = 0;
            for (int k = lo; k <= hi; k++)
                if (rI >= rCount)
                { collection[k] = leftArray[lI]; lI++; }
                else if (lI >= lCount)
                { collection[k] = rightArray[rI]; rI++; }
                else if (leftArray[lI].CompareTo(rightArray[rI]) <= 0)
                { collection[k] = leftArray[lI]; lI++; }
                else
                { collection[k] = rightArray[rI]; rI++; }
        }
    }
}