using System.Collections.Generic;
using ProjectPatterns.SOLID.OpenClosed.Specification;

namespace ProjectPatterns.SOLID.OpenClosed
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.Color == color)
                {
                    yield return product;
                }
            }

            //var filtered = products.Select(x => x.Color == color).ToList();
            //with LINQ
        }

        public IEnumerable<Product> FilteredBySize(IEnumerable<Product> products, Size size)
        {
            //LINQ
            //var filtered = products.Select(x => x.Size == size).ToList();

            foreach (var product in products)
            {
                if (product.Size == size)
                {
                    yield return product;
                }
            }
        }

        public IEnumerable<Product> FIlteredByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            //LINQ
            // var filtered = products.Select(x => x.Color == color && x.Size == size).ToList();

            foreach (var product in products)
            {
                if (product.Color == color && product.Size == size)
                {
                    yield return product;
                }
            }
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (var product in items)
            {
                if (specification.IsSatisfied(product))
                {
                    yield return product;
                }
            }
        }
    }
}