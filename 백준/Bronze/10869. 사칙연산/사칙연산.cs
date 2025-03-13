using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(arr[0] + arr[1]);
            Console.WriteLine(arr[0] - arr[1]);
            Console.WriteLine(arr[0] * arr[1]);
            Console.WriteLine(arr[0] / arr[1]);
            Console.WriteLine(arr[0] % arr[1]);
        }
    }
}