public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Problem 1 - Insert unique values only

        // if the new value is already in the tree, do nothing
        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left side
            if (Left is null)
            {
                Left = new Node(value);
            }
            else
            {
                // keep looking on the left
                Left.Insert(value);
            }
        }
        else
        {
            // Insert to the right side
            if (Right is null)
            {
                Right = new Node(value);
            }
            else
            {
                // keep looking on the right
                Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        // Problem 2 - check if a value exists in the tree

        if (value == Data)
        {
            // found the value
            return true;
        }
        else if (value < Data && Left != null)
        {
            // keep checking the left subtree
            return Left.Contains(value);
        }
        else if (value > Data && Right != null)
        {
            // keep checking the right subtree
            return Right.Contains(value);
        }
        else
        {
            // reached a leaf without finding it
            return false;
        }
    }

    public int GetHeight()
    {
        // Problem 4 - find height of the tree (root = 1)

        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // height = 1 + the tallest child
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
