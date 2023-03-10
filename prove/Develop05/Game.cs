public class Game
{

    public void menu()
    {
        Console.WriteLine("***************************");
        Console.WriteLine("*** Welcome to Eternal Quest Demo ***");
        Console.WriteLine("***************************");
        Console.WriteLine("*** What is your name ? ***");
        string name = Console.ReadLine();
        User newUser = new User(name);
        Console.Clear();
        Console.WriteLine("*** Creating new user ***");
        Thread.Sleep(3000);
        Console.WriteLine("*** User created sucessfully ***");
        Thread.Sleep(3000);
        //Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome " + newUser.getName() + "!");
        Console.WriteLine();


        int op = 0;
        while (op == 0)
        {
            //Console.Clear();
            Console.WriteLine("*** Eternal Quest Demo ***");
            Console.WriteLine("*** Menu ***");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Get User Score");
            Console.WriteLine("7. Quit");
            Console.WriteLine("***************************");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();


            switch (option)
            {
                case "1":
                    createNewGoal(newUser);
                    break;
                case "2":
                    listGoals(newUser);
                    break;
                case "3":
                    saveGoals(newUser);
                    break;
                case "4":
                    loadGoals(newUser);
                    break;
                case "5":
                    recordEvent(newUser);

                    break;
                case "6":
                    getUserScore(newUser);
                    break;
                case "7":
                    op = 1;
                    break;
                default:
                    Console.WriteLine("***************************");
                    Console.WriteLine("Please write a valid option");
                    Console.WriteLine("***************************");
                    break;

            }

        }
    }

    public void createNewGoal(User user)
    {
        int op = 0;
        while (op == 0)
        {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("*** Create a Goal ***");
            Console.WriteLine("1. Create mortal goal");
            Console.WriteLine("2. Create eternal goal");
            Console.WriteLine("3. Go to the main menu");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();


            switch (option)
            {
                case "1":
                    Console.Write("What is your mortal goal?: ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is type of your goal?: ");
                    string lifeArea = Console.ReadLine();

                    Console.Write("How many points is about?: ");
                    int points = Convert.ToInt32(Console.ReadLine());
                    NormalGoal newGoal = new NormalGoal(goalDescription, points, lifeArea);
                    user.addMortalGoal(newGoal);
                    Console.Clear();
                    Console.WriteLine("*** Creating new Goal ***");
                    Thread.Sleep(3000);
                    Console.WriteLine("***************************");
                    Console.WriteLine("*** Mortal Goal created sucessfully ***");
                    Console.WriteLine("***************************");
                    break;
                case "2":
                    Console.Write("What is your eternal goal?: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points is about?: ");
                    int point = Convert.ToInt32(Console.ReadLine());
                    EternalGoal eternalGoal = new EternalGoal(description, point);
                    user.addEternalGoal(eternalGoal);
                    Console.Clear();
                    Console.WriteLine("*** Creating new Eternal Goal ***");
                    Thread.Sleep(3000);
                    Console.WriteLine("***************************");
                    Console.WriteLine("*** Eternal Goal created sucessfully ***");
                    Console.WriteLine("***************************");
                    break;
                case "3":
                    op = 1;
                    break;

                default:
                    Console.WriteLine("***************************");
                    Console.WriteLine("Please choose a valid option!");
                    Console.WriteLine("***************************");
                    break;

            }

        }
    }
    public void listGoals(User user)
    {
        List<NormalGoal> mortalGoals = user.getMortalGoals();
        List<EternalGoal> eternalGoals = user.GetEternalGoals();
        Console.WriteLine("***************************");
        Console.WriteLine("***********List of Goals****************");
        Console.WriteLine("Mortal Goals");
        for (int i = 0; i < mortalGoals.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + mortalGoals[i].getGoalDescription());
        }
        Console.WriteLine("Eternal Goals");
        for (int i = 0; i < eternalGoals.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + eternalGoals[i].getGoalDescription());
        }
        Console.WriteLine("***************************");
        Console.WriteLine("***************************");
    }
    public void saveGoals(User user)
    {
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();
        using StreamWriter file = new($"{filename}");
        //Mortal Goals
        foreach (NormalGoal normalGoal in user.getMortalGoals())
        {
            file.WriteLine($"{normalGoal.getGoalDescription()},{normalGoal.getPointsToWin()}, {normalGoal.getLifeArea()},normal");
        }
        //Eternal Goals
        foreach (EternalGoal normalGoal in user.GetEternalGoals())
        {
            file.WriteLine($"{normalGoal.getGoalDescription()},{normalGoal.getPointsToWin()},eternal");
        }
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine("The file " + filename + " was saved successfully!");
        Console.WriteLine("***************************");

    }
    public void loadGoals(User user)
    {
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goalDescription = parts[0]; //goal description
            string pointsToWin = parts[1]; //points
            string type = parts[2]; //type
            //analyze type an add in the arrays according to it
            if (type == "eternal")
            {
                EternalGoal eternalGoal = new EternalGoal(goalDescription, Convert.ToInt32(pointsToWin));
                user.addEternalGoal(eternalGoal);
            }
            else
            {
                NormalGoal newGoal = new NormalGoal(goalDescription, Convert.ToInt32(pointsToWin), type);
                user.addMortalGoal(newGoal);
            }

        }
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine("File loaded successfully!");
        Console.WriteLine("***************************");


    }
    public void recordEvent(User user)
    {

        listGoals(user);
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine("Write the goal description that you want:");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("Write the points you earned:");
        string pointsEarned = Console.ReadLine();

        EventRegistry newRegistry = new EventRegistry(Convert.ToInt32(pointsEarned), goalDescription);
        user.addEvent(newRegistry);
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine("Event added successfully!");
        Console.WriteLine("***************************");
    }

    public void getUserScore(User user)
    {
        int totalScore = 0;
        List<NormalGoal> mortalGoals = user.getMortalGoals();
        List<EternalGoal> eternalGoals = user.GetEternalGoals();
        
        for (int i = 0; i < mortalGoals.Count; i++)
        {
            totalScore = totalScore + mortalGoals[i].getPointsToWin();
        }
        for (int i = 0; i < eternalGoals.Count; i++)
        {
            totalScore = totalScore + eternalGoals[i].getPointsToWin();
        }
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine($"The user {user.getName()} has {totalScore} points.");
        Console.WriteLine("***************************");
    }



}