namespace Algoritmos.Sorting;

/// <summary>
/// Selection Sort is a simple comparison-based sorting algorithm that divides
/// the input list into two parts: a sorted and an unsorted region. The algorithm
/// repeatedly selects the smallest (or largest, depending on the order) element
/// from the unsorted region and swaps it with the first element of the unsorted region.
/// This process is repeated until the entire list is sorted.
/// </summary>
public class SelectionSort
{
    /// <summary>
    /// Steps.
    /// 1: Initial State: The entire list is considered unsorted.
    /// 2: Selection: Find the minimum (or maximum) element in the unsorted region.
    /// 3: Swap: Swap the found minimum (or maximum) element with the first element of the unsorted region.
    /// 4: Expansion: Expand the sorted region to include the newly sorted element.
    /// 5: Repeat: Repeat steps 2-4 until the entire list is sorted.
    /// </summary>
    /// <param name="inputs">Inputs</param>
    /// <returns>Sorted</returns>
    public static int[] Sort(int[] inputs)
    {
        int[] result = inputs;
        int inputSize = inputs.Length;

        // Step 5: repeat
        for (int index = 0; index < inputSize; index++)
        {
            // Step 2: Find the minimum element in the unsorted array
            int minIndex = index;
            for (int j = index + 1; j < inputSize; j++)
            {
                if (result[j] < result[minIndex])
                    minIndex = j;
            }
            
            // Step 3: Swap the found minimum element with the first element
            int temp = result[minIndex];
            result[minIndex] = result[index];
            result[index] = temp;
        }

        return result;
    }
}