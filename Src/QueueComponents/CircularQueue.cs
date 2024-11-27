public class CircularQueue<T> : IQueue<T>
{
    private readonly T[] _buffer;
    private int _head;
    private int _tail;
    private int _count;

    public CircularQueue(int capacity = 30)
    {
        _buffer = new T[capacity];
        _head = 0;
        _tail = 0;
        _count = 0;
    }

    public void Enqueue(T item)
    {
        if (_count == _buffer.Length)
            throw new InvalidOperationException("Queue is full.");

        _buffer[_tail] = item;
        _tail = (_tail + 1) % _buffer.Length;
        _count++;
    }

    public T? Dequeue()
    {
        if (_count == 0)
            return default;

        T item = _buffer[_head];
        _buffer[_head] = default!;
        _head = (_head + 1) % _buffer.Length;
        _count--;

        return item;
    }

    public T? Peek()
    {
        if (_count == 0)
            return default;

        return _buffer[_head];
    }

    public int Count => _count;

    public bool IsEmpty => _count == 0;

    public bool IsFull => _count == _buffer.Length;

    public int Capacity => _buffer.Length;
}