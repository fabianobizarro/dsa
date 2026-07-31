namespace DataStructures
{
    public class Node(int value)
    {
        public readonly int Value = value;

        public Node? Next = null;
    }


    // todo: work
    public class DoubleNode
    {
        public readonly int Value;

        public DoubleNode Next = null;
        public DoubleNode Prev = null;

        public DoubleNode(int value)
        {
            Value = value;
        }
    }

    public class BinaryTreeNode
    {
        public readonly int Value;

        public BinaryTreeNode Left, Right;

        public BinaryTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public void Insert(int value)
        {
            if (value <= Value)
            {
                if (Left == null)
                    Left = new BinaryTreeNode(value);
                else
                    Left.Insert(value);
            }
            else
            {
                if (Right == null)
                    Right = new BinaryTreeNode(value);
                else
                    Right.Insert(value);
            }
        }

        public BinaryTreeNode Search(int searchValue)
        {
            if (Value == searchValue)
                return this;

            if (searchValue < Value)
            {
                return Left == null
                    ? null :
                    Left.Search(searchValue);
            }
            else
            {
                return Right == null
                    ? null :
                    Right.Search(searchValue);
            }
        }
    }

}
