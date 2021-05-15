using System.Collections.Generic;

namespace OpenClosed
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size) 
        {
            foreach (var item in products)
                if (item.Size == size)
                    yield return item;
        }
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var item in products)
                if (item.Color == color)
                    yield return item;
        }
        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var item in products)
                if (item.Color == color && item.Size == size)
                    yield return item;
        }
        // This product filter is violating the Open Closed Principle as we are updating this class for every new requirement.
    }
}
