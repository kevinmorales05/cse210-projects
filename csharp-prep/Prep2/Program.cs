using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score: ");
        int score = int.Parse(Console.ReadLine());

        if (score > 100 || score < 0) {
            Console.WriteLine("Please write a valid score");
        }
        else {
            if (score >= 90 && score <= 100) {
                Console.WriteLine("Your score is A");
            }
            else if (score >= 80 && score > 70 ) {
                Console.WriteLine("Your score is B");
            }
            else if (score >= 70 && score > 60) {
                Console.WriteLine("Your score is C");
            }
            else if (score >= 60 ) {
                Console.WriteLine("Your score is D");
            }
            else {
                Console.WriteLine("Your score is F");
            }
        }
        
    }
}