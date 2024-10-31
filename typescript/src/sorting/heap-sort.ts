/*
Heap Sort involves building a max heap from the input array and then repeatedly
removing the largest element from the heap, placing it at the end of the array
until the entire array is sorted.
*/
export function algorithmForHeapSort(input: number[]): number[] {
    let n = input.length;

    // Build a max heap from the array
    for (let i = Math.floor(n / 2) - 1; i >= 0; i--) {
        heapify(input, n, i);
    }

    // Extract elements from the heap one by one
    for (let i = n - 1; i > 0; i--) {
        // Move current root (largest element) to the end
        [input[0], input[i]] = [input[i], input[0]];

        // Heapify the reduced heap
        heapify(input, i, 0);
    }

    return input;
}

// Helper function to maintain the max heap property
function heapify(arr: number[], n: number, i: number): void {
    let largest = i;        // Initialize largest as root
    const left = 2 * i + 1; // Left child index
    const right = 2 * i + 2; // Right child index

    // If left child is larger than root
    if (left < n && arr[left] > arr[largest]) {
        largest = left;
    }

    // If right child is larger than largest so far
    if (right < n && arr[right] > arr[largest]) {
        largest = right;
    }

    // If largest is not the root, swap and heapify the affected subtree
    if (largest !== i) {
        [arr[i], arr[largest]] = [arr[largest], arr[i]];
        heapify(arr, n, largest);
    }
}

/*
Pros of Heap Sort

    Time Efficiency:
        Heap Sort has a guaranteed time complexity of O(nlog⁡n)O(nlogn), making it a good choice
        for large datasets.

    In-place Sorting:
        It requires only a constant amount of additional memory (O(1)O(1)), making it space-efficient.

    Not Sensitive to Input Order:
        The performance of Heap Sort is independent of the initial order of elements, so it’s as
        efficient for unsorted data as for partially sorted data.

Cons of Heap Sort

    Not Stable:
        Heap Sort is not a stable sorting algorithm, meaning it does not preserve the relative order
        of equal elements.

    Cache Inefficiency:
        Due to its non-sequential access pattern, Heap Sort can be slower in practice than other
        algorithms, like Quick Sort, on modern CPUs.

    Comparatively Slower than Quick Sort in Average Case:
        While Heap Sort has better worst-case performance (O(nlog⁡n)O(nlogn)), Quick Sort typically
        performs faster on average due to better cache locality.
*/