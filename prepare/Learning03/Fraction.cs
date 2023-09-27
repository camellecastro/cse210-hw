using System;

public class Fraction // class: Function
{
    // attributes: _top : int
    //             _bottom : int
    private int _top;
    private int _bottom;

    // constructors:
    // Fraction()
    // Fraction(wholeNumber : int)
    // Fraction(top : int, bottom : int)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // methods:
    // GetTop()
    // SetTop(top : int)
    // GetBottom()
    // SetBottom(_bottom : int)
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // GetFractionString() : string
    // GetDecimalValue() : double
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}   


