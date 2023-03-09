using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square mySquare = new Square("red", 23);
        Console.WriteLine(mySquare.GetColor());
        Console.WriteLine(mySquare.GetArea());
        Circle myCircle = new Circle("white", 10);
        Console.WriteLine(myCircle.GetColor());
        Console.WriteLine(myCircle.GetArea());
        Rectangle myRectangle = new Rectangle("blue", 3, 6);
        Console.WriteLine(myRectangle.GetColor());
        Console.WriteLine(myRectangle.GetArea());



    }
}