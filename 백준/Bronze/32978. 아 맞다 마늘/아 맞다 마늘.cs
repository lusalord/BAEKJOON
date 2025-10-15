using System;
using System.IO;
using System.Linq;


namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            arr = Console.ReadLine().Split();

            arr = arr.Distinct().ToArray();

            string[] arr2 = new string[n - 1];
            arr2 = Console.ReadLine().Split();

            string[] result = string.Join(" ", arr2.Intersect(arr2)).Split();

            foreach (var item in arr)
            {
                if (!result.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}