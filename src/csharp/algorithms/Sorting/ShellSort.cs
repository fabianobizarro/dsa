using System;
using System.Collections.Generic;
using System.Text;
// todo: work
namespace Algorithms.Core.Sorting
{
    public static class ShellSort
    {
        public static void Sort(int[] array)
        {
            int h;
            for (h = 1; h < array.Length / 3; h = 3 * h + 1) ;
            for (; h > 0; h /= 3)
            {
                int j, temp;
                for (int i = h; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    while (j > h && array[j - h] > temp)
                    {
                        array[j] = array[j - h];
                        j -= h;
                    }
                    array[j] = temp;
                }

            }
        }
    }
}
