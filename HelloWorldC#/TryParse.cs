System.Console.WriteLine("Try to guess a number");
string inputString = Console.ReadLine();
Random random = new Random();
int randomNumber = random.Next(1, 11);
int num1;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    if (num1 == randomNumber)
    {
        System.Console.WriteLine("You guessed a correct number");
    }
    else
    {
        System.Console.WriteLine("Did not guess it correctly. The number was " + randomNumber);
    }
}
else
{
    System.Console.WriteLine("Enter a number next time");
}
