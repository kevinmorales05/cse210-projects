public class Game
{
    private List<Player> _players = new List<Player>();
    private int _numberOfPlayers;
    private int _numberOfRockets;
    private int _lifePointsConfig;
    private int _attackConfig;

    //final game counter
    private int _counterGame;

    private List<string> _countries = new List<string>();
    private List<string> _assignedCountries = new List<string>();

    public Game(int numberOfPlayers, int lifePoints, int attack, int numRockets)
    {
        _numberOfPlayers = numberOfPlayers;
        _lifePointsConfig = lifePoints;
        _attackConfig = attack;
        _numberOfRockets = numRockets;
        _countries = new List<string>() { "usa", "china", "russia", "europe" };
        _counterGame = numberOfPlayers;



    }

    public void startGame()
    {
        //Choose the size of the ground according to the numberOfPlayers
        int sizeOfGround = getSizeOfGround();
        //start the game creating the players
        for (int i = 1; i <= _numberOfPlayers; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Player " + i + " What is your name?");
            string name = Console.ReadLine();
            Player newPlayer = new Player(name);
            //Create a new Ground for each player
            Ground newGround = new Ground(sizeOfGround, sizeOfGround, _numberOfRockets);
            newPlayer.setGround(newGround);
            //select a country
            string country = chooseCountry();
            newPlayer.setCountry(country);
            //Add Rockets according to the selected country
            for (int j = 0; j < _numberOfRockets; j++)
            {
                string rocketName = country + j.ToString();

                //1. print the ground updated
                newPlayer.getGround().printGround();
                //choose the position of the rocket
                Console.WriteLine();
                Console.WriteLine($"Rocket number {j + 1}");
                Console.Write("Please write the position of the launcher in X axis: ");
                int positionX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please write the position of the launcher in Y axis: ");
                int positionY = Convert.ToInt32(Console.ReadLine());
                //2. update the ground with the selected position, while in order to avoid to put in the same place
                newPlayer.getGround().setRocketPostion(positionX, positionY);
                //3. print the ground updated
                newPlayer.getGround().printGround();
                switch (country)
                {
                    case "usa":
                        newPlayer.addRocket(new USARocket(_lifePointsConfig, rocketName, positionX, positionY));
                        break;
                    case "china":
                        newPlayer.addRocket(new ChinaRocket(_lifePointsConfig, rocketName, positionX, positionY));
                        break;
                    case "russia":
                        newPlayer.addRocket(new RussiaRocket(_lifePointsConfig, rocketName, positionX, positionY));
                        break;
                    case "europe":
                        newPlayer.addRocket(new EURocket(_lifePointsConfig, rocketName, positionX, positionY));
                        break;
                }
            }
            addPlayers(newPlayer);

        }
        Console.Clear();
        Console.WriteLine();
        //Start the game play
        welcomeMessage();
        bool finishGame = false;

        while (finishGame == false)
        {
            //Console.WriteLine($"Number of players in the game: {_numberOfPlayers}");
            if (_counterGame == 1)
            {
                //find the winner
                List<Player> winners = _players.FindAll(x => x.getStatus() == true);
                
                Console.WriteLine();
                Console.WriteLine("----------------------------");
                Console.WriteLine("The game finished!");
                Console.WriteLine($"Player name {winners[0].getName().ToUpper()} won!");
                Console.WriteLine($"Player points {winners[0].getPoints()}");
                Console.WriteLine($"Country {winners[0].getCountry().ToUpper()}");
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                
                //order players according to the points
                _players.Sort((x, y) => y.getPoints().CompareTo(x.getPoints()));

                Console.WriteLine();
                Console.WriteLine("------ Positions Table -----");
                Console.WriteLine("----------------------------");
                // int j = 1;
                // for (int i = _players.Count; _players.Count > 0; i--)
                // {
                //     Console.WriteLine($"{j}. Player name {_players[i-1].getName().ToUpper()}");
                //     Console.WriteLine($"Player country {_players[i-1].getCountry().ToUpper()}");
                //     Console.WriteLine($"Player points {_players[i-1].getPoints()}");
                //     j++;
                // }
                for(int i = 0; i<_players.Count ; i++){
                    Console.WriteLine($"{i+1}. Player name {_players[i].getName().ToUpper()}");
                    Console.WriteLine($"Player country {_players[i].getCountry().ToUpper()}");
                    Console.WriteLine($"Player points {_players[i].getPoints()}");
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                finishGame = true;
            }
            else
            {
                for (int i = 0; i < _players.Count; i++)
                {
                    if (_players[i].getRockets().Count >= 1)
                    {
                        //validate if the player is active
                        Console.WriteLine($"Player {i + 1}");
                        int attackedPlayerPosition = randomPlayerChoice(i);
                        Player attackedPlayer = _players[attackedPlayerPosition];
                        Console.WriteLine();
                        Console.WriteLine($"You are going to attack the Player {attackedPlayerPosition + 1} of {attackedPlayer.getCountry().ToUpper()}");
                        Console.WriteLine();
                        Console.WriteLine("***** Write the coordinates you want to attack *****");
                        Console.Write("Please write the position of the enemy in X axis: ");
                        int positionX = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please write the position of the enemy in Y axis: ");
                        int positionY = Convert.ToInt32(Console.ReadLine());
                        //attack a player
                        _players[i].GetRocket().attack(positionX, positionY, attackedPlayer, _attackConfig, _players[i]);
                        //if the attacked player do not have rockets it is desployed!
                        if (_players[attackedPlayerPosition].getRockets().Count == 0)
                        {
                            //_players.RemoveAt(attackedPlayerPosition);
                            //change the status of the Player
                            _players[attackedPlayerPosition].updateStatus(false);
                            Console.WriteLine();
                            Console.WriteLine("----------------------------");
                            Console.WriteLine($"The player {attackedPlayerPosition + 1} was eliminated!");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine();
                            decreasePlayers(); //decrease the counter
                        }
                    }
                    else
                    {

                        Console.WriteLine();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"Player {i + 1} was destroyed!");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine();

                    }
                }
            }

        }

    }

    public void welcomeMessage()
    {
        Console.WriteLine();
        Console.WriteLine("******************");
        Console.WriteLine("Welcome to the Wold War III Game");
        Console.WriteLine("All of this countries are in war, try to survive!.");
        Console.WriteLine("******************");
        Console.WriteLine();
    }
    public void addPlayers(Player player)
    {
        _players.Add(player);
    }
    public void decreasePlayers()
    {
        _counterGame = _counterGame - 1;
    }
    public List<Player> getPlayers(int position)
    {
        return _players;
    }
    public void getPlayersPoints()
    {

    }
    public void printPointsPositions()
    {

    }
    public int randomPlayerChoice(int positionAttacker)
    {
        int op = 0;
        int randomPosition = 0;
        while (op == 0)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, _players.Count);
            //validate no activated player
            if (_players[randomNumber].getStatus() == true)
            {
                if (positionAttacker != randomNumber)
                {
                    op = 1;
                    randomPosition = randomNumber;
                }
            }
            
                
            


        }
        return randomPosition;
    }
    public int getSizeOfGround()
    {

        if (_numberOfPlayers == 2)
        {
            return 10;
        }
        else if (_numberOfPlayers == 3)
        {
            return 20;
        }
        else if (_numberOfPlayers == 4)
        {
            return 30;
        }
        else
        {
            return 0;
        }
    }
    public string chooseCountry()
    {
        Console.WriteLine("Please choose a country(choose the number):");
        for (int i = 0; i < _countries.Count; i++)
        {
            if (_assignedCountries.Contains(_countries[i]))
            {

            }
            else
            {
                Console.WriteLine(i + " " + _countries[i].ToUpper());
            }

        }
        if (_assignedCountries.SequenceEqual(_countries))
        {
            return "none";
        }
        else
        {
            int option = Convert.ToInt32(Console.ReadLine());
            _assignedCountries.Add(_countries[option]);
            return _countries[option];
        }


    }



}