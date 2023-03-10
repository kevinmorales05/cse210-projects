public abstract class Activity
{
    private string _name;
    private string _description;
    private int _activityTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void welcomeMessage()
    {
        Console.WriteLine("Welcome to the " + _name + " Activity.");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int timeInSeconds = Convert.ToInt32(Console.ReadLine());
        getTimeInSeconds(timeInSeconds);  //in order to set the time for the activity

    }
    public void getTimeInSeconds(int time){
        _activityTime = time;
    }
    public void showAnimationSameLine(string animation, int sleepTime, int fromNumber, string message){
        for (int i = fromNumber; fromNumber > 0; i--){
            Console.WriteLine(message);
            Console.WriteLine(i);
            Thread.Sleep(sleepTime);
            Console.Write("\b \b");
        }
            Console.WriteLine("Done!");
    }
    public void recursiveAnimation(int sleepTime, int fromNumber, string message){
        for (int i = fromNumber; fromNumber > 0; i--){
            Console.WriteLine(message + "..." + i);
            Thread.Sleep(sleepTime);
        }
    }
    public void loadingAnimation(){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        foreach (string s in animationStrings){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void PauseProcess(int timeToPause, string message, string finishMessage){
        Console.WriteLine(message);
        Thread.Sleep(timeToPause);
         Console.WriteLine(finishMessage);
    }
    public void finalMessage(){
        Console.WriteLine("You have done a good job!");
        Console.WriteLine(_name);
    }
    public abstract void startActivity();
}