using System;

public class Videos
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments;

    public Videos(string title, string author, int length, List<Comments> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public Videos()
    {
        _title = "";
        _author = "";
        _length = 0;
    }

    public int CountComments()
    {
        int numComments = _comments.Count;
        return numComments;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAuthor()
    {
        return _author;
    }
    
    public void SetLength(int length)
    {
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetComments(List<Comments> comments)
    {
        _comments = comments;
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }
}