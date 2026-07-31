using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

// todo: work
namespace DataStructures.Core
{
    public class MinHeap
    {
        private int capacity;
        private int size = 0;

        private int[] items;

        public IEnumerable<int> Items => new ReadOnlyCollection<int>(items);

        public MinHeap()
            : this(10)
        {

        }

        public MinHeap(int capacity)
        {
            this.capacity = capacity;
            items = new int[10];
        }

        private int LeftChildIndex(int parentIndex) => (2 * parentIndex) + 1;
        private int RightChildIndex(int parentIndex) => (2 * parentIndex) + 2;
        private int ParentIndex(int childIndex) => (childIndex - 1) / 2;

        private bool HasLeftChild(int index) => LeftChildIndex(index) < size;
        private bool HasRightChild(int index) => RightChildIndex(index) < size;
        private bool HasParent(int index) => ParentIndex(index) >= 0;

        private int LeftChild(int index) => items[LeftChildIndex(index)];
        private int RightChild(int index) => items[RightChildIndex(index)];
        private int Parent(int index) => items[ParentIndex(index)];

        private void EnsureCapacity()
        {
            if (size == capacity)
            {
                Array.Copy(items, 0, items, 0, capacity * 2);
                capacity *= 2;
            }
        }

        private void Swap(int sourceIndex, int targetIndex)
        {
            int temp = items[sourceIndex];
            items[sourceIndex] = items[targetIndex];
            items[targetIndex] = temp;
        }

        public int Peek()
        {
            if (size == 0) throw new InvalidOperationException();

            return items[0];
        }

        public void Insert(int value)
        {
            EnsureCapacity();
            items[size] = value;
            size++;
            HeapifyUp();
        }

        public int Delete()
        {
            if (size == 0)
                throw new InvalidOperationException();

            var item = items[0];
            items[0] = items[size - 1];
            size--;
            HeapifyDown();
            return item;
        }

        private void HeapifyDown()
        {
            var index = 0;
            while (HasLeftChild(index))
            {
                var smallerChildIndex = LeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                    smallerChildIndex = RightChildIndex(index);

                if (items[index] < items[smallerChildIndex])
                    break;
                else
                    Swap(index, smallerChildIndex);

                index = smallerChildIndex;

            }
        }

        private void HeapifyUp()
        {
            var index = size - 1;
            while (HasParent(index) && Parent(index) > items[index])
            {
                Swap(ParentIndex(index), index);
                index = ParentIndex(index);
            }
        }
    }
}
