// todo: work
public class DoublyLinkedList
{
    public DoubleNode Head { get; private set; }

    public DoublyLinkedList()
    {
        Head = null;
    }

    public void Append(int value)
    {
        if (Head == null)
        {
            Head = new DoubleNode(value);
            return;
        }

        var current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        var newNode = new DoubleNode(value);
        current.Next = newNode;
        newNode.Prev = current;

    }

    public void Prepend(int value)
    {
        var newHead = new DoubleNode(value)
        {
            Next = Head
        };
        Head = newHead;
    }

    public DoubleNode Find(int value)
    {
        var current = Head;
        while (current.Next != null)
        {
            if (current.Value == value)
            {
                return current;
            }
            current = current.Next;
        }

        if (current.Value == value)
        {
            return current;
        }

        return null;
    }

    public void Delete(DoubleNode node)
    {
        if (node == null)
            return;

        if (node == Head)
        {
            Head = Head.Next;
            Head.Prev = null;
            return;
        }

        node.Prev.Next = node.Next;

        if (node.Next != null)
            node.Next.Prev = node.Prev;
    }

    public void Delete(int value)
    {
        var node = Find(value);

        if (node != null)
            Delete(node);
    }
}
