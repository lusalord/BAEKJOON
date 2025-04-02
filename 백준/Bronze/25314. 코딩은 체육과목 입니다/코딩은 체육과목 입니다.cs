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
            int b = 0;
            while (true)
            {
                if(a % 4 == 0)
                {
                    a = a - 4;
                    b++;
                    if(a == 0)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for(int i = 0; i < b; i++)
            {
                Console.Write("long ");
            }
            Console.Write("int");
        }
    }
}