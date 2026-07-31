using System.Collections.Generic;
// todo: work
namespace DataStructures.Core.Nodes
{
    public class GraphNode
    {
        public GraphNode(int value)
        {
            Value = value;
            Adjacents = new LinkedList<GraphNode>();
        }

        public int Value { get; }

        public LinkedList<GraphNode> Adjacents { get; private set; }

        public override string ToString() => Value.ToString();
    }
}
