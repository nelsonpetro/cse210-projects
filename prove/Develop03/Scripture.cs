using System;
using System.Linq;

public class Scripture
{
    private string _text;

    private List<Word> _wordsList = new List<Word>();

    private Reference _reference;

    private bool _allWordsHidden;

    private List<int> _availableIndex = new List<int>();

    public Scripture()
    {
        _text = "";
    }

     public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;
    }

    public List<int> PopulateIndexes()
    {
        for (int i = 0; i < _text.Split(" ").Count(); i++)
        {
            _availableIndex.Add(i);
        }
        return _availableIndex;
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int number = rnd.Next(2,4);
        if (number > _availableIndex.Count && _availableIndex.Count > 0)
        {
            number = _availableIndex.Count;
        }
        for (int i = 0; i < number; i++)
        {
            int rndindex = rnd.Next(_availableIndex.Count);
            int index = _availableIndex[rndindex];
            _availableIndex.RemoveAt(rndindex);
            _wordsList[index].Hide();
        }        
    }  

    public void WordList()
    {   
        foreach(string word in _text.Split(" "))
        {
            Word words = new Word(word);
            _wordsList.Add(words);
        }
    }

    public void DisplayRenderedText()
    {
        if (_reference.GetEndVerse() == "")
        {
            Console.Write($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetInitialVerse()} - ");
        }
        else
        {
            Console.Write($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetInitialVerse()}-{_reference.GetEndVerse()} - ");
        }
        foreach(Word element in _wordsList)
        {
            Console.Write($"{element.GetWord()} ");
        }
    }

    public bool AllWordsHidden()
    {
        _allWordsHidden = _wordsList.Any(word => word.GetHiddenValue() == false);
        return _allWordsHidden;
    } 
}