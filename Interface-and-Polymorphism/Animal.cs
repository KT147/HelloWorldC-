public interface IAnimal
{
    void MakeSound();
    void Eat(string food);
}

public class Dog : IAnimal
{
    public void Eat(string food)
    {
        System.Console.WriteLine("Dog ate " + food);
    }

    public void MakeSound()
    {
        System.Console.WriteLine("Dog barks");
    }
}
