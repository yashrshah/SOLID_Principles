using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{

    public class SizeSpecification : ISpecification<Product>
    {
        private Size Size;
        public SizeSpecification(Size size)
        {
            Size = size;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Size == Size;
        }
    }
}
