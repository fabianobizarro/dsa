Console.WriteLine("Hello, World!");

// todo: work
public static class GraphExecution
{
    public static void Execute()
    {
        var root = BuildGraph();

        Console.WriteLine("Depth First Search");
        var path = DepthFirstTraversal.Iterate(root);
        foreach (var item in path)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Console.WriteLine("Depth First Search Recursive");
        path = DepthFirstTraversal.RecursiveIterate(root);
        foreach (var item in path)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Console.WriteLine("Breadth First Search");
        path = BreadthFirstTraversal.Iterate(root);
        foreach (var item in path)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("thats all folks");
    }

    public static GraphNode BuildGraph()
    {
        var root = new GraphNode(0);

        var n1 = new GraphNode(1);
        var n2 = new GraphNode(2);
        var n3 = new GraphNode(3);
        var n4 = new GraphNode(4);
        var n5 = new GraphNode(5);
        var n6 = new GraphNode(6);
        var n7 = new GraphNode(7);
        var n8 = new GraphNode(8);

        root.Adjacents.AddLast(n1);
        root.Adjacents.AddLast(n2);

        n1.Adjacents.AddLast(n3);

        n2.Adjacents.AddLast(n4);
        n2.Adjacents.AddLast(n5);

        n3.Adjacents.AddLast(n6);

        n4.Adjacents.AddLast(n7);

        n5.Adjacents.AddLast(n7);

        n6.Adjacents.AddLast(n8);

        n7.Adjacents.AddLast(n8);

        return root;
    }
}
