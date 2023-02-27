using System;

// Child class: Circle

public class Circle : Shape
{
    // Attributes
    private double _radius;

    // Constructos
    public Circle (string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Getters and Setters
    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    // Method

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}