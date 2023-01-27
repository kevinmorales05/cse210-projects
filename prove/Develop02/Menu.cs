public class Menu
{
    public void start()
    {
        //create a new journal
        Journal _newJornal = new Journal();
        Random randNum = new Random();
        List<string> questions = new List<string>(){
            "Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?"
        };

        bool start = true;
        while (start == true)
        {
            promptMenu();
            int opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {

                writeEntry(questions, _newJornal, randNum);

            }
            else if (opt == 2)
            {
                _newJornal.displayEntries();
            }
            else if (opt == 3)
            {
                loadEntries(_newJornal);
            }
            else if (opt == 4)
            {
                saveEntries(_newJornal);
            }
            else if (opt == 5)
            {
                start = false;
            }
            else
            {
                Console.WriteLine("Please write a valid option!");
            }


        }


    }
    public void promptMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
    }
    public void writeEntry(List<string> questions, Journal journal, Random randNum)
    {
        string question = questions[randNum.Next(0, questions.Count - 1)];
        Console.WriteLine($"{question}");
        string prompt = Console.ReadLine();
        string date = DateTime.UtcNow.ToString("MM/dd/yyyy");
        Entry newEntry = new Entry();
        newEntry.writeEntry(prompt, date, question);
        journal.addEntry(newEntry);
    }
    public void loadEntries(Journal journal)
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0]; //date
            string question = parts[1]; //question
            string prompt = parts[2]; //prompt
            //Console.WriteLine($"This is the date {date}");
            Entry newEntry = new Entry();
            newEntry.writeEntry(prompt,date,question);
            journal.addEntry(newEntry);

        }
    }
    public void saveEntries(Journal journal)
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();
        using StreamWriter file = new($"{filename}");

        foreach (Entry entry in journal._entries){
            file.WriteLine($"{entry._date},{entry._question},{entry._text}");
        }

    }

}