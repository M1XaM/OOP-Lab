using FluentAssertions;
using Xunit;

public class CarStationTest
{
    [Fact]
    public static void TestEnqueue()
    {
        Console.WriteLine("Testing enqueue");
        var carStation = new CarStation( new GasStation(), new PeopleDinner(), QueueDistribution.GetQueue());
        var queue = carStation.GetQueue();
        var car = new Car() { id = 9, type = "ELECTRIC", passengers = "PEOPLE", isDining = true, consumption = 20};
        carStation.addCar(car);
        queue.Peek().Should().Be(car);
    }

    [Fact]
    public static void TestDequeue()
    {
        Console.WriteLine("Testing dequeue");
        var carStation = new CarStation( new GasStation(), new PeopleDinner(), QueueDistribution.GetQueue());
        var queue = carStation.GetQueue();
        var car1 = new Car() { id = 10, type = "ELECTRIC", passengers = "PEOPLE", isDining = true, consumption = 20};
        var car2 = new Car() { id = 11, type = "GAS", passengers = "PEOPLE", isDining = false, consumption = 30};
        queue.Enqueue(car1);
        queue.Enqueue(car2);
        carStation.serveCar();
        queue.Peek().Should().Be(car2);
    }
}

