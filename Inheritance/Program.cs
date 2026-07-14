
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dog myDog = new Dog();
            // myDog.MakeSound();
            // myDog.Eat();

            // Employee joe = new Employee("Joe", 30, "Dishwasher", 1);
            // joe.DisplayEmployeeInfo();

            Manager carl = new Manager("Carl", 55, "Manager", 2, 10);
            carl.DisplayManagereInfo();
            carl.BecomeOlder(5);
        }
    }
    
}