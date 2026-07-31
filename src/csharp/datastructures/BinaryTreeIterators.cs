using DataStructures.Core.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;
// todo: work
namespace DataStructures.Core.Iterators
{
    public static class BinaryTreeIterators
    {
        public static IEnumerable<int> PreOrder(BinaryTree tree) => new PreOrderIterator(tree);

        public static IEnumerable<int> InOrder(BinaryTree tree) => new InOrderIterator(tree);

        public static IEnumerable<int> PostOrder(BinaryTree tree) => new PostOrderIterator(tree);
    }

    /// <summary>
    /// Pre-Order Iterator
    /// Parent -> Left -> Right
    /// </summary>
    internal sealed class PreOrderIterator : IEnumerable<int>
    {
        private readonly BinaryTree _tree;

        public PreOrderIterator(BinaryTree tree)
        {
            _tree = tree ?? throw new ArgumentNullException(nameof(tree));
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<int> GetEnumerator() => GetEnumerator(_tree.Root);

        private IEnumerator<int> GetEnumerator(BinaryTreeNode node)
        {
            if (node != null)
            {
                yield return node.Value;
                GetEnumerator(node.Left);
                GetEnumerator(node.Right);
            }
        }
    }

    /// <summary>
    /// In-Order Iterator
    /// Left -> Parent -> Right
    /// </summary>
    internal sealed class InOrderIterator : IEnumerable<int>
    {
        private readonly BinaryTree _tree;

        public InOrderIterator(BinaryTree tree)
        {
            _tree = tree;
        }

        public IEnumerator<int> GetEnumerator() => GetEnumerator(_tree.Root);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private IEnumerator<int> GetEnumerator(BinaryTreeNode node)
        {
            if (node != null)
            {
                GetEnumerator(node.Left);
                yield return node.Value;
                GetEnumerator(node.Right);
            }
        }
    }

    /// <summary>
    /// Port-Order Iterator
    /// Left -> Right -> Parent
    /// </summary>
    internal sealed class PostOrderIterator : IEnumerable<int>
    {
        private readonly BinaryTree _tree;

        public PostOrderIterator(BinaryTree tree)
        {
            _tree = tree;
        }

        public IEnumerator<int> GetEnumerator() => GetEnumerator(_tree.Root);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private IEnumerator<int> GetEnumerator(BinaryTreeNode node)
        {
            if (node != null)
            {
                GetEnumerator(node.Left);
                GetEnumerator(node.Right);
                yield return node.Value;
            }
        }
    }
}
