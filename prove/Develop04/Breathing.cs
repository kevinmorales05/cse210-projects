public class Breathing : Activity
{
   
    public Breathing(string name, string description) : base(name, description)
    {

    }
    public Breathing(){
        base.setName("Breathing");
        base.setDescription("Activity in order to breath and be healed.");

    }

    public override void startActivity()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

    }


}