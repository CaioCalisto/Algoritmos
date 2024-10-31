import {algorithmForBFS, Graph} from "./breadth-first-search";

test('BreadthFirstSearch', () => {
    const graph: Graph = {
        A: ['B', 'C'],
        B: ['A', 'D', 'E'],
        C: ['A', 'F'],
        D: ['B'],
        E: ['B', 'F'],
        F: ['C', 'E']
    };

    const visited = algorithmForBFS(graph, "A");

    expect(visited).toStrictEqual(["A", "B", "C", "D", "E", "F"]);
})