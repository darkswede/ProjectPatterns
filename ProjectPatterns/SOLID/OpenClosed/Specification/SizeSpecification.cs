namespace ProjectPatterns.SOLID.OpenClosed.Specification
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }
        
        public bool IsSatisfied(Product item)
        {
            return item.Size == _size;
        }
    }
}