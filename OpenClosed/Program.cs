using System;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Red, Size.M);
            var cherry = new Product("Cherry", Color.Red, Size.S);
            var orange = new Product("Orange", Color.Orange, Size.S);
            Product[] products = { apple, cherry, orange };

            var pf = new ProductFilter();
            Console.WriteLine("Red Product(OLD):");
            foreach (var item in pf.FilterByColor(products,Color.Red))
            {
                Console.WriteLine($" - {item.Name} is {item.Color}");
            }
            var bpf = new BetterProductFilter();
            Console.WriteLine("Red Product(NEW):");
            foreach (var item in bpf.Filter(products, new ColorSpecification(Color.Red)))
            {
                Console.WriteLine($" - {item.Name} is {item.Color}");
            }
            Console.WriteLine("Red and Small Product(NEW):");
            foreach (var item in bpf.Filter(products, new AndSpecification<Product>(
                                        new ColorSpecification(Color.Red),new SizeSpecification(Size.S))))
            {
                Console.WriteLine($" - {item.Name} is {item.Color} and size : {item.Size}");
            }
            Console.ReadLine();
        }
    }
}
