public interface IToolUser
{
    void SetHammer(Hammer hammer);
    void SetSaw(Saw saw);
}

public class Hammer
{
    public void Use()
    {
        System.Console.WriteLine("Hammering nails");
    }
}

public class Saw
{
    public void Use()
    {
        System.Console.WriteLine("Sawing wood");
    }
}

public class Builder: IToolUser
{
    // public Hammer Hammer { get; set; }
    // public Saw Saw { get; set; }

    private Hammer _hammer;
    private Saw _saw;
    // private Hammer _hammer;
    // private Saw _saw;
    // public Builder(Hammer hammer, Saw saw)
    // {
    //     // _hammer = new Hammer();
    //     // _saw = new Saw();
    //     _hammer = hammer;
    //     _saw = saw;
    // }

    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        System.Console.WriteLine("House built");
    }

    public void SetHammer(Hammer hammer)
    {
        _hammer = hammer;
    }

    public void SetSaw(Saw saw)
    {
        _saw = saw;
    }
}