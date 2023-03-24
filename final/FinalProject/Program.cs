using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to World War III Game!");
        Console.WriteLine("How many players are going to play: ");
        int players = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many points do you want for the rocket launchers?: ");
        int lifePoints = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many points do you want inflict for the rocket launcher attack?: ");
        int attack = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many rocket lauchers do you want for each player?: ");
        int numRockets = Convert.ToInt32(Console.ReadLine());
        Game newGame = new Game(players,lifePoints, attack, numRockets);
        newGame.startGame();
    }
}