namespace LiskovSubstitution
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override string ToString()
        {
            return $"Width : {Width} and Height : {Height}";
        }
    }
}
