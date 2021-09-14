using System.Collections.Generic;
using Person = ProjectPatterns.SOLID.DependencyInversion.BrokenRuleImplementation.Person;

namespace ProjectPatterns.SOLID.DependencyInversion.Implementation
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}