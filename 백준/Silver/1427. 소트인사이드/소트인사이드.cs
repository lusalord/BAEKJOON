using System;
using System.Collections;
using System.Linq;
using System.Text;

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
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((char)arr[i]);
            }
        }

    }
}