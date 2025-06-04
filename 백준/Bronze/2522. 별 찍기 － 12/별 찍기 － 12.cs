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

            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                for(int j = a - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = a; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}