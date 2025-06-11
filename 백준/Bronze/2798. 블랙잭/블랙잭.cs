using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = arr[0], M = arr[1];
            int[] cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int max = 0;

            for(int i = 0;  i < N - 2; i++)
            {
                for(int j = i + 1; j < N - 1; j++)
                {
                    for(int k = j + 1; k < N; k++)
                    {
                        int sum = cards[i] + cards[j] + cards[k];

                        if(sum <= M && sum > max)
                        {
                            max = sum;
                            if(M == max)
                            {
                                Console.WriteLine(max);
                                return;
                            }
                        }
                    }
                }
            }            
            Console.WriteLine(max);
        }
    }
}