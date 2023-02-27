using System;

// Derived class: Square
public class Square : Shape
{
    //  ----- Attributes -----
    private double _side;

    //  ----- Constructors -----
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //  ----- Method -----
    public override double GetArea()
    {
        return _side * _side;
    }

}