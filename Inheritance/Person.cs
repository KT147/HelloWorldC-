namespace Inheritance
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            System.Console.WriteLine("Person constructor called.");
        }

        public void DisplayPersonInfo()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        /// <summary>Makes our object older!</summary>
        /// <param name="years">The parameter that indicates the amount of years the object should age</param>
        /// <returns>Returns the new age after aging/becoming older</returns>
        public int BecomeOlder(int years)
        {
            return Age + years;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public int EmployeeId { get; set; }
        public Employee(string name, int age, string jobtitle, int employeeId) : base(name, age)
        {
            JobTitle = jobtitle;
            EmployeeId = employeeId;
            System.Console.WriteLine("Employee costructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            System.Console.WriteLine($"Jobtitle : {JobTitle}, EmployeeId: {EmployeeId}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }
        public Manager(string name, int age, string jobtitle, int employeeId, int teamSize) : base(name, age, jobtitle, employeeId)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagereInfo()
        {
            DisplayPersonInfo();
            System.Console.WriteLine($"TeamSize : {TeamSize}");
        }
    }
}