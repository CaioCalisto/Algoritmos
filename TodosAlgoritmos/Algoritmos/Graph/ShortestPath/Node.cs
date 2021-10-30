namespace Algoritmos.Graph.ShortestPath
{
    public class Node
    {
        public Node(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int DistanceFromSource { get; set; }

        public bool InTree { get; set; }

        public Node Parent { get; set; }
    }
}
