using System.Reflection.Metadata;

namespace ProjectPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class MultiFuncMachine : IMultiDevice
    {
        private IPrinter _printer;
        private IScanner _scanner;

        public MultiFuncMachine(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }
        
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