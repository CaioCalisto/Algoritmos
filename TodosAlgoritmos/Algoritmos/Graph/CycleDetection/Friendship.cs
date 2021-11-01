namespace Algoritmos.Graph.CycleDetection
{
    public class Friendship
    {
        public Friendship(Person person, Person friend)
        {
            Person = person;
            Friend = friend;
        }

        public Person Person { get; set; }

        public Person Friend { get; set; }
    }
}
