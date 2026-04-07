using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();

        Square square = new Square("BLUE", 12.4);
        square.GetColor();
        square.GetArea();

        Rectangle rectangle = new Rectangle("RED", 4.33, 5);
        rectangle.GetColor();
        rectangle.GetArea();

        Circle circle = new Circle("GREEN", 8.45);
        circle.GetColor();
        circle.GetArea();

        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(square);
        shapesList.Add(rectangle);
        shapesList.Add(circle);

        foreach (Shape shape in shapesList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The color for this shape is {color} and the area is {area.ToString("F2")} cm^2");
            Console.WriteLine();
        }

    }
}