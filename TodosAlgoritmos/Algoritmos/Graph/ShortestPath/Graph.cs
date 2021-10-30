using System.Collections.Generic;

namespace Algoritmos.Graph.ShortestPath
{
    public class Graph
    {
        private List<Edge> edges;

        public Graph()
        {
            this.edges = new List<Edge>();
        }

        public void AddEdge(Node from, Node to, int distance)
        {
            this.edges.Add(new Edge(from, to, distance));
        }
    }
}
