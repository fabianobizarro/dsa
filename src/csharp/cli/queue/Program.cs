using System;
using DataStructures;
using static System.Console;


var random = new Random(Seed: DateTime.Now.Millisecond);
var queue = new Queue();

WriteLine("Adding values to the Queue");
for (var i = 0; i <= 5; i++)
{
    queue.Enqueue(random.Next(maxValue: 100));
    PrintQueue(queue);
}
WriteLine("END");


WriteLine("\nRemoving values from the Queue");
while (!queue.IsEmpty)
{
    var n = queue.Dequeue();
    Write($"Removed {n}: ");
    PrintQueue(queue);
}
WriteLine("END");
return;


void PrintQueue(Queue q)
{
    if (q.IsEmpty) WriteLine("<EMPTY>");
    Write("START -> ");
    foreach (var value in q)
    {
        Write($"{value} -> ");
    }

    Write("END\n");
}