using System;
using System.Linq;

namespace DependencyInversion
{
    class Program
    {
        // now what if we want to change some code in relationships class(low level class).
        // Then we might need to do some change in high level class (Program)
        // this is violating DependencyInversion
        // we will create an interface so that high level module will depend on abstraction not concretions
        //public Program(Relationships relationships)
        //{
        //    var relations = relationships.Relations;
        //    foreach (var item in relations.Where(x=>x.Item1.Name == "Rajesh" && x.Item2 == Relationship.Parent))
        //    {
        //        Console.WriteLine($"Rajesh has a child {item.Item3.Name}");
        //    }
        //}
        public Program(IRelationshipBrowser browser)
        {
            var relations = browser.FindAllChildrenOf("Rajesh");
            foreach (var item in relations)
            {
                Console.WriteLine($"Rajesh has a child {item.Name}");
            }
        }
        //Entities must depend on abstractions, not on concretions.
        //It states that the high-level module must not depend on the low-level module, but they should depend on abstractions.
        static void Main(string[] args)
        {
            var parent = new Person("Rajesh");
            var child1 = new Person("Mosam");
            var child2 = new Person("Yash");
            var relationships = new NewRelationships();
            relationships.AddParentAndChildRelationship(parent,child1);
            relationships.AddParentAndChildRelationship(parent, child2);
            new Program(relationships);
            Console.ReadLine();
        }
    }
}
