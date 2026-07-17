public class Generics
{
    public void PrintArray<T>(T[] array) {
        foreach (T item in array)
        {
            System.Console.WriteLine(item);
        }
    }
}