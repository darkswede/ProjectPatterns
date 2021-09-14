using System.Collections.Generic;

namespace ProjectPatterns.SOLID.OpenClosed.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }
}