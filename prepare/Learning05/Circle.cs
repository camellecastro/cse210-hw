using System;

public class Circle : Shape
{
    //member variable
    private double _radius;

    //constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //override method
    public override double GetArea()
    {
        return Math.PI * ( _radius * _radius );
    }
}