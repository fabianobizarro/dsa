using DataStructures.Core.Nodes;
using System.Collections.Generic;

// todo: work

namespace Algorithms.Core.Graph
{
    public static class BreadthFirstTraversal
    {
        public static IEnumerable<int> Iterate(GraphNode node)
        {
            var queue = new Queue<GraphNode>();
            var seen = new HashSet<GraphNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (!seen.Contains(current))
                {
                    seen.Add(current);
                    yield return current.Value;
                }

                foreach (var adjacent in current.Adjacents)
                {
                    if (!seen.Contains(adjacent))
                        queue.Enqueue(adjacent);
                }
            }
        }
    }
}
