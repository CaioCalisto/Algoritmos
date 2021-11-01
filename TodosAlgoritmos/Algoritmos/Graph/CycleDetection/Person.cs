namespace Algoritmos.Graph.CycleDetection
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool Discovered { get; set; }
    }
}
