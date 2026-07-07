int currentScore;
int sum = 0;
double average = 0.00;
int count = 0;

do
{
    System.Console.WriteLine("Enter your students score. Enter -1 to finish");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != -1)
    {
        sum = sum + currentScore;
        count++;
        average = sum / count;
    }

} while (currentScore != -1);

System.Console.WriteLine("The average is " + average);