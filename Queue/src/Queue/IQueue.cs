using System;

namespace Queue
{
    interface IQueue<T>
             where T : IComparable
    {
        T GetValue();
        T ExtractValue();
        void InsertValue(T value);
    }
}