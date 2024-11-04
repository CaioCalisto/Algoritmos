import {algorithmForQuickSort} from "./quick-sort";

test('Heap Sort Test', () => {
    const numbers = [4, 10, 3, 5, 1];
    const result = algorithmForQuickSort(numbers);

    expect(result).toStrictEqual([1, 3, 4, 5, 10]);
})