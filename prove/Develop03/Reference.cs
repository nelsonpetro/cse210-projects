using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _initialVerse;
    private string _endVerse;
    private string _text;
    public Reference()
    {
        _book = "";
        _chapter = "";
        _initialVerse = "";
        _endVerse = "";
        _text = "";
    }
    public Reference(string book, string chapter, string initialVerse, string endVerse, string text)
    {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
        _endVerse = endVerse;
        _text = text;
    }

    public Reference(string book, string chapter, string initialVerse, string text)
    {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
        _endVerse = "";
        _text = text;
    }

    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }
    public string GetInitialVerse()
    {
        return _initialVerse;
    }
    public void SetInitialVerse(string initialVerse)
    {
        _initialVerse = initialVerse;
    }
    public string GetEndVerse()
    {
        return _initialVerse;
    }
    public void SetEndVerse(string endVerse)
    {
        _endVerse = endVerse;
    }
    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }
   
}