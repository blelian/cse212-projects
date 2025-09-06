public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of size 'length' to store the multiples
        double[] multiples = new double[length];

        // Step 2: Use a loop to fill in the array
        // Each element should be the starting number times (index + 1)
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1); // multiply number by position to get the multiple
        }

        // Step 3: Return the completed array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' list to the right by 'amount'.
    /// Example: data = {1,2,3,4,5,6,7,8,9}, amount = 3 → {7,8,9,1,2,3,4,5,6}
    /// The function modifies the original list in place.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Take the last 'amount' elements from the list
        List<int> endSlice = data.GetRange(data.Count - amount, amount);

        // Step 2: Remove these elements from the end of the original list
        data.RemoveRange(data.Count - amount, amount);

        // Step 3: Insert the saved slice at the beginning of the list
        data.InsertRange(0, endSlice);

        // Step 4: The list is now rotated by 'amount'
    }
}
