namespace Algoritmos.Searching;

/// <summary>
/// Breadth-First Search (BFS) is another graph traversal algorithm that
/// explores all the vertices at the current depth before moving on to
/// the vertices at the next depth. It starts from a source node and explores
/// its neighbors before moving on to the next level of neighbors. BFS is often used to
/// find the shortest path in an unweighted graph.
/// Steps
/// 1: Visit Node: Start at an initial node and mark it as visited.
/// 2: Explore Neighbors: Visit all unvisited neighbors of the current node.
/// 3: Move to Next Level: Move to the next level of neighbors and repeat step 2.
/// 4: Repeat: Continue until all nodes are visited.
/// </summary>
public class BreadthFirstSearch
{
    private readonly int _numberOfVertices;
    private List<int>[] _adjacents;
    private List<int> _result;

    /// <summary>
    /// This output represents the order in which the nodes are visited
    /// during the BFS traversal, exploring nodes at the same level before
    /// moving to the next level. 
    /// </summary>
    public List<int> Result => _result;

    public BreadthFirstSearch(int numberOfVertices)
    {
        _numberOfVertices = numberOfVertices;
        _adjacents = new List<int>[numberOfVertices];
        for (int i = 0; i < numberOfVertices; i++)
        {
            _adjacents[i] = new List<int>();
        }

        _result = new List<int>();
    }
    
    public void AddEdge(int verticeA, int verticeB)
    {
        _adjacents[verticeA].Add(verticeB);
    }

    public void BFS(int startNode)
    {
        bool[] visited = new bool[_numberOfVertices];
        Queue<int> queue = new Queue<int>();

        // Step 1: Start at an initial node and mark it as visited.
        queue.Enqueue(startNode);
        visited[startNode] = true;

        while (queue.Count != 0)
        {
            startNode = queue.Dequeue(); // Step 3: get the next level
            _result.Add(startNode);

            foreach (var neighbor in _adjacents[startNode])
            {
                // Step 2: Visit all unvisited neighbors of the current node
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    
                    // Step: enqueue this neighbor to be visited after all this level neighbor is visited
                    queue.Enqueue(neighbor);
                }
            }
        }
    }
}