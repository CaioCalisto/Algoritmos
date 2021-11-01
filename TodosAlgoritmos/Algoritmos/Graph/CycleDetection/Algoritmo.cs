using System.Collections.Generic;

namespace Algoritmos.Graph.CycleDetection
{
    public class Algoritmo
    {
        public int GetNumberOfCycle(Network network, Person focus)
        {
            foreach (Person person in network.People)
            {
                person.Discovered = false;
            }
            focus.Discovered = true;

            int count = 0;
            DFS(network, focus, focus, ref count);

            return count;
        }

        private void DFS(Network network, Person currentPerson, Person focus, ref int count)
        {
            List<Friendship> friendships = network.GetFriendships(currentPerson);
            Person nextPerson;

            while (friendships.Count > 0)
            {
                nextPerson = friendships[0].Friend;
                friendships.RemoveAt(0);

                if (nextPerson == focus)
                    count++;

                if (!nextPerson.Discovered)
                {
                    nextPerson.Discovered = true;
                    DFS(network, nextPerson, focus, ref count);
                }
            }
        }
    }
}
