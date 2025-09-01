using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            arr[0] %= arr[1];

            for (int i = 0; i < arr[2] - 1; i++)
            {
                arr[0] = (arr[0] * 10) % arr[1];
            }

            Console.WriteLine((arr[0] * 10) / arr[1]);
        }
    }
}