using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Graph.ShortestPath
{
    [TestClass]
    public class Proof
    {
        [TestMethod]
        public void GetShortestPath_TestCase1()
        {

        }

        private Graph GetGraph1()
        {
            Node one = new Node("1");
            Node two = new Node("2");
            Node three = new Node("3");
            Node four = new Node("4");
            Node five = new Node("5");
            Node six = new Node("6");
            Graph graph = new Graph();

            graph.AddEdge(one, two, 2);
            graph.AddEdge(one, three, 5);
            graph.AddEdge(two, five, 10);
            graph.AddEdge(two, four, 6);
            graph.AddEdge(three, five, 8);
            graph.AddEdge(three, four, 9);
            graph.AddEdge(five, six, 3);
            graph.AddEdge(four, six, 4);

            return graph;
        }
    }
}
