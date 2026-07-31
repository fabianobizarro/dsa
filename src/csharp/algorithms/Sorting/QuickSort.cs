using System;
using System.Collections.Generic;
using System.Text;
// todo: work
namespace Algorithms.Core.Sorting
{
    public static class QuickSort
    {
        public static void Sort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            Sort(array);
        }

        private static void Sort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            var pivotIndex = right;
            var pivot = array[pivotIndex];
            var index = left;

            for (int i = left; i <= right; i++)
            {
                if (array[i] < pivot)
                {
                    Swap(array, i, index);
                    index++;
                }
            }
            Swap(array, index, pivotIndex);
            Sort(array, left, index - 1);
            Sort(array, index + 1, right);
        }

        private static void Swap(int[] array, int from, int to)
        {
            var temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }
    }
}
