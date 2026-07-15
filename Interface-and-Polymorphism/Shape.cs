public interface IShape
{
    double GetArea();
}

public class Circle : IShape
{

    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Rectangle : IShape
{

    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

   public double GetArea()
    {
        return _width * _height;
    }
}