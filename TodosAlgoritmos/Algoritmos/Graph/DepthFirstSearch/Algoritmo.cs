using System.Collections.Generic;
using System.Linq;

namespace Algoritmos.Graph.DepthFirstSearch
{
    /// <summary>
    ///  We start from a particular vertex and explore as far as possible along each branch before retracing back
    ///  Applications
    ///  - Used to find a path between two vertices.
    ///  - Used to detect cycles in a graph.
    ///  - Used in topological sorting.
    ///  - Used to solve puzzles having only one solution (e.g., mazes)
    /// </summary>
    public class Algoritmo
    {
        private int iterator;

        public string[] Order { get; private set; }

        public void VisitAllNodes(Graph graph, Node start)
        {            
            foreach (Node node in graph.GetAllNodes())
            {
                node.Discovered = false;
            }

            Order = new string[graph.GetNodesCount()];
            iterator = 0;
            start.Discovered = true;
            this.AddToOrderOutput(start.Name);

            Dfs(graph, start);
        }

        private void Dfs(Graph graph, Node node)
        {
            List<Edge> edges = graph.GetEdges(node);
            Node sucessor;

            while (edges.Count() != 0)
            {
                sucessor = edges[0].NodeB;
                edges.RemoveAt(0);
                if (!sucessor.Discovered)
                {
                    sucessor.Discovered = true;
                    this.AddToOrderOutput(sucessor.Name);
                    Dfs(graph, sucessor);
                }
            }
        }

        private void AddToOrderOutput(string node)
        {
            this.Order[iterator] = node;
            iterator++;
        }
    }
}
