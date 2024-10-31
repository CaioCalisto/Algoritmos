/*
    It uses a queue to explore all nodes at the current level before moving to nodes at the next level.
*/

type Graph = { [node: string]: string[] }

export function algorithmForBFS(graph: Graph, startNode: string): string[] {
    const visited = new Set<string>();
    const queue: string[] = [startNode];
    const result: string[] = [];

    while (queue.length > 0) {
        const currentNode = queue.shift()!;

        // If the node has already been visited, skip it
        if (visited.has(currentNode)) continue;

        // Mark the node as visited and add it to the result
        visited.add(currentNode);
        result.push(currentNode);

        // Add all unvisited neighbors to the queue
        for (const neighbor of graph[currentNode]) {
            if (!visited.has(neighbor)) {
                queue.push(neighbor);
            }
        }
    }

    return result;
}

export type { Graph }

/*
Pros of BFS

    Shortest Path:
    BFS can find the shortest path between two nodes in an unweighted graph, as it
    explores nodes level by level.

    Simple and Versatile:
    BFS is easy to implement and is effective for both trees and graph traversal,
    especially when searching for specific nodes or paths.

    Complete Algorithm:
    If a solution exists (e.g., in search problems), BFS is guaranteed to find
    it (in finite graphs).

Cons of BFS

    Memory Intensive:
    BFS requires storing all nodes at the current level in the queue. For a wide or
    deep graph, this can consume significant memory, making BFS less efficient than
    Depth-First Search (DFS) for large graphs.

    Time Complexity:
    In the worst case, BFS has a time complexity of O(V+E)O(V+E), where VV is the number
    of vertices and EE is the number of edges. This can become slow for dense or large graphs.

    Not Suitable for Weighted Graphs:
    BFS doesn’t account for edge weights. Dijkstra’s algorithm is preferable for weighted
    graphs to find the shortest path.
*/