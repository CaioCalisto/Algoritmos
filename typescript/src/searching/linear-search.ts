export function algorithmForLinearSearch(input: number[], target: number): number {
    // Step 1. Start at the beginning of the array.
    for (let i = 0; i < input.length; i++) {

        // Step. Check if it matches the target
        if (input[i] === target) {
            return i;
        }
    }

    return -1;
}

/*
Pros:
    Works with unsorted data.
    Simple to implement and understand.

Cons:
    Slow for large arrays as it has a time complexity of O(n)O(n).
    Inefficient compared to binary search when searching in a sorted array.
*/