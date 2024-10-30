export function algorithmForBinarySearch(sortedInput: number[], target: number): number {
    // Step 1: Start with the entire array.
    // Define two pointers: left (first index) and right (last index)
    let left = 0;
    let right = sortedInput.length - 1;

    while (left <= right) {
        // Step 2: Find the middle index
        const middle = Math.floor((left + right) / 2);

        // Step 3: Check if the middle element is equal to the target.
        // If it is, return the index of the middle element.
        if (sortedInput[middle] === target) {
            return middle;
        }

        // If it’s less than the target, discard the left half by moving left to middle + 1.
        if (sortedInput[middle] < target) {
            left = middle + 1;
        } else {
            // If it’s greater than the target, discard the right half by moving right to middle - 1.
            right = middle - 1;
        }
    }

    // Target not found
    return -1;
}
/*
Complexity
    Time Complexity: O(log⁡n)O(logn), as the array is divided in half with each step.
    Space Complexity: O(1)O(1), as it only uses a constant amount of extra space.

Pros

    Efficiency:
    Binary search is much faster than a linear search for large datasets.
    Its time complexity is O(log⁡n)O(logn), so it scales well as the size of the array grows.

    Low Memory Usage:
    The iterative version of binary search only uses a constant amount of extra space (O(1)O(1)),
    making it memory efficient.

    Simple to Implement:
    Despite its efficiency, binary search is relatively simple to implement once the logic
    is understood.

    Predictable Performance:
    Since binary search always divides the search range in half, its performance is predictable
    and stable.

    Widely Applicable in Sorted Data:
    Binary search is highly useful in applications involving sorted data, such as finding
    elements in databases, searching in dictionaries, or looking up values in maps.

Cons

    Requires Sorted Data:
    Binary search only works on sorted arrays. If the data isn’t already sorted, you’ll
    need to sort it first, which could increase complexity, especially for large datasets.

    Not Optimal for Small Data:
    For small datasets, linear search can sometimes be more efficient since binary search
    requires additional overhead to calculate the middle index and compare values.

    Inflexible for Dynamic Data:
    Binary search is less efficient for dynamically changing data. Every time the array is
    modified (insertion or deletion), it needs to be re-sorted, which can be costly.

    Reduced Performance with Linked Lists:
    Binary search is not well-suited for linked lists because accessing the middle element
    in a linked list requires traversing the list, which makes the performance O(n)O(n).

    Recursive Implementation Risk:
    In some languages, a recursive implementation of binary search can lead to stack overflow
    for very large arrays due to deep recursion levels. This is avoided with an iterative
    approach but is a consideration in recursive cases.

When to Use Binary Search

    Best used on large, sorted arrays where search speed is critical.
    Avoid if the data isn’t sorted, if you frequently modify the data, or if you’re working
    with data structures that don’t support fast indexing (e.g., linked lists).
 */