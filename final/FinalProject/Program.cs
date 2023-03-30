using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to World War III Game!");
        Console.WriteLine("***First Set Up your Game***");
        int players = 0,lifePoints = 0, attack= 0, numRockets = 0;
        bool pass = false;
        while(pass == false){
            Console.WriteLine();
            Console.WriteLine("How many players are going to play: ");
            players = Convert.ToInt32(Console.ReadLine());
            if (players > 1 && players < 5){
                pass = true;
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Please write a valid number of players! (from 2 to 4)");
                Console.WriteLine();
            }
        }
        bool pass2 = false;
        while(pass2 == false){
             Console.WriteLine();
             Console.WriteLine("How many life points do you want for the rocket launchers?: ");
             lifePoints = Convert.ToInt32(Console.ReadLine());
             if (lifePoints >= 4 && lifePoints <= 1000){
                pass2 = true;
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Please write a valid number of lifePoints! (from 4 to 1000)");
                Console.WriteLine();
            }
        }
        bool pass3 = false;
        while(pass3 == false){
            Console.WriteLine();
            Console.WriteLine("How many points do you want inflict for the rocket launcher attack?: ");
            attack = Convert.ToInt32(Console.ReadLine());
             if (attack >= 1 && attack <= 500){
                pass3 = true;
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Please write a valid number of attack! (from 1 to 500)");
                Console.WriteLine();
            }
        }
        bool pass4 = false;
        while(pass4 == false){
            Console.WriteLine();
            Console.WriteLine("How many rocket lauchers do you want for each player?: ");
            numRockets = Convert.ToInt32(Console.ReadLine());
            if (numRockets >= 1 && numRockets <= 10){
                pass4 = true;
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Please write a valid number of numRockets! (from 1 to 10)");
                 Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine("***Successful configuration!***");
        Console.WriteLine();
        //Create a Game
        Game newGame = new Game(players,lifePoints, attack, numRockets);
        newGame.startGame();
    }
}