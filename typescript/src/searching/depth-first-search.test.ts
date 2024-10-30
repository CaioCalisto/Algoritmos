import {algorithmForDfsIterative, algorithmForDfsRecursive} from "./depth-first-search";

test('Recursively Search', () => {
    const graph = new Map<number, number[]>([
        [0, [1, 2]],
        [1, [0, 3, 4]],
        [2, [0, 5]],
        [3, [1]],
        [4, [1, 5]],
        [5, [2, 4]]
    ]);

    const visited = algorithmForDfsRecursive(graph);

    expect(visited).toContain(0);
    expect(visited).toContain(1);
    expect(visited).toContain(2);
    expect(visited).toContain(3);
    expect(visited).toContain(4);
    expect(visited).toContain(5);
})

test('Iterative Search', () => {
    const graph = new Map<number, number[]>([
        [0, [1, 2]],
        [1, [0, 3, 4]],
        [2, [0, 5]],
        [3, [1]],
        [4, [1, 5]],
        [5, [2, 4]]
    ]);

    const visited = algorithmForDfsIterative(graph, 5);

    expect(visited).toEqual([5, 4, 1, 3, 0, 2]);
})