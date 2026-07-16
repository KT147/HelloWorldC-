using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Structs
{

    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        // public int X;
        // public int Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            System.Console.WriteLine($"Point: ({X}, {Y})");
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            p1.Display();

            // Point p2;
            // p2.X = 10;
            // p2.Y = 20;
            Point p2 = new Point(20, 30);
            p2.Display();

            double distance = p1.DistanceTo(p2);
            System.Console.WriteLine($"Distance between points: {distance:F2}");

            // Point p3 = p1;
            // p3.X = 50;
            // p1.Display();
            // p3.Display();
            Day fr = Day.Fr;
            System.Console.WriteLine(fr);
            // 6, sest march sai pandud 5 võrduma
            System.Console.WriteLine((int)Month.Apr);
            System.Console.WriteLine((int)Day.Mo);

            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("Date and time class");

            DateTime dateTime = new DateTime(2026, 7, 16);
            System.Console.WriteLine("My birthday is " + dateTime);

            System.Console.WriteLine("Current Day: " + DateTime.Today);
            System.Console.WriteLine("Current Time: " + DateTime.Now);

            DateTime tomorrow = Date.GetTomorrow();
            System.Console.WriteLine("Tomorrow is " + tomorrow);

            System.Console.WriteLine("Current day of the week " + DateTime.Today.DayOfWeek);
            System.Console.WriteLine(Date.GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            System.Console.WriteLine("Days in Feb 2000: " + days);
            days = DateTime.DaysInMonth(2001, 2);
            System.Console.WriteLine("Days in Feb 2001: " + days);

            DateTime now = DateTime.Now;
            System.Console.WriteLine("The time is " + now.Hour + " hours, " + now.Minute + " minutes, and " + now.Second + " seconds.");

            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                System.Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                System.Console.WriteLine("Days passed since: " + daysPassed.Days);
            }
            else
            {
                System.Console.WriteLine("Wrong input");
            }

            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Maths class");
            System.Console.WriteLine("Ceiling " + Math.Ceiling(15.3));
            System.Console.WriteLine("Floor " + Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;
            System.Console.WriteLine("Lower number " + Math.Min(num1, num2));
            System.Console.WriteLine("Higher number " + Math.Max(num1, num2));

            System.Console.WriteLine("3 to the power of 5 is " + Math.Pow(3, 5));
            System.Console.WriteLine("Pi is " + Math.PI);
            System.Console.WriteLine("The square root of 25 is  " + Math.Sqrt(25));
            System.Console.WriteLine("Always positive is " + Math.Abs(-5));
            System.Console.WriteLine("Cos of 1 is " + Math.Cos(1));

            System.Console.WriteLine("-------------------------------------");

            Event e1 = new Event(
                new DateTime(2024, 7, 01, 0, 0, 0),
                new DateTime(2024, 7, 10, 0, 0, 0));

            Event e2 = new Event(
                new DateTime(2024, 7, 5, 0, 0, 0),
                new DateTime(2024, 7, 15, 0, 0, 0));

            System.Console.WriteLine("Event 1 Duration: " + e1.GetDuration() + " days");
            System.Console.WriteLine("Event 2 Duration: " + e2.GetDuration() + " days");
            System.Console.WriteLine("Events Overlap: " + e1.IsOverlapping(e2));

        }
    }
}

