public class Entry {
    public string _text;
    public string _date;
    public string _question;
    public Entry(){

    }
    public void writeEntry(string text, string date, string question){
        _text = text;
        _date = date;
        _question = question ;
    }
    public void displayEntry(){
        Console.WriteLine($"Date: {_date} - Prompt: {_question}");
        Console.WriteLine($"{_text}");
    }
}