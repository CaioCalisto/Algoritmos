import {algorithmForBinarySearch} from "./binary-search";

test.each([
    [3, [0, 1, 2, 3, 4, 5, 6, 20, 22, 34, 40], 3],
    [40, [0, 1, 2, 3, 4, 5, 6, 20, 22, 34, 40], 10],
    [34, [0, 1, 2, 3, 4, 5, 6, 20, 22, 34, 40], 9],
    [20, [0, 1, 2, 3, 4, 5, 6, 20, 22, 34, 40], 7],
    [15, [0, 1, 2, 3, 4, 5, 6, 20, 22, 34, 40], -1]
,])("Searching binary searching - %p", (target: number, input: number[], expectedIndex: number) => {
    const foundIndex = algorithmForBinarySearch(input, target);

    expect(foundIndex).toEqual(expectedIndex);
})