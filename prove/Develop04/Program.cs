using System;

class Program
{
    static void Main(string[] args)
    {
        
        int op = 0 ;
        while(op == 0){
            //Console.Clear();
            Console.WriteLine("*** Mindfulness Program ***");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();

            switch (option) {
                case "1":
                Breathing activity = new Breathing();
                activity.welcomeMessage();
                activity.recursiveAnimation(10,"Breath in", "Breath out");
                activity.finalMessage();
                    break;
                case "2":
                Reflexion reflexionActivity = new Reflexion("Reflexion", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflexionActivity.welcomeMessage();
                reflexionActivity.startActivity();
                reflexionActivity.finalMessage();
                    break;
                case "3":
                    break;
                case "4":
                    op = 1;
                    break;
                default:
                    break;

            }

        }
        
    }
}