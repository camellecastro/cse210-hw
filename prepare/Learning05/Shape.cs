using System;

public class Shape
{
    //member variable
    private string _color;

    //constructor
    public Shape(string color)
    {
        _color = color;
    }

    //getter and setter
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    //method
    public virtual double GetArea()
    {
        return 0;
    }
}