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

        [TestMethod]
        public void Test2()
        {
            // Arrange
            Network network = GetTestCase2();
            Person focus = network.People.Where(p => p.Name == "Caio").First();
            Algoritmo algoritmo = new Algoritmo();

            // Act
            int numberOfCycle = algoritmo.GetNumberOfCycle(network, focus);

            // Assert
            // Caio » Cassio » Estevam » Caio
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

        private Network GetTestCase2()
        {
            Person caio = new Person("Caio");
            Person domicio = new Person("Domicio");
            Person joao = new Person("Joao");
            Person filipe = new Person("Filipe");
            Person bruno = new Person("Bruno");
            Person allan = new Person("Allan");
            Person estevam = new Person("Estevam");
            Person cassio = new Person("Cassio");
            Person peter = new Person("Peter");
            Person markus = new Person("Markus");

            Network network = new Network();
            network.AddFriendship(caio, domicio);
            network.AddFriendship(caio, filipe);
            network.AddFriendship(caio, cassio);
            network.AddFriendship(caio, allan);
            network.AddFriendship(domicio, joao);
            network.AddFriendship(joao, filipe);
            network.AddFriendship(filipe, bruno);
            network.AddFriendship(bruno, cassio);
            network.AddFriendship(cassio, peter);
            network.AddFriendship(cassio, estevam);
            network.AddFriendship(estevam, caio);
            network.AddFriendship(cassio, markus);

            return network;
        }
    }
}
