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
            int count = int.Parse(Console.ReadLine());

            if(count >= 90)
            {
                Console.WriteLine('A');
            }
            else if(count >= 80)
            {
                Console.WriteLine('B');
            }
            else if(count >= 70)
            {
                Console.WriteLine('C');
            }
            else if(count >= 60)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine('F');
            }
        }
    }
}