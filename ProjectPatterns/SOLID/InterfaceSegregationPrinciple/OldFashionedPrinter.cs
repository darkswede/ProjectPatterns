using System;
using System.Reflection.Metadata;

namespace ProjectPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document document)
        {
        }

        [Obsolete("unused", true)]//dont do that
        public void Scan(Document document)
        {
            throw new System.NotImplementedException();
        }

        public void Fax(Document document)
        {
        }
    }
}