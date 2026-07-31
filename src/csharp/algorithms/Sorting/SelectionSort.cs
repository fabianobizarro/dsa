using System;
using System.Collections.Generic;
using System.Text;
// todo: work
namespace Algorithms.Core.Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int smaller;
            for (int i = 0; i < array.Length - 1; i++)
            {
                smaller = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smaller])
                    {
                        smaller = j;
                    }
                }
                Swap(array, i, smaller);
            }
        }

        private static void Swap(int[] array, int from, int to)
        {
            (array[from], array[to]) = (array[to], array[from]);
        }
    }
}
