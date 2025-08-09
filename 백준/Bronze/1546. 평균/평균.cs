using System;
using System.Linq;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            float[] num = new float[n];
            float sum = 0;

            arr = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

            float max = arr.Max();


            for(int i = 0; i < n; i++)
            {
                num[i] = arr[i]/max * 100;
                sum += num[i];
            }
            Console.WriteLine(num.Average());
        }
    }
}