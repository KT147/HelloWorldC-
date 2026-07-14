using System.Diagnostics;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int sum = 0;
            // Debug.WriteLine("Main method is running");
            // try
            // {
            //     int num1 = 0;
            //     int num2 = 2;
            //     sum = num2 / num1;
            // }
            // catch (DivideByZeroException e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
            // catch (FormatException e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
            // catch (OverflowException e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error: " + e.Message);
            //     Debug.WriteLine(e.StackTrace);
            // }
            // finally
            // {
            //     System.Console.WriteLine("Finally block called either way");
            // }

            try
            {
                LevelOne();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            // System.Console.WriteLine(sum);
            // GetUserAge(Console.ReadLine());
        }

        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Age must be between 0 and 120.");
            }
            return age;
        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("Something went wrong");
        }

        public void HandleMultipleExceptions(string st, int num)
        {
            int[] numbers = { 1, 2, 3 };
            int number;
            
            try {
                number = int.Parse(st);
                number = numbers[num];
                Console.WriteLine(numbers[num]);
            } catch (FormatException e) {
                Console.WriteLine("Invalid format.");;
            } catch (IndexOutOfRangeException e) {
                 Console.WriteLine("Index out of range.");
            }
        }
    }
}