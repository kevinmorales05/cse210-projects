using System.Diagnostics;

public class Listing : Activity
{
    private List<string> _activities = new List<string>();
    private List<string> _newList = new List<string>();
    public Listing(string name, string description) : base(name, description)
    {
        _activities.Add("Who are people that you appreciate?");
        _activities.Add("What are personal strengths of yours?");
        _activities.Add("Who are people that you have helped this week?");
        _activities.Add("When have you felt the Holy Ghost this month?");
        _activities.Add("ho are some of your personal heroes?");

    }



    public override void startActivity()
    {


        Stopwatch timeMeasure = new Stopwatch();



        Random ran = new Random();
        int number = ran.Next(0, _activities.Count - 1);
        Console.WriteLine("Get ready...");
        base.loadingAnimation(1500);
        Console.WriteLine("List as many responses you can to the following propmt:");
        Console.WriteLine("--- " + _activities[number] + " ---");
        base.recursiveAnimation(3, "You may begin in: ", "", 700);
        Console.WriteLine("Go!");
        timeMeasure.Start();
        do
        {
            string newText = Console.ReadLine();
            _newList.Add(newText);
        } while (Convert.ToInt32(timeMeasure.Elapsed.TotalMilliseconds) < base.getTimeInSeconds());
        Console.WriteLine();
        Console.WriteLine("You listed " + _newList.Count + " items!");
        Console.WriteLine();
        Console.WriteLine("Well done!! ");
        base.loadingAnimation(1500);
        Console.Clear();

    }

}