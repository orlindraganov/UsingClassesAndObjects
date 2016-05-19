using System;
using System.Linq;

class SumIntegers
{
    static int[] GetArray()
    {
        int[] arr = Console.ReadLine()
        .Split(' ')
        .Select(s => int.Parse(s)).ToArray();
        return arr;
    }

    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static void Main()
    {
        int[] arr = GetArray();
        Console.WriteLine(CalculateSum(arr));
    }
}
