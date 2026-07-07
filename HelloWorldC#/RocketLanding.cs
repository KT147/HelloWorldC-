string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

for (int lines = 10; lines >= 0; lines--)
{
    Console.Clear();
    System.Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(500);
}
System.Console.WriteLine("The rocket has landed.");