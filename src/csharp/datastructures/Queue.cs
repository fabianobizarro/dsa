using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class Queue : IEnumerable<int>
    {
        private Node? _head = null;

        private Node? _tail = null;

        public bool IsEmpty => _head == _tail && _head == null;

        internal int Peek()
        {
            return _head?.Value ?? throw new Exception("Queue is empty");
        }

        internal Node? Head() => _head;

        public void Enqueue(int value)
        {
            var node = new Node(value);
            if (_head == null)
            {
                _head = node;
                _tail = _head;
            }
            else
            {
                _tail!.Next = new Node(value);
                _tail = _tail.Next;
            }

            _tail.Next = null;
        }

        public int Dequeue()
        {
            if (IsEmpty)
                return -1;

            var value = _head!.Value;
            _head = _head.Next;
            if (_head == null)
            {
                _tail = null;
            }

            return value;
        }

        /**
         * Enumerator functions
         */
        public IEnumerator<int> GetEnumerator() => new QueueIterator(this);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class QueueIterator : IEnumerator<int>
    {
        private readonly Queue _queue;

        private Node? _current;
        private int _value;

        public QueueIterator(Queue queue)
        {
            _queue = queue;
            _current = _queue.Head();
        }

        public int Current => _value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _current = null;
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (_current == null) return false;


            _value = _current.Value;
            _current = _current.Next;
            return true;
        }

        public void Reset()
        {
            _current = _queue.Head();
        }
    }
}