using System;
using System.IO;

namespace FileReaderNamespace;
public class FileReader
{
    public static string readFileIntoString(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("The specified file was not found.", filePath);
        }
        
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (IOException ex)
        {
            throw new IOException($"An error occurred: {ex.Message}");
        }
    }
}