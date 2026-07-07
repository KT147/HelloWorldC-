System.Console.WriteLine("Guess the number of 1 and 100");

Random random = new Random();
int randomNum = random.Next(1, 101);
System.Console.WriteLine(randomNum);

int userGuess = 0;
int counter = 0;

while (userGuess != randomNum)
{
    System.Console.WriteLine("Enter your guess");
    userGuess = int.Parse(Console.ReadLine());
    counter++;

    if (userGuess < randomNum)
    {
        System.Console.WriteLine("Too low. Try again.");
    } if (userGuess > randomNum)
    {
        System.Console.WriteLine("Too high. Try again.");
    }
}
System.Console.WriteLine("Bravo! You guessed it.");
System.Console.WriteLine("It took you " + counter + " tries.");