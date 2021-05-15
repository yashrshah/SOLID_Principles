using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public enum Color { Blue, Red, Orange, Black };
    public enum Size { S, M, L, XL };
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;
        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }
}
