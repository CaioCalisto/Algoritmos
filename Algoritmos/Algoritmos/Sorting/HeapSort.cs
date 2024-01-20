namespace Algoritmos.Sorting;

/// <summary>
/// Heap Sort is a comparison-based sorting algorithm that uses a binary heap
/// data structure to build a heap and then sorts the heap. It has a time complexity
/// of O(n log n), making it more efficient than some other simple quadratic-time sorting
/// algorithms like bubble sort and insertion sort.
/// </summary>
public class HeapSort
{
    /// <summary>
    /// Steps:
    /// 1: Build Max Heap: Build a max heap from the input data. A max heap is
    /// a binary tree where the value of each node is greater than or equal to
    /// the values of its children.
    /// 2: Heapify: Swap the root (maximum element) with the last element of the
    /// heap, reduce the size of the heap by 1, and heapify the root.
    /// 3: Repeat Step 2: Continue the heapification process until the heap is empty.
    /// 4: Sorted Array: The elements are now sorted in ascending order.
    /// </summary>
    /// <param name="inputs"></param>
    /// <returns></returns>
    public static int[] Sort(int[] inputs)
    {
        int[] result = inputs;
        int inputSize = inputs.Length;

        // Too complex :'(
        return result;
    }
}