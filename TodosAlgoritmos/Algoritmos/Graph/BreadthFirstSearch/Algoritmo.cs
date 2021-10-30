using System.Collections.Generic;

namespace Algoritmos.Graph.BreadthFirstSearch
{
    /// <summary>
    /// Explore all of its neighbours at the present depth before moving on to the vertices in the next level.
    /// Applications:
    /// - Used to determine the shortest paths and minimum spanning trees.
    /// - Used by search engine crawlers to build indexes of web pages.
    /// - Used to search on social networks.
    /// - Used to find available neighbour nodes in peer-to-peer networks such as BitTorrent.
    /// </summary>
    public static class Algoritmo
    {
        public static string[] VisitAllNodes(Graph graph, Node start)
        {
            int i = 0;
            string[] order = new string[graph.GetNodesCount()];

            List<Node> stack = new List<Node>();
            foreach (Node node in graph.GetAllNodes())
            {
                node.Discovered = false;
            }

            start.Discovered = true;
            stack.Add(start);

            while (stack.Count != 0)
            {
                Node currentNode = stack[0];
                stack.RemoveAt(0);
                order[i] = currentNode.Name;
                i++;

                foreach (Node adjascent in graph.GetAdjacents(currentNode))
                {
                    if (!adjascent.Discovered)
                    {
                        adjascent.Discovered = true;
                        stack.Add(adjascent);
                    }
                }                
            }

            return order;
        }
    }
}
