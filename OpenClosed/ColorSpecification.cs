namespace OpenClosed
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color Color;
        public ColorSpecification(Color color)
        {
            Color = color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == Color;
        }
    }
}
