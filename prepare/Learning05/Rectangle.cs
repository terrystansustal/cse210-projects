using System;

// Child class: Rectangle

public class Rectangle : Shape
{
    // Attributes
    private double _width;
    private double _length;

    // Constructos
    public Rectangle (string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }

    // Getters and Setters
    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    // Method

    public override double GetArea()
    {
        return _width * _length;
    }
}