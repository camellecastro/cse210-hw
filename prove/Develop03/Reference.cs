// Class: Reference
// Responsibility: Keeps track of the book, chapter, and verse information.
// Attributes: _book : string
// 		_chapter : int
// 		_verse : int
// 		_endVerse : int
// Constructors:
// Reference(book : string, chapter : int, verse : int)
// Reference( book : string, chapter : int, startVerse : int, endVerse : int)
// Methods:
// GetDisplayText() : string

using System;

public class Reference
{
    //attribute
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructors
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // For single verses, start and end are the same.
    }
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse; 
    }

    //method
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

    }
}