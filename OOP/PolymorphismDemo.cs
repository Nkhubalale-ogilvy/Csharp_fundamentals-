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