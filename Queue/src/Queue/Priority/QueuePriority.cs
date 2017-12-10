using System;
using System.Collections.Generic;

using Queue;
using Queue.Priority.Sorting;

namespace Queue.Priority
{
    public class QueuePriority<T> : IQueue<T>
             where T : IComparable
    {
        List<T> Collection { get; set; }
        HeapSorting SortingStrategy { get; set; }
        public QueuePriority()
        {
            SortingStrategy = new HeapSorting();
            Collection = new List<T>();
        }
        public QueuePriority(IList<T> collection)
        {
            SortingStrategy = new HeapSorting();
            SortingStrategy.BuildMaxHeap(collection);
            Collection = new List<T>(collection);
        }

        public T GetValue()
        {
            return Maximum(Collection);
        }

        public T ExtractValue()
        {
            return ExtractMax(Collection);
        }

        public void InsertValue(T value)
        {
            InsertValue(Collection, value);
        }


        private T Maximum(IList<T> collection)
        {
            return collection[0];
        }

        private T ExtractMax(IList<T> collection)
        {
            if (Collection.Count < 1)
            {
                throw new IndexOutOfRangeException("Коллекция пуста");
            }
            T max = collection[0];
            collection[0] = collection[Collection.Count - 1];
            Collection.RemoveAt(Collection.Count - 1);
            SortingStrategy.MaxHeapify(collection, 0, Collection.Count);
            return max;
        }

        private void InsertValue(IList<T> collection, T value)
        {
            collection.Add(default(T));
            IncreaseKey(collection, Collection.Count - 1, value);
        }


        private void IncreaseKey(IList<T> collection, int i, T key)
        {
            if (key.CompareTo(collection[i]) < 0)
            {
                throw new ArgumentException("Новый ключ менше текущего", "key");
            }
            collection[i] = key;
            int parent_i = Convert.ToInt32(
                Math.Ceiling((double)i / 2)) - 1;
            while (i > 0 && parent_i >= 0 && collection[parent_i].CompareTo(collection[i]) > 0)
            {
                collection.Swap(parent_i, i);
                i = parent_i;
                parent_i = Convert.ToInt32(
                    Math.Ceiling((double)i / 2)) - 1;
            }
        }
    }
}