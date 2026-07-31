using System;
// todo: work
namespace Algorithms.Core.Sorting
{
    public static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            var length = array.Length;
            for (int i = length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        private static void Swap(int[] array, int from, int to)
        {
            var temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }
    }
}
