using System;

namespace LiskovSubstitution
{
    class Program
    {
        static public int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2,6);
            Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

            // If we have square then its perfectly fine to store refernce to square as Rectangle.
            // because square is rectangle and its derived from rectangle class.
            // Its not working as area is resulting 0 and is violating Liskov Substitution
            // now we will make rectagle class properties as virtual and will overide this properties in child class(Square)
            // Here, we are holding Rectangle refernce to square. So it will go to Rectangle properties and if its virtual
            // then it will overide child class property(Square)
            Rectangle square = new Square();
            square.Height = 2;
            Console.WriteLine($"{square} has area {Area(square)}");
            Console.ReadLine();
        }
    }
}
