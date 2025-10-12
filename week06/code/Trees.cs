public static class Trees
{
    /// <summary>
    /// Given a sorted list (sorted_list), create a balanced BST.
    /// </summary>
    public static BinarySearchTree CreateTreeFromSortedList(int[] sortedNumbers)
    {
        var bst = new BinarySearchTree(); // Create an empty BST to start with 
        InsertMiddle(sortedNumbers, 0, sortedNumbers.Length - 1, bst);
        return bst;
    }

    /// <summary>
    /// Recursively insert the middle element to keep the tree balanced.
    /// </summary>
    private static void InsertMiddle(int[] sortedNumbers, int first, int last, BinarySearchTree bst)
    {
        // Problem 5 - use recursion, no sublists
        if (first > last)
        {
            // base case - nothing to insert
            return;
        }

        // find middle index between first and last
        int mid = (first + last) / 2;

        // insert that middle value into the BST
        bst.Insert(sortedNumbers[mid]);

        // now handle the left half
        InsertMiddle(sortedNumbers, first, mid - 1, bst);

        // and then handle the right half
        InsertMiddle(sortedNumbers, mid + 1, last, bst);
    }
}
