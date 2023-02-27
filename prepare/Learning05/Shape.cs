using System;

// Parent class
public abstract class Shape
{
    //  ----- Attributes -----
    private string _color;

    //  ----- Constructors -----
    public Shape (string color)
    {
        _color = color;
    }

    //  ----- Getters -----
    public string GetColor()
    {
        return _color;
    }

    // ----- Setters -----
    public void SetColor(string color)
    {
        _color = color;
    }

    //  ----- Method -----
    public abstract double GetArea();

}