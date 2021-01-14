using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private readonly Queue<T> buffer;
    private readonly int capacity;


    public CircularBuffer(int capacity)
    {
        this.buffer = new Queue<T>(capacity);
        this.capacity = capacity;
    }

    public T Read()
    {
        return buffer.Dequeue();
    }

    public void Write(T value)
    {
        if (buffer.Count == capacity)
        {
            throw new InvalidOperationException();
        }

        buffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (buffer.Count == capacity)
        {
            buffer.Dequeue();
        }

        buffer.Enqueue(value);

    }

    public void Clear()
    {
        buffer.Clear();
    }
}