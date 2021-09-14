using System.Reflection.Metadata;

namespace ProjectPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class Photocopy : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new System.NotImplementedException();
        }
    }
}