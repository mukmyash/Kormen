using System;
using System.Collections.Generic;
using Sorting.Extension;

namespace Sorting
{
    public class HeapSorting : ISorting
    {
        public void Sort<T>(IList<T> collection) where T : IComparable
        {
            BuildMaxHeap(collection);

            for (int i = collection.Count - 1; i > 0; i--)
            {
                collection.Swap(i, 0);
                MaxHeapify(collection, 0, i);
            }
        }

        private void BuildMaxHeap<T>(IList<T> collection) where T : IComparable
        {
            for (int i = collection.Count / 2 - 1; i >= 0; i--)
                MaxHeapify(collection, i, collection.Count);
        }

        private void MaxHeapify<T>(IList<T> collection, int i, int heapSize) where T : IComparable
        {
            var leftIndex = 2 * i + 1;
            var rightIndex = 2 * i + 2;
            int largesIndex = 0;
            if (leftIndex < heapSize && collection[leftIndex].CompareTo(collection[i]) > 0)
                largesIndex = leftIndex;
            else
                largesIndex = i;

            if (rightIndex < heapSize && collection[rightIndex].CompareTo(collection[largesIndex]) > 0)
                largesIndex = rightIndex;

            if (largesIndex != i)
            {
                collection.Swap(largesIndex, i);
                MaxHeapify(collection, largesIndex, heapSize);
            }
        }
    }
}
