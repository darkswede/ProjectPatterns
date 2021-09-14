using System;
using System.Linq;

namespace ProjectPatterns.SOLID.DependencyInversion.BrokenRuleImplementation
{
    public class Research
    {
        public Research(Relationships relationships)
        {
            var relations = relationships.Relations;
            foreach (var relation in relations.Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
            {
                Console.WriteLine($"John has a child named {relation.Item3.Name}");
            }
        }
    }
}