// Class: Word
// Responsibility: Keeps track of a single word and whether it is shown or hidden.
// Attributes: _text : string
// 		_isHidden : bool
// Constructor: Word(text : string)
// Methods:
// Hide() : void
// Show() : void
// IsHidden() : bool
// GetDisplayText() : string

using System;

public class Word
{
    //attributes
    private string _text;
    private bool _isHidden;

    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words are initially visible.
    }

    //methods
    public void Hide()
    {
        _isHidden = true;

    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}