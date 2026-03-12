using System;
using System.Collections.Generic;
using System.Text;

public class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    private TKey[] keys;
    private TValue[] values;
    private int _count = 0;

    public Registry(int capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
    }
    public void Register(TKey key, TValue value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (keys[i].Equals(key))
            {
                values[i] = value;
                return;
            }
        }
        keys[_count] = key;
        values[_count] = value;
        _count++;
    }

    public TValue Find(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (keys[i].Equals(key))
            {
                return values[i];
            }
        }
        return default;
    }

    public bool Contains(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (keys[i].Equals(key))
            {
                return true;
            }
        }
        return false;
    }

    public int Count { get { return _count; } }
    public void PrintAll()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine($"[{keys[i]}] {values[i]}");
        }
    }
}