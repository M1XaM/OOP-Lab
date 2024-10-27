using System.Linq;
using System.IO;
using System;

namespace TextDataNamespace;
public class TextData
{
    private string? fileName;
    private string text;
    private int numberOfVowels;
    private int numberOfConsonants;
    private int numberOfLetters;
    private int numberOfSenteces;
    private string longestWord;

    public TextData(string text)
    {
        if (text.Length == 0)
        {
            throw new InvalidOperationException("Error in proccessing: Empty file.");
        }
        else
        {
            this.text = text;
        }
        numberOfVowels = text.Count(c => "aeiouAEIOU".Contains(c) ? true : false);
        numberOfConsonants = text.Count(c => "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWYXZ".Contains(c) ? true : false);
        numberOfLetters = text.Count(c => char.IsLetter(c) ? true : false);
        numberOfSenteces = text.Count(c => c == '.');
        longestWord = text.Split(new char[] { ' ', '.', ',', '!', '?'})
                            .OrderByDescending(w => w.Length)
                            .FirstOrDefault()
                            ?? "Last word not found";
    }

    public string? getFilename()
    {
        return fileName;
    }

    public string getText()
    {
        return text;
    }

    public int getNumberOfVowels()
    {
        return numberOfVowels;
    }

    public int getNumberOfConsonants()
    {
        return numberOfConsonants;
    }

    public int getNumberOfLetters()
    {
        return numberOfLetters;
    }

    public int getNumberOfSenteces()
    {
        return numberOfSenteces;
    }

    public string getLongestWord()
    {
        return longestWord;
    }

    public void setFileName(string fileName)
    {
        this.fileName = Path.GetFileName(fileName);
    }
}