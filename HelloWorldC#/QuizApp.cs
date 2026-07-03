string q1 = "What is the capital of Germany?";
string a1 = "Berlin".ToLower();

string q2 = "What is 2+2";
string a2 = "4";

int score = 0;

System.Console.WriteLine(q1);
string userA1 = Console.ReadLine().ToLower();

if (userA1.Trim() == a1)
{
    score++;
}

System.Console.WriteLine(q2);
string userA2 = Console.ReadLine();

if (userA2.Trim() == a2)
{
    score++;
}

System.Console.WriteLine("Your final score was " + score);

if (score == 2)
{
    System.Console.WriteLine("You are a genius");
}
else
{
    System.Console.WriteLine("You need to learn more, bro");
}