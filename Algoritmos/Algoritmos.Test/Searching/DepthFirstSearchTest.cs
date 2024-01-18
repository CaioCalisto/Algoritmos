using Algoritmos.Searching;

namespace Algoritmos.Test.Searching;

public class DepthFirstSearchTest
{
    [Fact]
    public void Find_Value()
    {
        DepthFirstSearch graph = new DepthFirstSearch(6);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);
        
        // action
        graph.DFS(0);
        
        // 0 => 1
        // 1 => 3 from 0 to the last vertex 3
        // 3 => 5 from 3 to the last
        // 0 => 2 start again
        // 2 => 4
        Assert.Equal(0, graph.Output[0]);
        Assert.Equal(1, graph.Output[1]);
        Assert.Equal(3, graph.Output[2]);
        Assert.Equal(5, graph.Output[3]);
        Assert.Equal(2, graph.Output[4]);
        Assert.Equal(4, graph.Output[5]);
    }
}