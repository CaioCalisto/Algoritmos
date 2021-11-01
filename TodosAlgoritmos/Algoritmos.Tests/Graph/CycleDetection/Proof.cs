using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Graph.CycleDetection
{
    [TestClass]
    public class Proof
    {
        [TestMethod]
        public void Test1()
        {
            // Arrange
            Network network = GetTestCase1();
            Person focus = network.People.Where(p => p.Name == "Caio").First();
            Algoritmo algoritmo = new Algoritmo();

            // Act
            int numberOfCycle = algoritmo.GetNumberOfCycle(network, focus);

            // Assert
            numberOfCycle.Should().Be(1);
        }

        private Network GetTestCase1()
        {
            Person caio = new Person("Caio");
            Person domicio = new Person("Domicio");
            Person filipe = new Person("Filipe");
            Person allan = new Person("Allan");
            Network network = new Network();

            network.AddFriendship(caio, domicio);
            network.AddFriendship(domicio, filipe);
            network.AddFriendship(caio, allan);
            network.AddFriendship(filipe, caio);

            return network;
        }
    }
}
