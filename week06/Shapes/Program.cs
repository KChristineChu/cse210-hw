using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square square1 = new Square("Blue", 4);
        Rectangle rectangle1 = new Rectangle("Yellow", 4, 2);
        Circle circle1 = new Circle("Red", 3);
        
        
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine ($"The {color} shape has an area of {area}");
        }


    }
}