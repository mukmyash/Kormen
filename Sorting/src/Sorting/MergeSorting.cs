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
            mergeSort(collection, 1, collection.Count);
        }

        private void mergeSort<T>(IList<T> collection, int p, int r)
            where T : IComparable
        {
            if (p < r)
            {
                int q = (r + p) / 2;
                mergeSort(collection, p, q);
                mergeSort(collection, q + 1, r);
                merge(collection, p, q, r);
            }
        }

        private void merge<T>(IList<T> collection, int p, int q, int r)
            where T : IComparable
        {

            int lCount = q - p + 1;
            int rCount = r - q;
            T[] leftArray = new T[lCount];
            T[] rightArray = new T[rCount];

            for (int i = 0; i < lCount; i++)
                leftArray[i] = collection[p + i - 1];

            for (int i = 0; i < rCount; i++)
                rightArray[i] = collection[q + i];


            int lI = 0, rI = 0;
            for (int k = p - 1; k < r; k++)
            {
                if ((rI == rCount && lI != lCount) || (lI != lCount && rI != rCount && leftArray[lI].CompareTo(rightArray[rI]) <= 0))
                {
                    collection[k] = leftArray[lI]; lI++;
                }
                else
                {
                    collection[k] = rightArray[rI]; rI++;
                }
            }
        }
    }
}