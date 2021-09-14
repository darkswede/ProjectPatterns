using System.Collections.Generic;

namespace ProjectPatterns.SOLID.DependencyInversion.BrokenRuleImplementation
{
    public class Relationships
    {
        public List<(Person, Relationship, Person)> Relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            Relations.Add((parent, Relationship.Parent, child));
            Relations.Add((child, Relationship.Child, parent));
        }
    }
}