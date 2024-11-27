using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Semaphore
{
    private int _countdown = 0;
    private int _totalCount = 0;

    public void ReadStream(int n = 5)
    {
        int readCount = 0;
        do
        {
            readCount = ReadDirectory();
            _totalCount += readCount;

            if (readCount != 0)
                _countdown = 0;
            else
                _countdown++;

            Thread.Sleep(n * 1000);
        } while(_countdown < 2);

        DisplayResults();
    }

    public int ReadDirectory(string inputDirectory = "output/")
    {
        int count = 0;
        try
        {
            string[] jsonFiles = Directory.GetFiles(inputDirectory, "*.json");

            foreach (string file in jsonFiles)
            {
                string? jsonString = File.ReadAllText(file);
                if (jsonString == null)
                    continue;

                Car? obj = JsonSerializer.Deserialize<Car>(jsonString);
                if (obj != null)
                {
                    Clasify(obj);
                    count++;
                    File.Delete(file);
                }
            }
            Console.WriteLine($"Successfully read {count} files.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return count;
    }

    public void Clasify(Car car)
    {
        IRefuelable foo;
        IDineable bar;

        if (car.type == "ELECTRIC")
            foo = new ElectricStation();
        else 
            foo = new GasStation();

        if (car.passengers == "ROBOTS")
            bar = new RobotDinner();
        else 
            bar = new PeopleDinner();

        CarStation station = new CarStation(foo, bar, QueueDistribution.GetQueue());
        station.addCar(car);
        station.serveCar();
    }

    public void DisplayResults()
    {
        Console.WriteLine("\n\nWere served " + _totalCount + " cars.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Gas station cars: " + GasStation.GetCount() + " (consumption: " + GasStation.GetConsumption() + ")");
        Console.WriteLine("Electric station cars: " + ElectricStation.GetCount() + " (consumption: " + ElectricStation.GetConsumption() + ")");
        Console.WriteLine("People dinner: " + PeopleDinner.GetCount());
        Console.WriteLine("Robot dinner: " + RobotDinner.GetCount());
    }
}