class Program
{
    static void Main()
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
