using Algoritmos.Searching;

namespace Algoritmos.Test.Searching;

public class BreadthFirstSearchTest
{
    [Fact]
    public void Find_path()
    {
        BreadthFirstSearch graph = new BreadthFirstSearch(6);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);
        
        graph.BFS(0);
        
        // ORDER OF VISITED NODES: 0 1 2 3 4 5
        //       0
        //    1     2 
        //    3     4     
        //    5

        Assert.Equal(0, graph.Result[0]);
        Assert.Equal(1, graph.Result[1]);
        Assert.Equal(2, graph.Result[2]);
        Assert.Equal(3, graph.Result[3]);
        Assert.Equal(4, graph.Result[4]);
        Assert.Equal(5, graph.Result[5]);
    }
}