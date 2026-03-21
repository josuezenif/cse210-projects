
public class Scripture
{
    Reference _reference;
    List<Word> _wordsList;
    Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _wordsList = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _wordsList.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hidden = 0;

        while (hidden < numberToHide)
        {
            int indexWords = _random.Next(_wordsList.Count);
            if (!_wordsList[indexWords].IsHidden())
            {
                _wordsList[indexWords].Hide();
                hidden++;
            }
        }
    }

    public string DisplayTextScripture()       //display scripture with hidden words
    {
        string result = _reference.DisplayScriptureReference();
        foreach (Word word in _wordsList)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordsList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}