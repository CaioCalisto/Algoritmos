namespace Algoritmos.Sorting;

/// <summary>
/// It is a simple sorting algorithm that builds the final sorted array one item at a time.
/// It is much less efficient on large lists than more advanced algorithms such as quicksort,
/// heapsort, or merge sort. However, insertion sort has the advantage of being easy to
/// understand and implement. It's a good choice for small datasets or nearly sorted datasets.
/// </summary>
public class InsertionSort
{
    /// <summary>
    /// Steps:
    /// 1: Start from the second element
    /// 2: Compare the current element with its predecessor.
    /// 3: If the current element is smaller than its predecessor, compare it with the elements before.
    /// 3.1: Move the greater elements one position up to make space for the current element.
    /// 4: Repeat steps 2-3 until the correct position for the current element is found.
    /// 5: Move to the next element and repeat steps 2-4 until the entire array is sorted.  
    /// </summary>
    /// <param name="inputs">Array that will be sorted.</param>
    /// <returns>Sorted result.</returns>
    public static int[] Sort(int[] inputs)
    {
        int[] result = inputs;
        int arraySize = inputs.Length;

        // Step 1: Start from the second element
        for (int index = 1; index < arraySize; index++)
        {
            int currentElement = result[index];
            int predecessorIndex = index - 1;

            // Step 2: Compare the current element with its predecessor.
            while (predecessorIndex >= 0 && result[predecessorIndex] > currentElement)
            {
                // Step 3: Move elements of arr[0..i-1] that are greater than current element
                // to one position ahead of their current position
                result[predecessorIndex + 1] = result[predecessorIndex];
                predecessorIndex -= 1;
            }
            
            // Assign current element to predecessor + 1
            result[predecessorIndex + 1] = currentElement;
        }
        
        return result;
    }
}