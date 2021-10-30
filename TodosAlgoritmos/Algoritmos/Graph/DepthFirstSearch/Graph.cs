using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritmos.Graph.DepthFirstSearch
{
    public class Graph
    {
        private List<Node> nodes;
        private List<Edge> edges;

        public IEnumerable<Edge> Edges => this.edges;

        public void AddEdge(Node nodeA, Node nodeB, int weight)
        {
            if (this.edges == null)
                this.edges = new List<Edge>();

            if (this.nodes == null)
                this.nodes = new List<Node>();

            if (this.edges.Exists(e => e.NodeA == nodeA && e.NodeB == nodeB && e.Weight == e.Weight))
                throw new Exception();

            if (!this.nodes.Contains(nodeA))
                this.nodes.Add(nodeA);

            if (!this.nodes.Contains(nodeB))
                this.nodes.Add(nodeB);

            this.edges.Add(new Edge() { NodeA = nodeA, NodeB = nodeB, Weight = weight });
        }

        public List<Edge> GetEdges(Node nodeA) => this.edges.Where(e => e.NodeA == nodeA).ToList();        

        public IEnumerable<Node> GetAdjacents(Node node) => this.edges.Where(e => e.NodeA == node).Select(e => e.NodeB);
        
        public int GetEdgeWeight(Node nodeA, Node nodeB) => this.edges.Where(e => e.NodeA == nodeA && e.NodeB == nodeB).Select(e => e.Weight).First();

        public int GetNodesCount() => this.nodes.Count;

        public IEnumerable<Node> GetAllNodes() => this.nodes;

        public Edge GetEdge(Node nodeA, Node nodeB) => this.edges.First(e => e.NodeA == nodeA && e.NodeB == nodeB);
    }
}
