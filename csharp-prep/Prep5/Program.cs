using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        double number = PromptUserNumber();
        Console.WriteLine( DisplayResult(number, name));
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static double SquareNumber(double number)
    {
        return Math.Pow(number, 2);
    }
    static string DisplayResult(double number, string name)
    {
        double square = SquareNumber(number);
        return $"{name}, the square of your number is {square.ToString()}";
    }
}