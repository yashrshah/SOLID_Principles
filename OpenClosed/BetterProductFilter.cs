using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class BetterProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (var item in items)
            {
                if (specification.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}
