// todo: work
namespace DataStructures.Core.Nodes
{
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
