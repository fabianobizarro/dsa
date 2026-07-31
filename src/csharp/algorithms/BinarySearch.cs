using System;
using System.Collections.Generic;
using System.Text;
// todo: work
namespace Algorithms.Core
{
    public static class BinarySearch
    {
        public static bool Search(int[] array, int element)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            var start = 0;
            var end = array.Length;
            int middle;

            while (start <= end)
            {
                middle = (start + end) / 2;

                if (array[middle] == element)
                {
                    return true;
                }

                if (array[middle] < element)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            return false;
        }

        public static bool RecursiveSearch(int[] array, int element)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            return RecursiveSearch(array, element, 0, array.Length);
        }

        private static bool RecursiveSearch(int[] array, int target, int start, int end)
        {
            if (start > end)
            {
                return false;
            }

            var middle = (start + end) / 2;

            if (array[middle] == target)
            {
                return true;
            }

            if (array[middle] < target)
            {
                return RecursiveSearch(array, target, middle + 1, end);
            }
            else
            {
                return RecursiveSearch(array, target, start, middle - 1);
            }
        }
    }
}
