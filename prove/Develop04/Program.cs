using System;

class Program
{
    static void Main(string[] args)
    {
        
        int op = 0 ;
        while(op == 0){
            Console.Clear();
            Console.WriteLine("*** Mindfulness Program ***");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();

            switch (option) {
                case "1":
                    break;
                case "2":
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