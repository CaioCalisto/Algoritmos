namespace Algoritmos.Searching;

/// <summary>
/// Depth-First Search (DFS) is a graph traversal algorithm that explores as
/// far as possible along each branch before backtracking. It's often used to
/// explore and traverse graphs, trees, or other data structures.
/// Steps:
/// 1: Visit Node: Start at an initial node and mark it as visited.
/// 2: Explore Neighbors: Visit an unvisited neighbor of the current node.
/// If all neighbors are visited, backtrack to the previous node.
/// 3: Repeat: Repeat steps 1 and 2 until all nodes are visited.
/// </summary>
public class DepthFirstSearch
{
    private readonly int _numberOfVertices;
    private List<int>[] _adjacencyList;
    // Output the depth-first traversal starting from given vertex.
    private List<int> _output;
    
    public List<int> Output => _output;

    public DepthFirstSearch(int numberOfVertices)
    {
        _numberOfVertices = numberOfVertices;
        _adjacencyList = new List<int>[numberOfVertices];
        for (int i = 0; i < numberOfVertices; i++)
        {
            _adjacencyList[i] = new List<int>();
        }

        _output = new List<int>();
    }
    
    public void AddEdge(int verticeA, int verticeB)
    {
        _adjacencyList[verticeA].Add(verticeB);
    }

    public void DFS(int startNode)
    {
        bool[] visited = new bool[_numberOfVertices];
        DFS(startNode, visited);
    }

    /// <summary>
    /// It recursively explores the neighbors of a node.
    /// </summary>
    /// <param name="node">Current node.</param>
    /// <param name="visited">Visited nodes.</param>
    private void DFS(int node, bool[] visited)
    {
        // Step 1
        visited[node] = true;
        _output.Add(node);
        
        foreach (int neighbor in _adjacencyList[node])
        {
            // Step 2: Visit an unvisited neighbor of the current node
            if (!visited[neighbor])
            {
                // Step 3: Repeat
                DFS(neighbor, visited);
            }
        }
    }
}