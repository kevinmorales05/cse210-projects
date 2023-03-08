public class Phrase{
    private string[] _phrase;
    private string _author;
    private string _verse;

    public Phrase(string author, string verse){
       _author = author;
       _verse = verse;
    }
    public string[] convertToArray(string text){
        string[] wordsArray = text.Split(' ');

        return wordsArray;
    }
    public void printArray(string[] arrayToPrint){
        for(int i = 0; i < arrayToPrint.Length; i++){
            Console.WriteLine(arrayToPrint[i]);
        }
    }
    public string getVerse(){
        return _verse;
    }

}