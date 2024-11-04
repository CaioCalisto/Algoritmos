export function algorithmForMergeSort(input: number[]): number[] {
    // Base case: if the array is empty or has a single element, it’s already sorted
    if (input.length <= 1) {
        return input;
    }

    // Find the middle index of the array
    const middle = Math.floor(input.length / 2);

    // Recursively split and sort the left half
    const left = algorithmForMergeSort(input.slice(0, middle));

    // Recursively split and sort the right half
    const right = algorithmForMergeSort(input.slice(middle));

    // Merge the sorted halves
    return merge(left, right);
}

function merge(left: number[], right: number[]): number[] {
    const sortedArray: number[] = [];

    // While there are elements in both left and right arrays, pick the smallest one
    while (left.length && right.length) {
        if (left[0] < right[0]) {
            sortedArray.push(left.shift()!); // Remove the first element from left and push it to sortedArray
        } else {
            sortedArray.push(right.shift()!); // Remove the first element from right and push it to sortedArray
        }
    }

    // Concatenate remaining elements (if any) to the sorted array
    return sortedArray.concat(left, right);
}

/*
Complexity:

    Time Complexity: O(nlog⁡n)O(nlogn) — The array is split log(n) times, and merging takes O(n).
    Space Complexity: O(n)O(n) — Additional space is required to store the split subarrays during merging.

Example

Given an input array [38, 27, 43, 3, 9, 82, 10], the merge sort process would look like this:

    Split into [38, 27, 43] and [3, 9, 82, 10]
    Split further until arrays have only one element: [38], [27], [43], [3], [9], [82], [10]
    Merge back together in sorted order:
        [27, 38, 43] and [3, 9, 10, 82]
        Finally merged to [3, 9, 10, 27, 38, 43, 82]

This method efficiently sorts the array by merging smaller sorted arrays into larger ones until
the entire array is sorted.
*/