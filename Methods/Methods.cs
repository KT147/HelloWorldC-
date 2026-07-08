// old syntax

namespace HelloWorldC
{
    internal class Methods
    {
        static int myResult;
        static void Main(string[] args)
        {

            myResult = AddTwoValues(1, 2);
            System.Console.WriteLine(myResult);

            void MyFirstMethod()
            {
                System.Console.WriteLine("First");

            }

            void MyFirstMethod2(string s)
            {
                System.Console.WriteLine("First");

            }

            MyFirstMethod();
        }

        static int AddTwoValues(int a, int b)
        {
            return a + b;
        }
        
    }
}