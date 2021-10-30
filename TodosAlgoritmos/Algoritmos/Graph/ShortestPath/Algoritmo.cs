using System;
using System.Collections.Generic;

namespace Algoritmos.Graph.ShortestPath
{
    /// <summary>
    /// The shortest path from one vertex to another vertex is a path 
    /// in the graph such that the sum of the weights of the edges that 
    /// should be travelled is minimum.
    /// Applications
    /// - Used to find directions to travel from one location to another 
    ///     in mapping software like Google maps or Apple maps.
    /// - Used in networking to solve the min-delay path problem.
    /// - Used in abstract machines to determine the choices to reach a 
    ///    certain goal state via transitioning among different 
    ///    states(e.g., can be used to determine the minimum possible 
    ///    number of moves to win a game).
    /// </summary>
    public class Algoritmo
    {
        public void Dijkstra(Graph graph, Node from)
        {
            this.PrepareForDijkstra(graph);

            from.DistanceFromSource = 0;
            Node currentNode = from;
            int bestDistance;

            while (currentNode.InTree == false)
            {
                currentNode.InTree = true;
                List<Edge> edges = graph.GetEdges(currentNode);
                while (edges.Count > 0)
                {
                    Node to = edges[0].To;
                    if (to.DistanceFromSource > (currentNode.DistanceFromSource + edges[0].Distance))
                    {
                        to.DistanceFromSource = currentNode.DistanceFromSource + edges[0].Distance;
                        to.Parent = currentNode;
                    }
                    edges.RemoveAt(0);
                }

                bestDistance = int.MaxValue;
                foreach(Node node in graph.Nodes)
                {
                    if (node.InTree == false && bestDistance > node.DistanceFromSource)
                    {
                        bestDistance = node.DistanceFromSource;
                        currentNode = node;
                    }
                }
            }
        }

        private void PrepareForDijkstra(Graph graph)
        {
            foreach (Node node in graph.Nodes)
            {
                node.InTree = false;
                node.DistanceFromSource = int.MaxValue;
                node.Parent = null;
            }
        }
    }
}
