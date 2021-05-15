using System.Collections.Generic;
using System.Linq;

namespace DependencyInversion
{
    // low-level
    public class Relationships
    {
        private List<(Person, Relationship, Person)> relations =
            new List<(Person, Relationship, Person)>();

        public void AddParentAndChildRelationship(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
        public List<(Person, Relationship, Person)> Relations => relations;
    }
    public class NewRelationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations =
            new List<(Person, Relationship, Person)>();

        public void AddParentAndChildRelationship(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return from item in relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
                   select item.Item3;
        }
    }
}
