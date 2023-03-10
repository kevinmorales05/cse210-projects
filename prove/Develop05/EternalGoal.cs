public class EternalGoal : Goal
{
    public EternalGoal(string goalDescription, int points) : base(goalDescription, points)
    {
    }

    

    public override void updateStatus()
    {
        Console.WriteLine("You cannot finish this goals");
    }
}