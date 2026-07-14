namespace Inheritance
{
    class Animal
    {
        private int privateField;
        protected int protectedField;
        public int publicField;
        public void Eat()
        {
            System.Console.WriteLine("Animal is eating");
        }

        public virtual void MakeSound()
        {
            System.Console.WriteLine("Animal makes a generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            System.Console.WriteLine("Dog is Barking");
            protectedField = 1;
            publicField = 1;

        }
    }

    class Cat : Animal {
         public override void MakeSound()
        {
            System.Console.WriteLine("Cat meowing");
        }
    }

    class Collie : Dog
    {
        public void DoTricks()
        {
            System.Console.WriteLine("Doing tricks");
        }
    }
}