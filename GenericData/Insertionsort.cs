using System;
using System.Collections.Generic;

namespace Vector
{
    public class InsertionSort : ISorter
    {
        public void Sort<K>(K[] array, int index, int num, IComparer<K> comparer) where K : IComparable<K>
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            if (index < 0 || num < 0)
                throw new ArgumentOutOfRangeException(index < 0 ? nameof(index) : nameof(num),
                    "Index and num must be non-negative.");
            if (index + num > array.Length)
                throw new ArgumentException("The specified index and num do not define a valid range within the array.");

            if (comparer == null)
                comparer = Comparer<K>.Default;

            // Insertion Sort: grow a sorted region left-to-right; insert each new element into its correct position
            for (int i = index + 1; i < index + num; i++)
            {
                K key = array[i];
                int j = i - 1;
                // Shift elements that are greater than key one position to the right
                while (j >= index && comparer.Compare(array[j], key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
