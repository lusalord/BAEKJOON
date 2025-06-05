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
            int n = int.Parse(Console.ReadLine());

            string word = Console.ReadLine();
            string[] token = word.Split();

            int count = n;

            for(int i = 0; i < n; i++)
            {
                if (int.Parse(token[i]) == 1)
                {
                    count--;
                    continue;
                }
                for(int j = 2; j < int.Parse(token[i]); j++)
                {
                    if (int.Parse(token[i]) % j == 0)
                    {
                        count--;
                        break;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}