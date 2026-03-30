using System;
using System.Collections.Generic;

namespace Vector
{
    public interface ISorter
    {
        void Sort<K>(K[] array, int index, int num, IComparer<K> comparer) where K : IComparable<K>;
    }
}