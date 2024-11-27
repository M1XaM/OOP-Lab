using System;

public class RobotDinner : IDineable
{
    private static int _count = 0;

    public void serveDinner(int carId)
    {
        _count++;
        Console.WriteLine($"Serving dinner to robots on car {carId}.");
    }

    public static int GetCount() => _count;
}