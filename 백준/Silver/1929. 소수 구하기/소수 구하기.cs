using System;
using System.Linq;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] num = new int[n[1] - n[0] + 1];

            for (int i = n[0]; i <= n[1]; i++)
            {
                if(i == 1)
                {
                    num[i - n[0]] = 1;
                    continue;
                }
                if (i == 2)
                {
                    num[i - n[0]] = 0;
                    continue;
                }
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                num[i - n[0]] = isPrime ? 0 : 1;
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 0)
                {
                    Console.WriteLine(i + n[0]);
                }
                
            }
        }
    }
}