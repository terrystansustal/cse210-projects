using System;
using System.Collections.Generic;

public class Word
{
    private string _word;

    private bool _hidden;

    // Constructors
    public Word(string show_words)
    {
        _word = show_words;
        _hidden = false;
    }

    // Getter to return _words
    // Have an if statement (if hidden == true / print _)
    public void DisplayWords()
    {
        if (_hidden == true)
        {
            foreach(char letter in _word)
            {
                Console.WriteLine("_");
            }
        }

        else
        {
            Console.WriteLine(_word);
        }
    }

    public string GetWord()
    {
        return _word;
    }

    // Getter to return status of hidden

    public bool GetHidden()
    {
        return _hidden;
    }

    // Setter that sets hidden (true or false)
    public void SetHidden(bool hidden)
    {
        _hidden = hidden;
    }

    public void HideWord()
    {
        _hidden = true;

        char[] array = _word.ToCharArray();
        for(int i = 0; i < array.Length; i++)
            {
                array[i] = '_';
            }
        
        _word = new string(array);
        // Console.WriteLine(array);
    }
}