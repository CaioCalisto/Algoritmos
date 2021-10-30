namespace Algoritmos.Graph.ShortestPath
{
    public class Edge
    {
        public Edge(Node from, Node to, int distance)
        {
            From = from;
            To = to;
            Distance = distance;
        }

        public Node From { get; set; }

        public Node To { get; set; }

        public int Distance { get; set; }
    }
}
