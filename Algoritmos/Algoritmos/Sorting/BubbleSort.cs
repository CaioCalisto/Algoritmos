namespace Algoritmos.Sorting;

/// <summary>
/// Bubble Sort is a simple sorting algorithm that repeatedly steps through the
/// list, compares adjacent elements, and swaps them if they are in the wrong order.
/// The pass through the list is repeated until the list is sorted. This algorithm
/// gets its name because smaller elements "bubble" to the top of the list.
/// </summary>
public class BubbleSort
{
    /// <summary>
    /// 1: Start from the beginning of the list.
    /// 2: Compare each pair of adjacent elements.
    /// 3: If the elements are in the wrong order, swap them.
    /// 4: Continue comparing and swapping until the end of the list.
    /// 5: Repeat the process from the beginning until no more swaps are needed.
    /// </summary>
    /// <param name="inputs">Input.</param>
    /// <returns>Sorted array.</returns>
    public static int[] Sort(int[] inputs)
    {
        int[] result = inputs;
        int inputSize = inputs.Length;
        bool swapped;

        // Step 1: start from the begining
        for (int index = 0; index < inputSize; index++)
        {
            swapped = false;
            
            // Last i elements are already in place, so no need to check them
            for (int j = 0; j < inputSize - 1; j++)
            {
                // If the element found is greater than the next element, swap them
                if (result[j] > result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped, the array is already sorted
            if (!swapped)
                break;
        }

        return result;
    }

}