using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 2);
        shapes.Add(s1);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());

        Rectangle s2 = new Rectangle("Red", 6, 3);
        shapes.Add(s2);
        // Console.WriteLine(s2.GetColor());
        // Console.WriteLine(s2.GetArea());

        Circle s3 = new Circle("Green", 3);
        shapes.Add(s3);
        // Console.WriteLine(s3.GetColor());
        // Console.WriteLine(s3.GetArea());
        
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}