import {algorithmForLinearSearch} from "./linear-search";

test.each([
    [3, 3, [0,1,2,3,4,5,20, 33, 42, 55]],
    [4, 4, [0,1,2,3,4,5,20, 33, 42, 55]],
    [20, 6, [0,1,2,3,4,5,20, 33, 42, 55]],
    [55, 10, [0,1,2,3,4,5,20, 33, 42, 46, 55]],
    [45, -1, [0,1,2,3,4,5,20, 33, 42, 55]],
])('Linear search for %p', (target: number, expectedIndex: number, input: number[]) => {
    const foundIndex = algorithmForLinearSearch(input, target);

    expect(foundIndex).toBe(expectedIndex);
})