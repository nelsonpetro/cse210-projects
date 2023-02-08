using System;

public class Word
{
    
    private string _word;

    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void Hide()
    {
        _word = new string('_', _word.Length);
        _isHidden = true;
    }

    public bool GetHiddenValue()
    {
        return _isHidden;
    }

    public string GetWord()
    {
        return _word;
    }
}