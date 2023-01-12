using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        List<int> numbers = new List<int>();


        do
        {
            Console.Write("  Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
                numbers.Add(number);
            }

        } while (number != 0);
        int sum = 0;
        foreach (int num in numbers){
            sum = sum + num;
        }
        Console.WriteLine(" The sum is: "+ sum);
        Console.WriteLine(" The average is: "+ sum/numbers.Count);
        List <int>sortedValues = numbers.OrderBy(v => v)
            .ToList();        
            // foreach(int num in sortedValues){
            //     Console.WriteLine(num);
            // };
        Console.WriteLine(" The largest number is: "+ sortedValues[sortedValues.Count-1]);

    }
}