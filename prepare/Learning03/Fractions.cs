using System;

public class Fractions
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTopValue()
    {
        return _top;
    }

    public void SetTopValue(int topValue)
    {
        _top = topValue;
    }

    public int GetBottomValue()
    {
        return _top;
    }

    public void SetBottomValue(int bottomValue)
    {
        _bottom = bottomValue;
    }

    // Methods

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}