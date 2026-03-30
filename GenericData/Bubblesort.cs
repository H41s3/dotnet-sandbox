using System;
using System.Collections.Generic;

namespace Vector
{
    public class BubbleSort : ISorter
    {
        public void Sort<K>(K[] array, int index, int num, IComparer<K> comparer) where K : IComparable<K>
        {
            // Validate inputs
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            if (index < 0 || num < 0)
                throw new ArgumentOutOfRangeException(index < 0 ? nameof(index) : nameof(num),
                    "Index and num must be non-negative.");
            if (index + num > array.Length)
                throw new ArgumentException("The specified index and num do not define a valid range within the array.");

            // Fall back to default comparer if none provided
            if (comparer == null)
                comparer = Comparer<K>.Default;

            // Optimized Bubble Sort: early exit when no swaps occur (achieves O(n) best case)
            bool swapped;
            for (int i = 0; i < num - 1; i++)
            {
                swapped = false;
                for (int j = index; j < index + num - 1 - i; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                        swapped = true;
                    }
                }
                // Already sorted — no point continuing
                if (!swapped) break;
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
