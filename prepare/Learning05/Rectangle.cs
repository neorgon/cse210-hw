public class Rectangle : Shape
{
    private double _length;
    private double _widht;

    public Rectangle(string color, double length, double widht): base(color)
    {
        _length = length;
        _widht = widht;
    }

    public override double GetArea()
    {
        return _length * _widht;
    }
}