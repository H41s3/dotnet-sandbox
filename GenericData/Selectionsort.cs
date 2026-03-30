using System;
using System.Collections.Generic;

namespace Vector
{
    public class SelectionSort : ISorter
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

            // Selection Sort: on each pass, find the minimum in the unsorted portion and swap it into place
            for (int i = index; i < index + num - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < index + num; j++)
                {
                    if (comparer.Compare(array[j], array[minIndex]) < 0)
                        minIndex = j;
                }
                if (minIndex != i)
                    Swap(array, i, minIndex);
            }
        }

        private void Swap<K>(K[] array, int i, int j)
        {
            K temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
