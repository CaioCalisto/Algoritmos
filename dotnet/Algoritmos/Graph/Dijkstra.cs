namespace Algoritmos.Graph;

/// <summary>
/// Dijkstra's algorithm is a widely used algorithm for finding the shortest
/// path between nodes in a graph, particularly for graphs with non-negative
/// edge weights. It is an algorithm that works for both directed and undirected graphs.
/// The algorithm maintains a set of vertices whose shortest distance from the source is known.
/// </summary>
public class Dijkstra
{
    private readonly int _numberOfVertices;
    private List<(int, int)>[] _adjacencyList;
    
    public Dijkstra(int numberOfVertices)
    {
        _numberOfVertices = numberOfVertices;
        _adjacencyList = new List<(int, int)>[_numberOfVertices];
        for (int i = 0; i < _numberOfVertices; ++i)
        {
            _adjacencyList[i] = new List<(int, int)>();
        }
    }

    public void AddEdge(int source, int destination, int weight)
    {
        _adjacencyList[source].Add((destination, weight));
        _adjacencyList[destination].Add((source, weight)); // For undirected graph
    }

    /// <summary>
    /// Steps:
    /// 1: Set the initial distance values for all vertices to infinity
    /// and the distance to the source vertex to 0. Create an empty priority queue or min-heap.
    /// 2: For each vertex, consider all of its neighbors and calculate their
    /// tentative distances through the current vertex. If the newly calculated
    /// tentative distance is less than the current assigned value, update the distance.
    /// 3: Remove the vertex with the smallest tentative distance from the priority queue.
    /// This vertex is now considered "visited."
    /// 4: Repeat Steps 2-3: Repeat the relaxation and visitation steps until all vertices are visited.
    /// </summary>
    /// <param name="source">Source.</param>
    /// <returns>All result.</returns>
    public List<Vertex> CalculateShortestPath(int source)
    {
        var result = new List<Vertex>();
        
        int[] distance = new int[_numberOfVertices];
        bool[] visited = new bool[_numberOfVertices];
        
        // Step 1
        for (int i = 0; i < _numberOfVertices; ++i)
        {
            distance[i] = int.MaxValue;
            visited[i] = false;
        }
        
        distance[source] = 0;
        
        Queue<int> priorityQueue = new Queue<int>();
        priorityQueue.Enqueue(source);

        while (priorityQueue.Count > 0)
        {
            int currentVertex = priorityQueue.Dequeue();
            if (visited[currentVertex])
                continue;
            
            visited[currentVertex] = true;
            
            // Step 2
            foreach ((int neighbor, int weight) in _adjacencyList[currentVertex])
            {
                int altDistance = distance[currentVertex] + weight;
                
                // Step 3
                if (altDistance < distance[neighbor])
                {
                    distance[neighbor] = altDistance;
                    priorityQueue.Enqueue(neighbor);
                }
            }
        }
        
        for (int i = 0; i < _numberOfVertices; i++)
        {
            result.Add(new Vertex()
            {
                Source = source.ToString(),
                Destination = i.ToString(),
                Distance = distance[i]
            });    
        }
        
        return result;
    }
}

public class Vertex 
{
    public string Source { get; set; }
    public string Destination { get; set; }
    public int Distance { get; set; }
}