using System.Collections.Generic;
using System.Linq;
using ProjectPatterns.SOLID.DependencyInversion.BrokenRuleImplementation;

namespace ProjectPatterns.SOLID.DependencyInversion.Implementation
{
    public class RelationshipValid : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();
        
        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return _relations
                .Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
                .Select(r => r.Item3);
        }
    }
}