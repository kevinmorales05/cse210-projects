using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assigment assigment = new Assigment("Kevin Morales", "Life is Good");
        Console.WriteLine( assigment.GetSummary());
        MathAssigment mathAssigment = new MathAssigment("Denisse Morales", "Life is Good", "3.4", "3-24");
        Console.WriteLine( mathAssigment.GetSummary());
        Console.WriteLine( mathAssigment.GetHomeworkList());
        WritingAssigment writeAssignment = new WritingAssigment("Leonel Morales", "The Second World War", "Germany enters to Paris");
        Console.WriteLine( writeAssignment.GetWritingInformation());

    }
}