using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Graph.BreadthFirstSearch
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

            // Act
            string[] visitOrder = Algoritmo.VisitAllNodes(graph, start);

            // Assert
            foreach (Node node in graph.GetAllNodes())
            {
                node.Discovered.Should().BeTrue();
            }

            visitOrder[0].Should().Be("1");
            visitOrder[1].Should().Be("2");
            visitOrder[2].Should().Be("3");
            visitOrder[3].Should().Be("4");
            visitOrder[4].Should().Be("5");
            visitOrder[5].Should().Be("6");
            visitOrder[6].Should().Be("7");
            visitOrder[7].Should().Be("8");
        }

        [TestMethod]
        public void VisitAll_TestCase2()
        {
            // Arrange
            Graph graph = GetGraph2();
            Node start = graph.GetAllNodes().Where(n => n.Name == "1").First();

            // Act
            string[] visitOrder = Algoritmo.VisitAllNodes(graph, start);

            // Assert
            foreach (Node node in graph.GetAllNodes())
            {
                node.Discovered.Should().BeTrue();
            }

            visitOrder[0].Should().Be("1");
            visitOrder[1].Should().Be("2");
            visitOrder[2].Should().Be("3");
            visitOrder[3].Should().Be("4");
            visitOrder[4].Should().Be("5");
        }

        [TestMethod]
        public void VisitAll_TestCase3()
        {
            // Arrange
            Graph graph = GetGraph3();
            Node start = graph.GetAllNodes().Where(n => n.Name == "0").First();

            // Act
            string[] visitOrder = Algoritmo.VisitAllNodes(graph, start);

            // Assert
            foreach (Node node in graph.GetAllNodes())
            {
                node.Discovered.Should().BeTrue();
            }

            visitOrder[0].Should().Be("0");
            visitOrder[1].Should().Be("1");
            visitOrder[2].Should().Be("2");
            visitOrder[3].Should().Be("3");
            visitOrder[4].Should().Be("4");
            visitOrder[5].Should().Be("5");
            visitOrder[6].Should().Be("6");
            visitOrder[7].Should().Be("7");
        }

        private Graph GetGraph1()
        {
            Node one = new Node() { Name = "1" };
            Node two = new Node() { Name = "2"};
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

            Graph graph = new Graph();
            graph.AddEdge(one, two, 1);
            graph.AddEdge(one, three, 1);
            graph.AddEdge(two, four, 1);
            graph.AddEdge(two, five, 1);

            return graph;
        }

        private Graph GetGraph3()
        {
            Node zero = new Node() { Name = "0" };
            Node one = new Node() { Name = "1" };
            Node two = new Node() { Name = "2" };
            Node three = new Node() { Name = "3" };
            Node four = new Node() { Name = "4" };
            Node five = new Node() { Name = "5" };
            Node six = new Node() { Name = "6" };
            Node seven = new Node() { Name = "7" };

            Graph graph = new Graph();
            graph.AddEdge(zero, one, 1);
            graph.AddEdge(zero, two, 1);
            graph.AddEdge(zero, three, 1);
            graph.AddEdge(one, four, 1);
            graph.AddEdge(one, five, 1);
            graph.AddEdge(two, six, 1);
            graph.AddEdge(two, seven, 1);
            graph.AddEdge(three, seven, 1);

            return graph;
        }
    }
}
