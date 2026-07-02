System.Console.WriteLine("Enter the first number:");
int firstNum = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the second number:");
int secondNum = int.Parse(Console.ReadLine());

Calculate(firstNum, secondNum);

static void Calculate(int a, int b)
{
    Console.WriteLine("Sum is:");
    Console.WriteLine(a + b);
}