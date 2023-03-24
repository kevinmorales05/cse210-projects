public class Game
{
    private List<Player> _players = new List<Player>();
    private int _numberOfPlayers;
    private int _numberOfRockets;
    private int _lifePointsConfig;
    private int _attackConfig;
    private List<string> _countries = new List<string>();
    private List<string> _assignedCountries = new List<string>();

    public Game(int numberOfPlayers, int lifePoints, int attack, int numRockets)
    {
        _numberOfPlayers = numberOfPlayers;
        _lifePointsConfig = lifePoints;
        _attackConfig = attack;
        _numberOfRockets = numRockets;
        _countries = new List<string>() { "usa", "china", "russia", "europe" };

    }

    public void startGame()
    {
        //Choose the size of the ground according to the numberOfPlayers
        int sizeOfGround = getSizeOfGround();


        int players = Convert.ToInt32(Console.ReadLine());
        //start the game creating the players
        for (int i = 1; i <= _numberOfPlayers; i++)
        {
            Console.WriteLine("Player " + i + " What is your name?");
            string name = Console.ReadLine();
            Player newPlayer = new Player(name);
            Ground newGround = new Ground(sizeOfGround, sizeOfGround, _numberOfRockets);
            newPlayer.setGround(newGround);
            //select a country
            string country = chooseCountry();
            newPlayer.setCountry(country);
            //Add Rockets according to the selected country
            for(int j = 0; j< _numberOfRockets; j++){
                string rocketName = country + j.ToString();
                //choose the position of the rocket
                //1. print the ground updated

                Console.Write("Please write the position of the launcher in X axis: ");
                int positionX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please write the position of the launcher in Y axis: ");
                int positionY = Convert.ToInt32(Console.ReadLine());
                //2. update the ground with the selected position, while in order to avoid to put in the same place

                switch(country){
                    case "usa":
                    newPlayer.addRocket(new USARocket(_lifePointsConfig,rocketName, positionX, positionY));
                        break;
                    case "china":
                    newPlayer.addRocket(new ChinaRocket(_lifePointsConfig,rocketName, positionX, positionY));
                        break;
                    case "russia":
                    newPlayer.addRocket(new RussiaRocket(_lifePointsConfig,rocketName, positionX, positionY));
                        break;
                    case "europe":
                    newPlayer.addRocket(new EURocket(_lifePointsConfig,rocketName, positionX, positionY));
                        break;
            }
            }


            addPlayers(newPlayer);
        }

    }
    public void addPlayers(Player player)
    {
        _players.Add(player);
    }
    public void decreasePlayers()
    {

    }
    public void getPlayersPoints()
    {

    }
    public void printPointsPositions()
    {

    }
    public int randomPlayerChoice()
    {

        return 0;
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
                Console.WriteLine(i + _countries[i]);
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