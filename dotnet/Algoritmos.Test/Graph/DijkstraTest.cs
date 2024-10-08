using Algoritmos.Graph;

namespace Algoritmos.Test.Graph;

public class DijkstraTest
{
    [Fact]
    public void Find_shortest_path()
    {
        var dijkstra = new Dijkstra(6);

        dijkstra.AddEdge(0, 1, 4);
        dijkstra.AddEdge(0, 2, 2);
        dijkstra.AddEdge(1, 2, 5);
        dijkstra.AddEdge(1, 3, 10);
        dijkstra.AddEdge(2, 3, 3);
        dijkstra.AddEdge(2, 4, 7);
        dijkstra.AddEdge(3, 4, 1);
        dijkstra.AddEdge(4, 5, 8);
        
        int sourceVertex = 0;
        List<Vertex> result = dijkstra.CalculateShortestPath(sourceVertex);
        
        // Shortest distances from source vertex 0 is
        // Vertex 0: 0
        // Vertex 1: 4
        // Vertex 2: 2
        // Vertex 3: 5
        // Vertex 4: 6
        // Vertex 5: 14
        
        Assert.Equal("0", result[0].Destination);
        Assert.Equal(0, result[0].Distance);
        
        Assert.Equal("1", result[1].Destination);
        Assert.Equal(4, result[1].Distance);
        
        Assert.Equal("2", result[2].Destination);
        Assert.Equal(2, result[2].Distance);
        
        Assert.Equal("3", result[3].Destination);
        Assert.Equal(5, result[3].Distance);
        
        Assert.Equal("4", result[4].Destination);
        Assert.Equal(6, result[4].Distance);
        
        Assert.Equal("5", result[5].Destination);
        Assert.Equal(14, result[5].Distance);
    }
}