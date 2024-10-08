namespace Algoritmos.Searching;

/// <summary>
/// Binary search is an efficient algorithm for finding a specific value
/// in a sorted collection (e.g., an array). It works by repeatedly dividing
/// the search interval in half until the target value is found or
/// the interval becomes empty.
/// </summary>
public static class BinarySearch
{
    /// <summary>
    /// Steps:
    /// 1- Initialize: Set the start and end pointers to the beginning and end of the array.
    /// 2- Midpoint: Calculate the midpoint of the current interval.
    /// 3- Compare: Compare the value at the midpoint with the target value.
    /// 3.1- If they are equal, the search is successful, and the index of the midpoint is returned.
    /// 3.2- If the target value is less than the value at the midpoint, update the end pointer to be one less than the midpoint.
    /// 3.3- If the target value is greater than the value at the midpoint, update the start pointer to be one more than the midpoint.
    /// </summary>
    /// <param name="inputs">Array of SORTED inputs.</param>
    /// <param name="target">The value we want to find.</param>
    /// <returns>Index where the target is found in the array.</returns>
    public static int Find(int[] inputs, int target)
    {
        // Step 1: Set the start and end pointers
        int start = 0;
        int end = inputs.Length - 1;

        while (start <= end)
        {
            // Step 2: Calculate the midpoint of the current interval
            int mid = (start + end) / 2;
            
            // 3.1: Check if target is present at mid
            if (inputs[mid] == target)
            {
                return mid;
            }
                
            // 3.2: If target is greater, ignore the left half
            if (inputs[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                // 3.3: If target is smaller, ignore the right half
                end = mid - 1;
            }
        }
        
        return 0;
    }
}