using System.Globalization;

System.Console.WriteLine("Enter the first number:");
double firstNum = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the second number:");
double secondNum = double.Parse(Console.ReadLine());

Calculate(firstNum, secondNum);

static void Calculate(double a, double b)
{
    // Console.WriteLine("Sum is:");
    // Console.WriteLine(a + b);
    Console.WriteLine($"Sum is {Math.Round(a + b), 2}");
}