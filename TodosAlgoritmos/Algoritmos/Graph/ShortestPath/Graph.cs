using System.Collections.Generic;
using System.Linq;

namespace Algoritmos.Graph.ShortestPath
{
    public class Graph
    {
        private List<Edge> edges;
        private List<Node> nodes;

        public IEnumerable<Node> Nodes => this.nodes;

        public Graph()
        {
            this.edges = new List<Edge>();
            this.nodes = new List<Node>();
        }

        public void AddEdge(Node from, Node to, int distance)
        {
            if (!this.nodes.Contains(from))
                this.nodes.Add(from);

            if (!this.nodes.Contains(to))
                this.nodes.Add(to);

            this.edges.Add(new Edge(from, to, distance));
        }

        public List<Edge> GetEdges(Node from) => this.edges.Where(e => e.From == from).ToList();
    }
}
