System.Console.WriteLine("Welcome to the adventure game");
System.Console.WriteLine("Enter your character name");
string playerName = Console.ReadLine();
System.Console.WriteLine("Choose your character (Warrior, Wizard, Archer)");
string characterType = Console.ReadLine();

System.Console.WriteLine($"You, {playerName}  the {characterType} find yourself at the edge of a dark forest.");
System.Console.WriteLine("Do you enter the forest or camp outside (Enter/Camp)?");
string choise1 = Console.ReadLine();

if (choise1.ToLower() == "enter")
{
    System.Console.WriteLine("You bravely enter the forest");
}
else
{
    System.Console.WriteLine("You decided to camp out.");
}

bool gameContinues = true;

while (gameContinues)
{
    System.Console.WriteLine("You come to a fork in the road. Go left or right");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "left")
    {
        System.Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else
    {
        System.Console.WriteLine("You encountered a wild beast");
        System.Console.WriteLine("Fight or flee?");
        string fightChoise = Console.ReadLine();
        if (fightChoise == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                System.Console.WriteLine("You beat the wild beast");
            }
            if (luck > 8)
            {
                System.Console.WriteLine("The wild beast dropped a treasure");
            }
            else
            {
                System.Console.WriteLine("The beast attacked you.");
                gameContinues = false;
            }
        }
    }
}
