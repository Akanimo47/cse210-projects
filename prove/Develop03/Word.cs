public class Word {
    private string _word;

    public Word(string word)
    {
        _word = word;
    }
    public string Hide()
    {
        return _word = "___";
        
    }
    public bool IsHidden(string word)
    {
        if (word == "___")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}