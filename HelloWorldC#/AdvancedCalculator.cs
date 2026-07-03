System.Console.WriteLine("Enter the first number:");
int firstNum = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Enter the second number:");
int secondNum = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Choose an operation: +, -, *, /");
string operation = System.Console.ReadLine();

if (operation == "+")
{
    System.Console.WriteLine($"Result: {firstNum + secondNum}");
}
else if (operation == "-")
{
    System.Console.WriteLine($"Result: {firstNum - secondNum}");
}
else if (operation == "/")
{
    if (secondNum < 1)
    {
        System.Console.WriteLine("Error: Division by zero is not allowed.");
    }
    else
    {
        System.Console.WriteLine($"Result: {firstNum / secondNum}");
    }
}
else if (operation == "*")
{
    System.Console.WriteLine($"Result: {firstNum * secondNum}");
}
else
{
    System.Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}