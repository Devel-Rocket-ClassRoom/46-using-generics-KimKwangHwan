using System;
using System.Collections.Generic;
using System.Text;

public class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    public static void SwapInArray<T>(T[] array, int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (min.CompareTo(array[i]) > 0)
                min = array[i];
        }
        return min;
    }
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (max.CompareTo(array[i]) < 0)
                max = array[i];
        }
        return max;
    }
    public static void Reverse<T>(T[] array)
    {
        for (int i = 0; i < array.Length / 2; ++i)
        {
            T tmp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = tmp;
        }
    }
}