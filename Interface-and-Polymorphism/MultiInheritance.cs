public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

public class MultiFuntionPrinter : IPrintable, IScannable
{
    public void Print()
    {
        System.Console.WriteLine("Printing");
    }

    public void Scan()
    {
         System.Console.WriteLine("Scanning");
    }
}
