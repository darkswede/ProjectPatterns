using System;

namespace ProjectPatterns.SOLID.DependencyInversion.Implementation
{
    public class ResearchValid
    {
        public ResearchValid(IRelationshipBrowser browser)
        {
            foreach (var relation in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child named {relation.Name}");
            }
        }
    }
}