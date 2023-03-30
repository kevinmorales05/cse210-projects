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
                newPlayer.getGround().setRocketPostion(positionX,positionY);
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

       while (finishGame == false && _numberOfPlayers > 1 ){
            for(int i=0; i< _players.Count; i++){
                if(_players.Count == 1){
                    Console.WriteLine($"The player {i} {_players[i].getCountry()}, won with {_players[i].getPoints()}");
                }
                if(_players[i].getRocketSize()> 0){
                
                Console.WriteLine($"Player {i+1}");
                 int attackedPlayerPosition = randomPlayerChoice(i);
                 Player attackedPlayer =  _players[attackedPlayerPosition];
                 Console.WriteLine($"You are going to attack the Player {attackedPlayerPosition + 1} of {attackedPlayer.getCountry().ToUpper()}");
                 
                 Console.WriteLine("***** Write the coordinates you want to attack *****");
                 Console.Write("Please write the position of the launcher in X axis: ");
                int positionX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please write the position of the launcher in Y axis: ");
                int positionY = Convert.ToInt32(Console.ReadLine());
                //attack a player
                _players[i].GetRocket().attack(positionX, positionY, attackedPlayer, _attackConfig);
              
                if(_players[i].getRockets().Count == 0){
                    _players.RemoveAt(i);
                    Console.WriteLine($"The player {i+1} is eliminated!");
                }


                }
                else {
                    Console.WriteLine($"Player {i+1} was destroyed!");
                }
                



            }
       }

    }

    public void welcomeMessage(){
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

    }
    public List<Player> getPlayers(int position){
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
        int randomPosition=0;
        while(op == 0){
            Random rand = new Random();
            int randomNumber = rand.Next(0, _players.Count);

            if(positionAttacker != randomNumber){
                op = 1;
                randomPosition = randomNumber;
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
                Console.WriteLine(i + " " + _countries[i]);
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