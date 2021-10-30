using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Graph.DepthFirstSearch
{
    [TestClass]
    public class Proof
    {
        [TestMethod]
        public void VisitAll_TestCase1()
        {
            // Arrange
            Graph graph = GetGraph1();
            Node start = graph.GetAllNodes().Where(n => n.Name == "1").First();
            Algoritmo algoritmo = new Algoritmo();
            
            // Act
            algoritmo.VisitAllNodes(graph, start);

            // Assert
            foreach (Node node in graph.GetAllNodes())
            {
                node.Discovered.Should().BeTrue();
            }

            algoritmo.Order[0].Should().Be("1");
            algoritmo.Order[1].Should().Be("2");
            algoritmo.Order[2].Should().Be("6");
            algoritmo.Order[3].Should().Be("7");
            algoritmo.Order[4].Should().Be("3");
            algoritmo.Order[5].Should().Be("8");
            algoritmo.Order[6].Should().Be("4");
            algoritmo.Order[7].Should().Be("5");
        }

        [TestMethod]
        public void VisitAll_TestCase2()
        {
            // Arrange
            Graph graph = GetGraph2();
            Node start = graph.GetAllNodes().Where(n => n.Name == "1").First();
            Algoritmo algoritmo = new Algoritmo();

            // Act
            algoritmo.VisitAllNodes(graph, start);

            // Assert
            foreach (Node node in graph.GetAllNodes())
            {
                node.Discovered.Should().BeTrue();
            }

            algoritmo.Order[0].Should().Be("1");
            algoritmo.Order[1].Should().Be("2");
            algoritmo.Order[2].Should().Be("4");
            algoritmo.Order[3].Should().Be("6");
            algoritmo.Order[4].Should().Be("7");
            algoritmo.Order[5].Should().Be("5");
            algoritmo.Order[6].Should().Be("8");
            algoritmo.Order[7].Should().Be("3");
            algoritmo.Order[8].Should().Be("9");
        }

        private Graph GetGraph1()
        {
            Node one = new Node() { Name = "1" };
            Node two = new Node() { Name = "2" };
            Node three = new Node() { Name = "3" };
            Node four = new Node() { Name = "4" };
            Node five = new Node() { Name = "5" };
            Node six = new Node() { Name = "6" };
            Node seven = new Node() { Name = "7" };
            Node eight = new Node() { Name = "8" };

            Graph graph = new Graph();
            graph.AddEdge(one, two, 1);
            graph.AddEdge(one, three, 1);
            graph.AddEdge(one, four, 1);
            graph.AddEdge(one, five, 1);
            graph.AddEdge(three, eight, 1);
            graph.AddEdge(two, six, 1);
            graph.AddEdge(two, seven, 1);

            return graph;
        }

        private Graph GetGraph2()
        {
            Node one = new Node() { Name = "1" };
            Node two = new Node() { Name = "2" };
            Node three = new Node() { Name = "3" };
            Node four = new Node() { Name = "4" };
            Node five = new Node() { Name = "5" };
            Node six = new Node() { Name = "6" };
            Node seven = new Node() { Name = "7" };
            Node eight = new Node() { Name = "8" };
            Node nine = new Node() { Name = "9" };

            Graph graph = new Graph();
            graph.AddEdge(one, two, 1);
            graph.AddEdge(one, three, 1);
            graph.AddEdge(two, four, 1);
            graph.AddEdge(two, five, 1);
            graph.AddEdge(four, six, 1);
            graph.AddEdge(six, seven, 1);
            graph.AddEdge(five, eight, 1);
            graph.AddEdge(three, nine, 1);

            return graph;
        }
        
    }
}
