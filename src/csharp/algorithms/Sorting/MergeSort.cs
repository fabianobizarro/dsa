using System;
using System.Collections.Generic;
using System.Text;
// todo: work
namespace Algorithms.Core.Sorting
{
    public class MergeSort
    {
        private int[] temp;
        private int[] array;

        public void Sort(int[] array)
        {
            this.array = array;
            temp = new int[array.Length];
            Sort(0, array.Length - 1);
        }

        private void Sort(int left, int right)
        {
            if (left == right)
                return;

            int middle = (left + right) / 2;

            Sort(left, middle);
            Sort(middle + 1, right);
            MergeCompact(left, middle, right);
        }

        private void Merge(int left, int middle, int right)
        {
            int i = left, j = middle + 1, tempPos = left;

            while (i <= middle && j <= right)
            {
                if (array[i] <= array[j])
                {
                    temp[tempPos] = array[i];
                    i++;
                }
                else
                {
                    temp[tempPos] = array[j];
                    j++;
                }
                tempPos++;
            }

            while (i <= middle)
            {
                temp[tempPos] = array[i];
                tempPos++;
                i++;
            }

            while (j <= right)
            {
                temp[tempPos] = array[j];
                tempPos++;
                j++;
            }

            for (tempPos = left; tempPos <= right; tempPos++)
            {
                array[tempPos] = temp[tempPos];
            }
        }

        private void MergeCompact(int left, int middle, int right)
        {
            int i = left, j = middle + 1, tempPos = left;

            while (i <= middle && j <= right)
            {
                if (array[i] <= array[j])
                    temp[tempPos++] = array[i++];
                else
                    temp[tempPos++] = array[j++];
            }

            while (i <= middle)
            {
                temp[tempPos++] = array[i++];
            }

            while (j <= right)
            {
                temp[tempPos++] = array[j++];
            }

            for (tempPos = left; tempPos <= right; tempPos++)
            {
                array[tempPos] = temp[tempPos];
            }
        }
    }
}
