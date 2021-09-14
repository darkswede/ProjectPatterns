namespace ProjectPatterns.SOLID.OpenClosed.Specification
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }
        
        public bool IsSatisfied(Product item)
        {
            return item.Color == _color;
        }
    }
}