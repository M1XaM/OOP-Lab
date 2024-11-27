public class LinkedListQueue<T> : IQueue<T>
{
    private readonly LinkedList<T> _list;

    public LinkedListQueue()
    {
        _list = new LinkedList<T>();
    }

    public void Enqueue(T item)
    {
        _list.AddLast(item);
    }

    public T? Dequeue()
    {
        if (_list.Count == 0)
            return default;

        var value = _list.First!.Value;
        _list.RemoveFirst();
        return value;
    }

    public T? Peek()
    {
        if (_list.Count == 0)
            return default;

        return _list.First!.Value;
    }

    public int Count => _list.Count;

    public bool IsEmpty => _list.Count == 0;
}
