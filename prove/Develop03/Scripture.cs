public class Scripture {
    private List<string> _words = new List<string>();
    public Scripture(string text)
    {
        List<string> wordsList = new List<string>(text.Split(" "));
        _words.AddRange(wordsList);
        
    }
    public void HideWords()
    {
        Random random = new Random();
        
        bool run = true;
        while (run)
        {
            int randomNumber = random.Next(_words.Count);

            Word singleWord = new Word(_words[randomNumber]);
            if (singleWord.IsHidden(_words[randomNumber]) != true)
            {
                string change = singleWord.Hide();
                _words[randomNumber] = change;
                run = false;
            }
        }
    }
    public string GetText()
    {
        return string.Join(" ",_words);
    } 
    public bool IsCompletelyHidden()
    {
        int count = 0;
        foreach (string word in _words)
        {
            if (word == "___")
            {
                count += 1;
            }
        }
        int lenghtOfVerse = _words.Count();
        if (count == lenghtOfVerse)
        {
            return true;
        }
        else return false;
    }
}