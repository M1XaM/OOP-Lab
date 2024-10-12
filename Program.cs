using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System;

using Models;

class Program
{
    static void Main(string[] args)
    {
        // For storing output
        OutputModel output = new OutputModel();

        // Reading input
        string jsonString = File.ReadAllText("docs/input.json");
        InputWord inputWord = JsonSerializer.Deserialize<InputWord>(jsonString);
        List<InputModel> InputModels = inputWord.input;  // Avoiding 'input' word from input.json

        // Iteration of input species
        foreach (InputModel InputModel in InputModels)
        {
           string Universe = Classify(InputModel);
           if(Universe == null)
           {
            Console.WriteLine($"Id: {InputModel.id} is uncategorized");
            continue;
           }
           output.Values[Universe].Add(InputModel);
        }

        output.ExportJson("output/");
    }

    public static string? Classify(InputModel InputModel)
    {
        foreach (KeyValuePair<string, List<ReferenceModel>> entry in ReferenceModel.GetAllSpecies())
        {
            string Universe = entry.Key;
            List<ReferenceModel> SpeciesFromOneUniverse = entry.Value;

            // Iteration of the species in each universe
            foreach (ReferenceModel ReferenceModel in SpeciesFromOneUniverse)
            {
                // Classification
                if (InputModel.isHumanoid.HasValue && InputModel.isHumanoid != ReferenceModel.isHumanoid)
                    continue;
                if (!string.IsNullOrEmpty(InputModel.planet) && InputModel.planet != ReferenceModel.planet)
                    continue;
                if (InputModel.age.HasValue && InputModel.age > ReferenceModel.ageMax)
                    continue;
                if (InputModel.traits != null && InputModel.traits.Count > 0 && (ReferenceModel.traits == null || !InputModel.traits.All(trait => ReferenceModel.traits.Contains(trait))))
                    continue;
                return Universe;
            }
        }
        return null;
    }
}

