using System;
using System.Collections.Generic;

namespace Sorting
{
    public interface ISorting
    {
        void Sort<T>(IList<T> collection) where T : IComparable;
    }
}