// todo: work here
public class LinkedList
{
    public Node Head { get; private set; }

    public LinkedList()
    {
        Head = null;
    }

    /// <summary>
    /// Add at the end of the list
    /// </summary>
    /// <param name="value">Value to be added</param>
    public void Append(int value)
    {
        if (Head == null)
        {
            Head = new Node(value);
            return;
        }

        var current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = new Node(value);
    }

    /// <summary>
    /// Add at the beginning of the list
    /// </summary>
    /// <param name="value">Value to be added</param>
    public void Prepend(int value)
    {
        var newHead = new Node(value);
        newHead.Next = Head;
        Head = newHead;
    }

    public Node Find(int data)
    {
        var current = Head;
        while (current.Next != null)
        {
            if (current.Value == data)
            {
                return current;
            }
        }

        if (current.Value == data)
        {
            return current;
        }

        return null;
    }

    public void Delete(int value)
    {
        if (Head == null)
            return;

        if (Head.Value == value)
        {
            Head = Head.Next;
        }

        var current = Head;
        while (current.Next != null)
        {
            if (current.Next.Value == value)
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }
}
