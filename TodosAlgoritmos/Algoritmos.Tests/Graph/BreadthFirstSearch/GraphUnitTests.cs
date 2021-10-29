using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Graph.BreadthFirstSearch
{
    [TestClass]
    public class GraphUnitTests
    {
        [TestMethod]
        public void AddEdge_NewsVertices_GraphShouldContainEdge()
        {
            // Arrange
            Node nodeA = new Node() { Name = "A" };
            Node nodeB = new Node() { Name = "B" };
            Graph graph = new Graph();

            // Act
            graph.AddEdge(nodeA, nodeB, 2);

            // Assert
            graph.Edges.Should().HaveCount(1);
            graph.Edges.Should().Contain(e => e.Weight == 2);
            graph.Edges.Should().Contain(e => 
                    (e.NodeA == nodeA && e.NodeB == nodeB)
                    || (e.NodeA == nodeB && e.NodeB == nodeA));
        }

        [TestMethod]
        public void AddEdge_EdgeDirectionAlreadyExists_ShouldThrowException()
        {
            // Arrange
            Node nodeA = new Node() { Name = "A" };
            Node nodeB = new Node() { Name = "B" };
            Graph graph = new Graph();
            graph.AddEdge(nodeA, nodeB, 2);

            // Act
            Action action = () => graph.AddEdge(nodeA, nodeB, 2);

            // Assert
            action.Should().Throw<Exception>();
        }

        [TestMethod]
        public void GetAdjacents_ThreeAdjacentsAdded_ShouldReturnAllThem()
        {
            // Arrange
            Node nodeA = new Node() { Name = "A" };
            Node nodeB = new Node() { Name = "B" };
            Node nodeC = new Node() { Name = "C" };
            Node nodeD = new Node() { Name = "D" };
            Node nodeE = new Node() { Name = "E" };
            Graph graph = new Graph();
            graph.AddEdge(nodeA, nodeB, 1);
            graph.AddEdge(nodeB, nodeC, 1);
            graph.AddEdge(nodeB, nodeD, 1);
            graph.AddEdge(nodeB, nodeE, 1);

            // Act
            IEnumerable<Node> nodes = graph.GetAdjacents(nodeB);

            // Assert
            nodes.Should().HaveCount(3);
            nodes.Should().Contain(nodeC);
            nodes.Should().Contain(nodeD);
            nodes.Should().Contain(nodeE);
        }

        [TestMethod]
        public void GetEdgeWeight_ExistingNodes_ShouldReturnWeight()
        {
            // Arrange
            Node nodeA = new Node() { Name = "A" };
            Node nodeB = new Node() { Name = "B" };
            Node nodeC = new Node() { Name = "C" };
            Node nodeD = new Node() { Name = "D" };
            Node nodeE = new Node() { Name = "E" };
            Graph graph = new Graph();
            graph.AddEdge(nodeA, nodeB, 1);
            graph.AddEdge(nodeB, nodeC, 2);
            graph.AddEdge(nodeB, nodeD, 6);
            graph.AddEdge(nodeB, nodeE, 8);

            // Assert
            graph.GetEdgeWeight(nodeA, nodeB).Should().Be(1);
            graph.GetEdgeWeight(nodeB, nodeC).Should().Be(2);
            graph.GetEdgeWeight(nodeB, nodeD).Should().Be(6);
            graph.GetEdgeWeight(nodeB, nodeE).Should().Be(8);
        }

        [TestMethod]
        public void GetNodes_ContainsFiveNodes_ShouldReturnAllThem()
        {
            // Arrange
            Node nodeA = new Node() { Name = "A" };
            Node nodeB = new Node() { Name = "B" };
            Node nodeC = new Node() { Name = "C" };
            Node nodeD = new Node() { Name = "D" };
            Node nodeE = new Node() { Name = "E" };
            Graph graph = new Graph();
            graph.AddEdge(nodeA, nodeB, 1);
            graph.AddEdge(nodeB, nodeC, 2);
            graph.AddEdge(nodeB, nodeD, 6);
            graph.AddEdge(nodeB, nodeE, 8);

            // Act
            int nodesCount = graph.GetNodesCount();

            // Assert
            nodesCount.Should().Be(5);
        }

        [TestMethod]
        public void GetEdge_EdgeExists_ShouldReturnEdge()
        {
            // Arrange
            Node nodeA = new Node() { Name = "A" };
            Node nodeB = new Node() { Name = "B" };
            Node nodeC = new Node() { Name = "C" };
            Graph graph = new Graph();
            graph.AddEdge(nodeA, nodeB, 1);
            graph.AddEdge(nodeB, nodeC, 2);

            // Act
            Edge edge = graph.GetEdge(nodeB, nodeC);

            // Assert
            edge.Should().NotBeNull();
            edge.Weight.Should().Be(2);
        }
    }
}
