using System;
using System.Collections.Generic;

class duplicate
{
    static void CountOccurrences(int[] arr, int len)
    {
        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        for (int i = 0; i < len; i++)
        {
            if (elementCount.ContainsKey(arr[i]))
            {
                elementCount[arr[i]]++;
            }
            else
            {
                elementCount.Add(arr[i], 1);
            }
        }
        Console.WriteLine("Unique elements are");
        foreach (var entry in elementCount)
        {
            Console.WriteLine($"{entry.Key}");
        }
    }
    static void Main()
    {
        int[] arr = { 12, 11, 40, 12, 5, 6, 5, 12, 11, 8, 9, 8 };
        int n = arr.Length;

        CountOccurrences(arr, n);
        Console.ReadLine();
    }
}