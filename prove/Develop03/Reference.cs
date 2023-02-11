using System;
using System.Collections.Generic;

public class Reference
{
    private string _book;
    private string _chapter;

    private string _verse;
    private string _secondVerse;
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = "";
    }

    public Reference(string book, string chapter, string verse, string secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;
    }

    public string DisplayScripture()
    {
        if (_secondVerse == "")
        {
            Console.WriteLine();
            string scriptureNow = $"{_book} {_chapter}:{_verse}";
            Console.WriteLine();
            return scriptureNow;
        }

        else
        {   
            Console.WriteLine();
            string scriptureNow = $"{_book} {_chapter}:{_verse}-{_secondVerse}";
            Console.WriteLine();
            return scriptureNow;
        }
    }
}