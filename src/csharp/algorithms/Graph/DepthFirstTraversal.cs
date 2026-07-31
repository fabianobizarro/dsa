using DataStructures.Core.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

// todo: work

namespace Algorithms.Core.Graph
{
    public static class DepthFirstTraversal
    {
        public static IEnumerable<int> Iterate(GraphNode node)
        {
            var stack = new Stack<GraphNode>();
            var visited = new HashSet<GraphNode>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (!visited.Contains(current))
                {
                    visited.Add(current);
                    yield return current.Value;
                }

                foreach (var adjacent in current.Adjacents)
                {
                    if (!visited.Contains(adjacent))
                    {
                        stack.Push(adjacent);
                    }
                }
            }
        }

        public static IEnumerable<int> RecursiveIterate(GraphNode node) => RecursiveIterate(node, null);

        private static IEnumerable<int> RecursiveIterate(GraphNode node, HashSet<GraphNode> visited)
        {
            visited = visited ?? new HashSet<GraphNode>();

            if (!visited.Contains(node))
            {
                visited.Add(node);
                yield return node.Value;
            }

            foreach (var adjacent in node.Adjacents)
            {
                if (!visited.Contains(adjacent))
                {
                    RecursiveIterate(adjacent, visited);
                }
            }
        }
    }
}
