using System;
using System.Collections.Generic;
using System.Text;
// todo: work
namespace Algorithms.Core.Sorting
{
    public static class InsertionSort
    {
        public static void Sort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int j, temp;
            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                temp = array[i];
                while (j > 0 && array[j - 1] > temp)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = temp;
            }
        }
    }
}
