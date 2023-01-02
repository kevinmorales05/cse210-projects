using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score: ");
        int Score = int.Parse(Console.ReadLine());
        string plus = " ";
        char numString = Score.ToString()[1];

        if (Score == 100)
        {
            plus = "+";
        }
        else if (Score == 60 || Score == 70 || Score == 80 || Score == 90) {
            plus = "-";
        }
        else
        {
            if (numString == '7' || numString == '8' || numString == '9')
            {
                plus = "+";
            }
            else if (numString == '3' || numString == '2' || numString == '1')
            {
                plus = "-";
            }

        }

        if (Score > 100 || Score < 0)
        {
            Console.WriteLine("Please write a valid Score");
        }

        else
        {
            if (Score >= 90 && Score <= 100)
            {
                Console.WriteLine($"Your Score is A{plus}");
            }
            else if (Score >= 80 && Score > 70)
            {
                Console.WriteLine($"Your Score is B{plus}");
            }
            else if (Score >= 70 && Score > 60)
            {
                Console.WriteLine($"Your Score is C{plus}");
            }
            else if (Score >= 60)
            {
                Console.WriteLine($"Your Score is D{plus}");
            }
            else
            {
                Console.WriteLine($"Your Score is F{plus}");
            }
        }

    }
}