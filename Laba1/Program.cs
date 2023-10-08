using System;

namespace Laba1;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { -5, 8, 33, -105, 1, 0, 90, -888, 0, -3, 17 };
        int sum = 0;
        int sum2 = 0;
        bool zeroInArray = false;
        foreach (int i in array)
        {
            if (i > 0)
            {
                sum = sum + 1;
            }
            if (i == 0)
            {
                sum2 = 0;
                zeroInArray = true;
            }
            sum2 += i;
        }
        if (!zeroInArray)
            sum2 = 0;
        Console.WriteLine(sum);
        Console.WriteLine(sum2);

        for (int i = 0; i < array.Length; i++)
        {// -6 1 3 -5 4 -9
            if (array[i] < 1)
                continue;
            int j;
            for (j = i + 1; j < array.Length; j++)
            {
                if (array[j] < 1)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    break;
                }
            }
            if (j == array.Length)
            {
                break;
            }

        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.ReadLine();
    }
}