using System;
using System.Collections.Generic;
using System.Text;

public class MyStack<T>
{
    private T[] memory;
    private int _count = 0;
    public int Count { get { return _count; } }
    public MyStack(int capacity)
    {
        memory = new T[capacity];
    }

    public void Push(T item)
    {
        memory[_count++] = item;
    }
    public T Pop()
    {
        return memory[--_count]; 
    }
    public T Peek()
    {
        return memory[_count - 1];
    }
    public bool IsEmpty { get { return _count == 0; } }
}