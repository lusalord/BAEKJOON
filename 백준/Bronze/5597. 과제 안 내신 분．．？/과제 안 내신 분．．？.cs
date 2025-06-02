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
            int[] arr = new int[31];

            for(int  i = 0; i < 28; i++)
            {
                int a = int.Parse(Console.ReadLine());

                arr[a] = 1;
            }

            for(int i = 1; i < 31; i++)
            {
                if (arr[i] != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}