import {algorithmForInsertionSort} from "./insertion-sort";

test('insertionSort', () => {
    const numbers = [5, 2, 9, 1, 5, 6];
    const result = algorithmForInsertionSort(numbers);

    expect(result).toStrictEqual([1, 2, 5, 5, 6, 9]);
})