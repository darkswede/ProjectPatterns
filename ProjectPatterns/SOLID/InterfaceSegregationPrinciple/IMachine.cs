using System.Reflection.Metadata;

namespace ProjectPatterns.SOLID.InterfaceSegregationPrinciple
{
    public interface IMachine//its wrong
    {
        void Print(Document document);
        void Scan(Document document);
        void Fax(Document document);
    }
}