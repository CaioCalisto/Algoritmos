import {algorithmForMergeSort} from "./merge-sort";

test('mergeSort', () => {
    const numbers = [4, 10, 3, 5, 1];
    const result = algorithmForMergeSort(numbers);

    expect(result).toStrictEqual([1, 3, 4, 5, 10]);
})