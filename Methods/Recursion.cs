class Program
{
    static void CountDown(int number)
    {
        // Base case: Stop when we reach 0
        if (number == 0)
        {
            Console.WriteLine("Blast off!");
            return;
        }
 
        Console.WriteLine(number);
        
        // Recursive call: Reduce the number and call the function again
        CountDown(number - 1);
    }
 
    static void Main()
    {
        CountDown(5);
    }
}