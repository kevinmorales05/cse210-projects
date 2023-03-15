using System.Diagnostics;
public class Reflexion : Activity
{
    private List<string> _thoughts = new List<string>();

    private List<string> _questions = new List<string>();
    public Reflexion(string name, string description) : base(name, description)
    {
        base.setName(name);
        base.setDescription(description);
        _thoughts.Add("Think of a time when you stood up for someone else.");
        _thoughts.Add("Think of a time when you did something really difficult.");
        _thoughts.Add("Think of a time when you helped someone in need.");
        _thoughts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }


    public override void startActivity()
    {
        Stopwatch timeMeasure = new Stopwatch();
        timeMeasure.Start();
       
    
        Random ran = new Random();
        int number = ran.Next(0,_thoughts.Count - 1);
        Console.WriteLine(_thoughts[number]);
        Console.WriteLine(_questions.Count);//delete
       int fromNumber = _questions.Count - 1;
         do {
            int random = ran.Next(0, fromNumber);
            Console.WriteLine(_questions[random]);
            base.loadingAnimation(500);
            fromNumber--;
        } while(fromNumber > 0 && Convert.ToInt32(timeMeasure.Elapsed.TotalMilliseconds) < base.getTimeInSeconds());
             //Console.WriteLine(timeMeasure.Elapsed.TotalMilliseconds);



    }



}