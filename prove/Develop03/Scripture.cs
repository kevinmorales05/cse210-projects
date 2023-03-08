public class Scripture
{
    private string[] _scripture;
    private Word _wordCounter = new Word();

    public Scripture(string[] script)
    {
        _scripture = script;
    }

    public void hideWords()
    {
        int len = _scripture.Length;
        Random rd = new Random();
        //first word hide
        if (_wordCounter == null)
        {
            Console.WriteLine("The array is empty");
        }
        else
        {

                int op = 1;
                while (op == 1)
                {
                    int ran_num = rd.Next(0, len);
                   // Console.WriteLine(ran_num);

                    if (_wordCounter.analyzeHiddenWords(ran_num) == 20)
                    {
                        //Console.WriteLine(_wordCounter.analyzeHiddenWords(ran_num));
                        //Console.WriteLine();

                        //Console.WriteLine(ran_num);
                        _wordCounter.addHiddenWord(ran_num);
                        _scripture[ran_num] = "-----";
                        printScripture();
                        op = 0;

                    }
                    else
                    {
                        Console.WriteLine("se repite");
                    }


                }

            
        }


    }
    public void printScripture()
    {
        string text = "";
        for (int i = 0; i < _scripture.Length; i++)
        {
            text = text + _scripture[i] + " ";
        }
        Console.WriteLine(text);
    }
}