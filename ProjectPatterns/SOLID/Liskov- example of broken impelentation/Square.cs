using System;

namespace ProjectPatterns.SOLID.Liskov
{
    public class Square : Rectangle
    {
        public Square(int side)
        {
            Width = Height = side;
        }

        public new int Width
        {
            set { base.Width = base.Height = value; }
        }

        public new int Height
        {
            set { base.Width = base.Height = value; }
        }

        public static void UseIt(Rectangle rectangle)
        {
            rectangle.Height = 10;
            Console.WriteLine($"Pole wynosi {10*rectangle.Width}, rzeczywiste {rectangle.Area}");
        }
    }
}