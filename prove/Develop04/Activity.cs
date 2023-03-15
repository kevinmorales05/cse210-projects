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
    public Activity (){}

public void setName(string name){
    _name = name;
}
public int getTimeInSeconds(){
    return _activityTime;
}
public void setDescription(string description){
    _description = description;
}
    public void welcomeMessage()
    {
        Console.WriteLine("Welcome to the " + _name + " Activity.");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int timeInSeconds = Convert.ToInt32(Console.ReadLine());
        setTimeInSeconds(timeInSeconds);  //in order to set the time for the activity

    }
    public void setTimeInSeconds(int time){
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
    public void recursiveAnimation( int fromNumber, string message, string messageFinish, int time){
        // for (int i = fromNumber; fromNumber > 0; i--){
        //     Console.WriteLine(message + "..." + i);
        //     Thread.Sleep(_activityTime);
        //     Console.WriteLine(messageFinish);
        // }
        do {
            Console.WriteLine(message + "..." + fromNumber);
            if(time>0){
                Thread.Sleep(time);
            }
            else {
                Thread.Sleep(_activityTime);
            }
          
            if (messageFinish == "") {

            }
            else{
                Console.WriteLine(messageFinish);
            }
            
            fromNumber--;
        } while(fromNumber > 0);
    }
    public void loadingAnimation(int timeToThink){
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
            Thread.Sleep(timeToThink);
            Console.Write("\b \b");
        }
    }
    public void PauseProcess(int timeToPause, string message, string finishMessage){
        Console.WriteLine(message);
        Thread.Sleep(timeToPause);
         Console.WriteLine(finishMessage);
    }
    public void finalMessage(){
        Console.WriteLine();
        Console.WriteLine("************************");
        Console.WriteLine("You have done a good job!");
        Console.WriteLine(_name);
        Console.WriteLine("************************");
        Console.WriteLine();
    }
    public abstract void startActivity();
}