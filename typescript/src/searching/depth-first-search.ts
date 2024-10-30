export function algorithmForDfsRecursive(graph: Map<number, number[]>): Set<number> {
    const visited: Set<number> = new Set();

    // Step 1. Start from a source node, index 0
    dfsRecursive(graph, 0, visited);

    return visited;
}

export function algorithmForDfsIterative(graph: Map<number, number[]>, startNode: number): number[] {
    const visited = new Set<number>();
    const stack = [startNode];
    const result: number[] = [];

    while (stack.length > 0) {
        const node = stack.pop()!;

        if (!visited.has(node)) {
            visited.add(node);
            result.push(node);

            // Push all unvisited neighbors onto the stack
            for (const neighbor of graph.get(node) || []) {
                if (!visited.has(neighbor)) {
                    stack.push(neighbor);
                }
            }
        }
    }

    return result;
}

function dfsRecursive(graph: Map<number, number[]>, node: number, visited: Set<number>): void {
    // Step 2. Visit the current node and mark it as visited
    visited.add(node);

    // Recursively visit each neighbor if it hasn't been visited
    for (const neighbor of graph.get(node) || []) {
        if (!visited.has(neighbor)) {
            dfsRecursive(graph, neighbor, visited);
        }
    }
}