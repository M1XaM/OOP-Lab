public static class QueueDistribution
{
    private static int _count = 0;

    public static IQueue<Car> GetQueue()
    {
        switch(_count)
        {
            case 0:
                _count++;
                return new ArrayQueue<Car>();
            case 1:
                _count++;
                return new LinkedListQueue<Car>();
            default:
                _count = 0;
                return new CircularQueue<Car>();
        }
    }
}