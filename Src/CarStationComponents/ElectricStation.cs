using System;

public class ElectricStation : IRefuelable
{
    private static int _count = 0;
    private static int _consumption = 0;

    public void refuel(int carId, int carConsumption)
    {
        _count++;
        _consumption += carConsumption;
        Console.WriteLine($"Charging electric car {carId}.");
    }

    public static int GetCount() => _count;

    public static int GetConsumption() => _consumption;
}