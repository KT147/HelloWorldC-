

namespace OOP
{
    public class Person
    {

        private string _name;
        private int _age;
        public string Name { get; }
        public int Age
        {
            get
            {
                return _age;
            } set
            {
                if (value >= 0)
                {
                    _age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Greet()
        {
            System.Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
