using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        Square square = new("blue", 5);
        Rectangle rectangle = new("red", 4, 5);
        Circle circle = new("purple", 3);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape} | Colour: {shape.GetColour()} | Area: {Math.Round(shape.GetArea(), 2)}\n");
        }
    }
}