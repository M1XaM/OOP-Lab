using System;

public class CarStation
{
    private IDineable _diningService;
    private IRefuelable _refuelingService;
    private IQueue<Car> _queue;

    public CarStation(IRefuelable refuelingService, IDineable diningService, IQueue<Car> queue)
    {
        _refuelingService = refuelingService;
        _diningService = diningService;
        _queue = queue;
    }

    public void serveCar()
    {
        var car = _queue.Dequeue();
        if (car == null)
            return;

        if (car.isDining)
            _diningService.serveDinner(car.id);
        
        _refuelingService.refuel(car.id, car.consumption);
    }

    public void addCar(Car car)
    {
        _queue.Enqueue(car);
    }

    public IQueue<Car> GetQueue() => _queue;
}