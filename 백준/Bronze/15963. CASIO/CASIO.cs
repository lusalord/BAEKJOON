using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            if (arr[0] == arr[1])
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        
    }
}

