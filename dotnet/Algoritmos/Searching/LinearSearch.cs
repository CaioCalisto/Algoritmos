namespace Algoritmos.Searching;

/// <summary>
/// It is a simple search algorithm that finds the position of a target
/// value within a collection (e.g., an array) by checking each element
/// in sequence until a match is found or the entire collection has been searched.
/// Linear search has a time complexity of O(n), where n is the number of
/// elements in the array. This means that the time it takes to complete the search
/// is proportional to the size of the array.
/// </summary>
public class LinearSearch
{
    public static int Find(int[] inputs, int target)
    {
        for (int i = 0; i < inputs.Length; i++)
        {
            // If target is found, return the index
            if (inputs[i] == target)
                return i;
        }

        // Target not present in the array
        return -1;
    }
}