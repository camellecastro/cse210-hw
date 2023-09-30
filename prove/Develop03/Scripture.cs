// Class: Scripture
// Responsibility: Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
// Attributes: _reference : Reference
// 		   _words : List<Word>
// Constructor: Scripture(Reference : Reference, text : string)
// Methods: 
// HideRandomWords(numberToHide : int) : void
// GetDisplayText() : string
// IsCompletelyHidden() : bool

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    //attributes
    private Reference _reference;
    private List<Word> _words;

    //constructor
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList(); //https://learn.microsoft.com/en-us/answers/questions/723159/c-linq-select-vs-for-loop-speed
    }
    
    //methods
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(numberToHide, _words.Count(word => !word.IsHidden())); //https://learn.microsoft.com/en-us/dotnet/api/system.math.min?view=net-7.0

        for (int i = 0; i < wordsToHide; i++)
        {
            while (true)
            {
                //stretch: randomly select from only those words that are not already hidden
                int randomIndex = random.Next(_words.Count);
                if (!_words[randomIndex].IsHidden())
                {
                    _words[randomIndex].Hide();
                    break;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        List<string> displayText = new List<string>();

        foreach (Word word in _words)
        {
            displayText.Add(word.IsHidden() ? new string('_', word.GetDisplayText().Length) : word.GetDisplayText()); //resource: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
        }

        return $"{_reference.GetDisplayText()}\n{string.Join(" ", displayText)}"; //https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-7.0
    }
    public bool IsCompletelyHidden()
    {        
        return _words.All(word => word.IsHidden()); //https://www.csharptutorial.net/csharp-linq/linq-all/
    }
}