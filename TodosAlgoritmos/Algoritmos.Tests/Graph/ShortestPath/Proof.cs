using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Graph.ShortestPath
{
    [TestClass]
    public class Proof
    {
        [TestMethod]
        public void GetShortestPath_TestCase1()
        {
            // Arrange
            Graph graph = GetGraph1();
            Node from = graph.Nodes.First(n => n.Name == "1");
            Algoritmo algoritmo = new Algoritmo();

            // Act
            algoritmo.Dijkstra(graph, from);

            // Assert distance
            graph.Nodes.First(n => n.Name == "2").DistanceFromSource.Should().Be(2);
            graph.Nodes.First(n => n.Name == "3").DistanceFromSource.Should().Be(5);
            graph.Nodes.First(n => n.Name == "4").DistanceFromSource.Should().Be(8);
            graph.Nodes.First(n => n.Name == "5").DistanceFromSource.Should().Be(12);
            graph.Nodes.First(n => n.Name == "6").DistanceFromSource.Should().Be(12);

            // Assert path from 1 to 6
            graph.Nodes.First(n => n.Name == "6").Parent.Name.Should().Be("4");
            graph.Nodes.First(n => n.Name == "4").Parent.Name.Should().Be("2");
            graph.Nodes.First(n => n.Name == "2").Parent.Name.Should().Be("1");

            // Assert path from 1 to 5
            graph.Nodes.First(n => n.Name == "5").Parent.Name.Should().Be("2");
            graph.Nodes.First(n => n.Name == "2").Parent.Name.Should().Be("1");
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
