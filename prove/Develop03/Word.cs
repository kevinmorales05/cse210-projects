public class Word
{
    public int[] _hiddenWords;

    public Word()
    {
        var list = new List<int>();
        _hiddenWords = list.ToArray();
    }

    public void addHiddenWord(int num)
    {

        _hiddenWords.Append(num);

    }
    public void cleanHiddenWords()
    {
        Array.Clear(_hiddenWords, 0, _hiddenWords.Length);
    }
    public int analyzeHiddenWords(int numbers)
    {

        // foreach(int num in _hiddenWords){
        //     if(_hiddenWords.Equals(numbers)){
        //         Console.WriteLine("HOLA repetido");
        //         Console.WriteLine(numbers);
        //     }
        // }
 
        // for(int i=0; i<_hiddenWords.Length; i++){
        //     Console.WriteLine(_hiddenWords.GetValue(i));
        // }

        if (_hiddenWords.Contains(numbers))
        {
            return 10;
        }

        else
        {
            return 20;
        }

    }
    public int[] getHiddenWords()
    {
        return _hiddenWords;
    }
}