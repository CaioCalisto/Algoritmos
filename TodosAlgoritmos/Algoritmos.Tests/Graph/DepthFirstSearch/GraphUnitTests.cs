using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Graph.DepthFirstSearch
{
    [TestClass]
    public class GraphUnitTests
    {
        [TestMethod]
        public void GetEdges_ContainsThree_ShouldReturnAllThem()
        {
            // Arrange
            Node nodeA = new Node() { Name = "A" };
            Node nodeB = new Node() { Name = "B" };
            Node nodeC = new Node() { Name = "C" };
            Node nodeD = new Node() { Name = "D" };

            Graph graph = new Graph();
            graph.AddEdge(nodeA, nodeB, 1);
            graph.AddEdge(nodeA, nodeC, 1);
            graph.AddEdge(nodeA, nodeD, 1);

            // Act
            List<Edge> edges = graph.GetEdges(nodeA);

            // Assert
            edges.Should().HaveCount(3);
            edges.Should().Contain(e => e.NodeB == nodeB);
            edges.Should().Contain(e => e.NodeB == nodeC);
            edges.Should().Contain(e => e.NodeB == nodeD);
        }
    }
}
