using System.IO;
using System;
using FileReaderNamespace;
using TextDataNamespace;

class Program
{
    public static void Main(string[] args)
    {
        if(args.Length == 0)
        {
            Console.WriteLine("Input Error: a file must be passed");
            return;
        }
        else if(args.Length > 1)
        {
            Console.WriteLine("Only first file will be proccessed; See Task4 for multiple input file");
        }

        string filePath = args[0];
        string text = FileReader.readFileIntoString(filePath);

        TextData textData = new TextData(text);
        textData.setFileName(filePath);

        Console.WriteLine(textData.getFilename());
        Console.WriteLine(textData.getNumberOfVowels());
        Console.WriteLine(textData.getNumberOfConsonants());
        Console.WriteLine(textData.getNumberOfLetters());
        Console.WriteLine(textData.getNumberOfSenteces());
        Console.WriteLine(textData.getLongestWord());
    }
}