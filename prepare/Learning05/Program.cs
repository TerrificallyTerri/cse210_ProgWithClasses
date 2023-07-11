using System;

class Program
{
    static void Main(string[] args)
    {
        // List of Shape objects
        List<Shape> shapes = new List<Shape>();

        Console.WriteLine($"Hello Prep 5 World!");

        Square s1 = new Square("purple", 4);
        Console.WriteLine($"The {s1.GetColor()} shape has an area of {s1.GetArea()}");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Orange", 4, 6);
        Console.WriteLine($"The {s2.GetColor()} shape has an area of {s2.GetArea()}");
        shapes.Add(s2);

        Circle s3 = new Circle("Magenta", 12);
        Console.WriteLine($"The {s3.GetColor()} shape has an area of {s3.GetArea()}");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape in the list has an area of {area}.");
        }
    }
}
