using System;
using System.Collections.Generic;

class Duplicate
{
    static void CountOccurrences(int[] arr, int len)
    {
        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        int maxElement = int.MinValue;
        int minElement = int.MaxValue;

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
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
            }

            if (arr[i] < minElement)
            {
                minElement = arr[i];
            }
        }
        Console.WriteLine($"Maximum element: {maxElement}");
        Console.WriteLine($"Minimum element: {minElement}");
    }

    static void Main()
    {
        int[] arr = { 12, 11, 40, 12, 5, 6, 5, 12, 11, 8, 9, 8 };
        int n = arr.Length;

        CountOccurrences(arr, n);
        Console.ReadLine();
    }
}
