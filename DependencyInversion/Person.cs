namespace DependencyInversion
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }
    public class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
    }
}
