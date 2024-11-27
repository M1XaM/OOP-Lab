using System;
using System.Collections.Generic;

public interface IQueue<T>
{
    public void Enqueue(T item);
    public T? Dequeue();
    public T? Peek();
}