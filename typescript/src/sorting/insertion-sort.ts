export function algorithmForInsertionSort(input: number[]): number[] {
    for (let index = 0; index < input.length; index++) {
        let current = input[index];
        let j = index - 1;

        // Shift elements of the input portion that are greater than the current element
        while (j >= 0 && input[j] > current) {
            input[j + 1] = input[j];
            j--;
        }

        // Place the current element in its correct position
        input[j + 1] = current;
    }

    return input;
}