using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] arr = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                arr[i] = input[i];
            }

            Array.Sort(arr);
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write((char)arr[i]);
            }
        }
    }
}