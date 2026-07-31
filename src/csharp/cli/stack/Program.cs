using DataStructures;
using static System.Console;

var random = new Random(Seed: DateTime.Now.Millisecond);
var stack = new Stack();

WriteLine("Adding values to the Stack");
for (var i = 0; i <= 5; i++)
{
    stack.Push(random.Next(maxValue: 100));
    PrintStack(stack);
}
WriteLine("END");


WriteLine("\nRemoving values from the Stack");
while (!stack.IsEmpty)
{
    var n = stack.Pop();
    Write($"Removed {n}: ");
    PrintStack(stack);
}
WriteLine("END");
return;


void PrintStack(Stack s)
{
    if (s.IsEmpty) WriteLine("<EMPTY>");
    Write("START -> ");
    foreach (var value in s)
    {
        Write($"{value} -> ");
    }

    Write("END\n");
}