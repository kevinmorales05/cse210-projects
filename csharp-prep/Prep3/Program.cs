using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool status = true;

        do
        {
            Console.WriteLine("What is the magic number?");
            int guess_number = int.Parse(Console.ReadLine());
            if (guess_number == number)
            {
                status = false;
                Console.WriteLine("You guessed it!");
            }
            else if (guess_number > number)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess_number < number)
            {
                Console.WriteLine("Lower!");
            }

        } while (status);


    }
}