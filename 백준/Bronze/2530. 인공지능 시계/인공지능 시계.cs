using System;
using System.IO;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int C = int.Parse(Console.ReadLine());
            int sum = A[2] + C;
            A[1] += sum / 60;
            sum %= 60;
            A[0] += A[1] / 60;
            A[1] %= 60;
            A[0] %= 24;


            Console.WriteLine("{0} {1} {2}", A[0], A[1], sum);
        }
        
    }
}

