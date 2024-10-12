using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System;

namespace Models
{
    public class OutputModel
    {
        public Dictionary<string, List<InputModel>> Values { get; set; } =  new Dictionary<string, List<InputModel>>
        {
            { "Star Wars", new List<InputModel>() },
            { "Marvel", new List<InputModel>() },
            { "Hitchhiker", new List<InputModel>() },
            { "Lord of the rings", new List<InputModel>() }
        };

        public void ExportJson(string folderPath)
        {
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

            // Iterate through the dictionary and create a JSON file for each key
            foreach (var content in Values)
            {
                string Universe = content.Key;
                string jsonFilePath = Path.Combine(folderPath, $"{Universe}.json");

                // InputModel to JSON
                string jsonString = JsonSerializer.Serialize(content.Value, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON string to a file
                try
                {
                    File.WriteAllText(jsonFilePath, jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing to file {jsonFilePath}: {ex.Message}");
                }
            }
        }
    }
}