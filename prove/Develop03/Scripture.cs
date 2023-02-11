using System;
using System.Collections.Generic;

public class Scripture
{
    // Attributes
    private string _textOfScripture;
    private Reference _reference;

    // List of word objects
    private List<Word> _words;

    // Constructors

    public Scripture(string textOfScripture, Reference reference)
    {
        _words = new List<Word>(); 
        _textOfScripture = textOfScripture;
        _reference = reference;

        // Parse scripture in to word obj list
        string[] array = _textOfScripture.Split(" ");
        // for each strin in the string array create new word object and add it to the list of word objects
        foreach(string text in array)
        {
            Word word = new Word(text);
            _words.Add(word);
        }
    }

    // Method

    public void Display()
    {
        Console.WriteLine(_reference);

        string verse = "";
        foreach (Word word in _words)
        {
            verse = verse + " " + word.GetWord();
        }
        Console.WriteLine(verse);
        Console.WriteLine("");
    }

    public void HideWords()
    {
        int index = 0;
        string end = Continue();

        do
        {
            // Pick a random word
            Random randomWord = new Random();
            index = randomWord.Next(_words.Count);
            end = Continue();

            // Word is hidden pick new random index
            if (end == "STOP")
            {
                break;
            }

        } while (_words[index].GetHidden());


        if (end != "STOP")
        {
            string hideWord = _words[index].GetWord();

            Word hide = new Word(hideWord);

            // Set to hidden and change word to _'s
            hide.HideWord();

            // Replace the word in the list
            _words[index] = hide;
        }
    }

    // If the word is already hidden return "STOP"
    public string Continue()
    {
        string end = "STOP";

        foreach (Word word in _words)
        {
            if (word.GetHidden() == false) // word is not hidden
            {
                end = "";
            }
        }
        return end;
    }
}

