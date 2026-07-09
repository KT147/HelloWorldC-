using System.Data;

namespace OOP
{
    public class Rectangle
    {

        public const int NumberOfCorners = 4;
        public readonly string Color;

        public Rectangle(String color)
        {
            Color = color;

        }

        public void DisplayDetails()
        {
            System.Console.WriteLine($"Color: {Color}, Corners: {NumberOfCorners}");
        }
    }
}
