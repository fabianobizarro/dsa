using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class Stack : IEnumerable<int>
    {
        private Node? _top = null;

        public bool IsEmpty => _top == null;

        
        internal Node? Top() => _top;
        
        public void Push(int value)
        {
            var node = new Node(value)
            {
                Next = _top
            };

            _top = node;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Empty Stack");
            }

            var node = _top;
            _top = node!.Next;
            return node.Value;
        }

        public IEnumerator<int> GetEnumerator() => new StackIterator(this);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class StackIterator : IEnumerator<int> 
    {
        private readonly Stack _stack;
        
        private Node? _currentNode;
        private int _currentValue;
        
        public StackIterator(Stack stack)
        {
            _stack = stack;
            _currentNode = _stack.Top();
        }
        
        int IEnumerator<int>.Current => _currentValue;

        object? IEnumerator.Current => _currentValue;
        
        public bool MoveNext()
        {
            if (_currentNode == null) return false;
            
            _currentValue = _currentNode.Value;
            _currentNode = _currentNode.Next;
            return true;
        }

        public void Reset()
        {
            _currentNode = _stack.Top();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}