using System;

public class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;

    // Constructors
    // no parameters initializing fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that has one parameter for the top and keeps denominater at 1
    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    // Constructor where both top and bottom can be changed
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Properties
    // How are these neccessary? They don't add anything to the program
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Methods
    public string GetFractionsString()
    {
        string info = $"{_top}/{_bottom}";
        return info;
    }
    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}