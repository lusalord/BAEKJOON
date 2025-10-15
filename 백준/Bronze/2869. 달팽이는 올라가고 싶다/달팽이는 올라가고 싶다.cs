using System;
using System.IO;
using System.Linq;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            

            int day = (int)Math.Ceiling((double)(arr[2] - arr[1]) / (arr[0] - arr[1]));

            Console.Write(day);
        }
    }
}