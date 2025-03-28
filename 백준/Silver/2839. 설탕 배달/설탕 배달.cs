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
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (true) 
            {
                if(n==1 || n == 2)
                {
                    Console.WriteLine(-1);
                    break;
                }
                else if(n % 5 == 0)
                {
                    count += n / 5;
                    Console.WriteLine(count);
                    break;
                }
                n -= 3;
                count++;
            }
        }
    }
}