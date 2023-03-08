using System;

class Program
{

    static void Main(string[] args)
    {
        
     
        Phrase scriptureText = new Phrase("Bible", "John 8:32");
        string[] convertedWord = scriptureText.convertToArray(" And ye shall know the truth, and the truth shall make you free.");
        Scripture new_scripture = new Scripture(convertedWord);
        

        int op = 0;
        while(op == 0){
            
            Console.WriteLine(scriptureText.getVerse());
            new_scripture.printScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string quit = Console.ReadLine();
            if (quit == "quit"){
                op = 1;
            }
            if (quit == ""){
                 new_scripture.hideWords();
                Console.Clear();
            }

        }
    
  


    }
}