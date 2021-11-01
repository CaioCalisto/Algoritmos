using System.Collections.Generic;
using System.Linq;

namespace Algoritmos.Graph.CycleDetection
{
    public class Network
    {
        private List<Friendship> friendships;
        private List<Person> people;

        public IEnumerable<Person> People => this.people;

        public IEnumerable<Friendship> Friendships => this.friendships;

        public void AddFriendship(Person person, Person friend)
        {
            if (this.friendships == null)
                this.friendships = new List<Friendship>();

            if (this.people == null)
                this.people = new List<Person>();

            if (!this.people.Contains(person))
                this.people.Add(person);

            if (!this.people.Contains(friend))
                this.people.Add(friend);

            if (!this.friendships.Exists(f => f.Person == person && f.Friend == friend))
                this.friendships.Add(new Friendship(person, friend));
        }

        public List<Friendship> GetFriendships(Person person) => this.friendships.Where(p => p.Person == person).ToList();
        
    }
}
