export function algorithmForQuickSort(input: number[]): number[] {
    // Base case: arrays with 0 or 1 element are already sorted
    if (input.length <= 1) {
        return input;
    }

    // Choose the pivot element (here, we choose the last element)
    const pivot = input[input.length - 1];
    const left: number[] = [];
    const right: number[] = [];

    // Partition the array into two halves: elements less than pivot and greater than or equal to pivot
    for (let i = 0; i < input.length - 1; i++) {
        if (input[i] < pivot) {
            left.push(input[i]);
        } else {
            right.push(input[i]);
        }
    }

    // Recursively apply quickSort to the left and right subarrays, then concatenate
    return [...algorithmForQuickSort(left), pivot, ...algorithmForQuickSort(right)];
}

/*
Visual Example

Let's sort the array [38, 27, 43, 3, 9, 82, 10] using Quick Sort:

    Initial Array: [38, 27, 43, 3, 9, 82, 10]
        Pivot: 10
        Left: [38, 27, 3, 9] (elements less than 10)
        Right: [43, 82] (elements greater than or equal to 10)

    Sorting Left Subarray [38, 27, 3, 9]:

        Pivot: 9

        Left: [3]

        Right: [38, 27]

        Sorting [38, 27]:
            Pivot: 27
            Left: []
            Right: [38]
            Combined: [27, 38]

        Combined Left Subarray: [3, 9, 27, 38]

    Sorting Right Subarray [43, 82]:
        Pivot: 82
        Left: [43]
        Right: []
        Combined Right Subarray: [43, 82]

    Final Merged Array:
        Combine sorted left subarray [3, 9, 27, 38], pivot 10, and sorted right subarray [43, 82]
        Sorted Array: [3, 9, 10, 27, 38, 43, 82]

--------------------------------------------------------------------------------
  Time and Space Complexity

    Time Complexity:
        Average Case: O(nlog⁡n)O(nlogn) — Efficient for large datasets.
        Worst Case: O(n2)O(n2) — Occurs when the smallest or largest element is always
                    chosen as the pivot (e.g., already sorted array with certain pivot choices).
        Best Case: O(nlog⁡n)O(nlogn)

    Space Complexity:
        O(log n) on average due to the recursion stack. However, the above implementation uses
        additional space for the left and right arrays, leading to O(n)O(n) space complexity.
*/