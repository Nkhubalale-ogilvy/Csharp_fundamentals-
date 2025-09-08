public abstract class Shape
{
    public abstract double Area();


}


class Rectangle : Shape
{
    private readonly double _length;
    private readonly double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public override double Area()
    {
        return _length * _width;
    }

}


class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}


public class PolymorphismDemo
{
   public  static void RunDemo()
    {
        Shape rect = new Rectangle(3, 3);
        Shape circle = new Circle(10);

        Console.WriteLine($"Rectangle area: {rect.Area()}");
        Console.WriteLine($"Circle area: {circle.Area()}");

        Shape[] shapes = new Shape[]
        {
            new Rectangle(3, 3),
            new Circle(10),
            
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetType()} is: {shape.Area()}");
        }
    }     
}