using System.Reflection.Metadata;

namespace ProjectPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class FavouritePrinter// : IMachine
    {
        void Print(Document document){}
        void Scan(Document document) {}
        void Fax(Document document) {}
    }
}