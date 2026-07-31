using System;
// todo: work
namespace Algorithms.Core.Sorting
{
    public static class HeapSort
    {
        public static void Sort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            BuildMaxHeap(array);
            int right = array.Length - 1;
            while (right > 0)
            {
                Swap(array, 0, right);
                right--;
                Heapify(array, 0, right);
            }
        }

        private static void Swap(int[] array, int from, int to)
        {
            (array[from], array[to]) = (array[to], array[from]);
        }

        public static void BuildMaxHeap(int[] array)
        {
            int left = array.Length / 2 - 1;
            while (left >= 0)
            {
                Heapify(array, left, array.Length - 1);
                left--;
            }
        }

        public static void Heapify(int[] array, int left, int right)
        {
            int i = left;
            int leftChild = 2 * i + 1;
            int temp = array[i];

            while (leftChild <= right)
            {
                if (leftChild < right && array[leftChild] < array[leftChild + 1])
                {
                    leftChild++;
                }
                if (temp >= array[leftChild])
                    break;
                array[i] = array[leftChild];
                i = leftChild;
                leftChild = 2 * i + 1;
            }
            array[i] = temp;
        }
    }
}
